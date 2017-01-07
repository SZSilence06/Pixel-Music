using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using MusicGame;

public class GameController : MonoBehaviour {
    private Stage stage;
    private StageData stageData;
    private ScoreBoard scoreBoard = null;

    private LinkedList<GameObject> noteList = new LinkedList<GameObject>();

    private GameObject background = null;
    private GameObject clickParticlePrefab = null;

    private Text scoreText = null;
    private ComboText comboText = null;

    private Dictionary<NoteData.NoteType, GameObject> notePrefabDictionary = new Dictionary<NoteData.NoteType, GameObject>();

    public static readonly float TIMELINE_HEIGHT = 0.5f;

    public static readonly float DROP_HEIGHT = 5.0f;

    private int dropTime = (int)((DROP_HEIGHT - TIMELINE_HEIGHT) / Note.FALL_SPEED);

    int frame = 0;

    public LinkedList<GameObject> NoteList
    {
        get
        {
            return noteList;
        }
    }

	// Use this for initialization
	void Start () {
        stageData = StageData.GetInstance();
        stage = stageData.CurrentStage;
        this.scoreBoard = ScoreBoard.GetInstance();

        background = GameObject.Find("Background");
        background.GetComponent<SpriteRenderer>().sprite = Sprite.Create(stage.BackgroundImage, new Rect(0, 0, 800, 480), new Vector2(0.5f, 0.5f));
        float resolutionRatio = Screen.width * 1.0f / Screen.height;
        background.transform.localScale = new Vector3(resolutionRatio / (800f / 480f), 1, 1);

        UIEventListener.Get(GameObject.Find("Back")).onClick = (GameObject sender) =>
        {
            ReturnToTitle();
        };

        this.scoreText = GameObject.Find("Score").GetComponent<Text>();
        this.comboText = GameObject.Find("Combo").GetComponent<ComboText>();

        InitNotePrefabDictionary();

        clickParticlePrefab = Resources.Load("prefab/ClickParticle") as GameObject;

        ScoreBoard.GetInstance().Reset();
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        LoadNotes();

        frame++;
	}

    void InitNotePrefabDictionary()
    {
        this.notePrefabDictionary.Add(NoteData.NoteType.SIMPLE, Resources.Load("prefab/note1") as GameObject);
        this.notePrefabDictionary.Add(NoteData.NoteType.HOLD, Resources.Load("prefab/note2") as GameObject);
    }

    public void LoadNotes()
    {
        var notes = stage.Notes;

        foreach(NoteData noteData in notes)
        {
            if(noteData.OccurFrame - dropTime + 300 == frame)
            {
                GameObject note = Instantiate(notePrefabDictionary[noteData.Type]);
                Note noteScript = note.GetComponent<Note>();
                noteScript.Data = noteData;
                noteScript.Init();
            }
        }
    }

    public void ShowClickEffect(int channel)
    {
        GameObject newClickParticle = Instantiate(clickParticlePrefab);

        newClickParticle.transform.position = new Vector3(0.8f + 1.28f * channel, 0.5f, 2f);

        ParticleSystem particleSystem = newClickParticle.GetComponent<ParticleSystem>();
        particleSystem.startColor = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
        particleSystem.Play();

        Destroy(newClickParticle, 0.65f);
    }

    void ReturnToTitle()
    {
        SceneManager.LoadScene("start");
    }

    public void HitPerfect()
    {
        this.scoreBoard.HitPerfect();
        comboText.ShowPerfect();
        UpdateScore();
    }

    public void HitGood()
    {
        this.scoreBoard.HitGood();
        comboText.ShowGood();
        UpdateScore();
    }

    public void HitBad()
    {
        this.scoreBoard.HitBad();
        comboText.ShowBad();
        UpdateScore();
    }

    public void HitMiss()
    {
        this.scoreBoard.HitMiss();
        comboText.ShowMiss();
        UpdateScore();
    }

    public void UpdateScore()
    {
        scoreText.text = "Score" + "\n" + scoreBoard.Score.ToString("D8") + "\n" + "Max Combo" + "\n" + scoreBoard.MaxCombo;
    }
}
