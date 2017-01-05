using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using MusicGame;

public class TitleInitialize : MonoBehaviour {
    GameObject songList = null;
    StageData stageData = null;
    ArrayList stages = new ArrayList();

	// Use this for initialization
	void Start () {
        songList = GameObject.Find("stage1").transform.FindChild("Canvas").gameObject;
        stageData = StageData.GetInstance();

        LoadSongs();
        AddSongListCallback();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void AddSongListCallback()
    {
        for(int i = 0; i < stages.Count; i++)
        {
            GameObject songImage = songList.transform.FindChild("image" + (i + 1)).FindChild("num").gameObject;
            int index = i;
            UIEventListener.Get(songImage).onClick = (GameObject sender) =>
            {
                Stage stage = stages[index] as Stage;
                stageData.CurrentStage = stage;
                LoadPlayScene();
            };
        }
    }

    void LoadSongs()
    {
        stages.Add(new StageTest());
    }

    void LoadPlayScene()
    {
        SceneManager.LoadScene("play");
    }
}
