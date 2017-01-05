using UnityEngine;
using System.Collections.Generic;
using MusicGame;

public class GameController : MonoBehaviour {
    private Stage stage;
    private StageData stageData;

    private LinkedList<GameObject> noteList = new LinkedList<GameObject>();

    private GameObject background = null;

    private GameObject clickParticlePrefab = null;

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

        background = GameObject.Find("Background");
        background.GetComponent<SpriteRenderer>().sprite = Sprite.Create(stage.BackgroundImage, new Rect(0, 0, 800, 480), new Vector2(0f, 0f));
        background.transform.position = new Vector3(0, 0, 10);

        InitNotePrefabDictionary();

        clickParticlePrefab = Resources.Load("prefab/ClickParticle") as GameObject;
	}
	
	// Update is called once per frame
	void Update () {

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
}
