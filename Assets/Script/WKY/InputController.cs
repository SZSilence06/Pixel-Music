using UnityEngine;
using System.Collections;
using MusicGame;

public class InputController : MonoBehaviour {

    private GameController gameController = null;

    private Vector2 PixelStandardize(Vector2 pixelPos)
    {
        return new Vector2(pixelPos.x / Screen.width * 800, pixelPos.y / Screen.height * 480);
    }
	// Use this for initialization
	void Start () {
        gameController = GameObject.Find("GameController").GetComponent<GameController>();
	}
	
	// Update is called once per frame
	void Update () {
        for (int i = 0; i < Input.touchCount; i++)
        {
            Touch touch = Input.GetTouch(i);
            Vector2 inputPosition = PixelStandardize(touch.position);
            if (inputPosition.y < 120 && inputPosition.y > 20)
            {
                int channel = (int)(inputPosition.x / (800.0f / 6.0f));
                var noteList = gameController.NoteList;
                Note selectedNote = null;
                foreach (GameObject note in noteList)
                {
                    Note noteScript = note.GetComponent<Note>();
                    NoteData data = noteScript.Data;
                    if (data.Channel == channel)
                    {
                        if (selectedNote)
                        {
                            if (noteScript.IsValid() && note.transform.position.y < selectedNote.transform.position.y)
                            {
                                selectedNote = noteScript;
                            }
                        }
                        else
                        {
                            if (noteScript.IsValid())
                            {
                                selectedNote = noteScript;
                            }
                        }
                    }
                }
                if (selectedNote)
                {
                    switch(touch.phase)
                    {
                        case TouchPhase.Began:
                            selectedNote.OnClicked();
                            break;
                        case TouchPhase.Moved:
                            break;
                        case TouchPhase.Stationary:
                            selectedNote.OnHold();
                            break;
                        case TouchPhase.Ended:
                            selectedNote.OnTouchUp();
                            break;
                    } 
                }   
            }
        }   
	}
}  
