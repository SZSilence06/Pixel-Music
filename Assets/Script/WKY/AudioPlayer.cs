using UnityEngine;
using System.Collections;
using MusicGame;

public class AudioPlayer : MonoBehaviour {
    AudioSource audioSource = null;
    int frame = 0;

	// Use this for initialization
	void Start () {
        this.audioSource = this.GetComponent<AudioSource>();

        StageData stageData = StageData.GetInstance();
        Stage stage = stageData.CurrentStage;

        audioSource.clip = stage.Music;
        audioSource.volume = 1.0f;
	}
	
	// Update is called once per frame
	void Update () {
        frame++;
        if(frame == 300)
        {
            audioSource.Play();
        }
	}
}
