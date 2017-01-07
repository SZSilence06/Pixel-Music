using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using MusicGame;

public class AudioPlayer : MonoBehaviour {
    AudioSource audioSource = null;
    int frame = 0;
    int audioLength;

	// Use this for initialization
	void Start () {
        this.audioSource = this.GetComponent<AudioSource>();

        StageData stageData = StageData.GetInstance();
        Stage stage = stageData.CurrentStage;

        audioSource.clip = stage.Music;
        audioSource.volume = 1.0f;
        this.audioLength = (int)(audioSource.clip.length * 50) + 200;
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        frame++;
        if(frame == 300 && StageData.GetInstance().Muted == false)
        {
            audioSource.Play();
        }

        if(frame > 300 && frame == this.audioLength)
        {
            EndPlaying();
        }
	}

    void EndPlaying()
    {
        SceneManager.LoadScene("score");
    }
}
