using UnityEngine;
using UnityEngine.UI;
using MusicGame;
using System.Collections;

public class ComboText : MonoBehaviour {
    private ScoreBoard scoreBoard = null;
    private Text text = null;

    private int frame = 0;

    enum State
    {
        HIDE,
        SHOW
    }

    private State state = State.HIDE;

	// Use this for initialization
	void Start () {
        scoreBoard = ScoreBoard.GetInstance();
        text = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        if (state == State.SHOW)
        {
            frame++;
            if (frame > 30)
            {
                Color newColor = text.color;
                newColor.a -= 1.0f / 30.0f;
                text.color = newColor;
            }
            if (frame > 60)
            {
                state = State.HIDE;
                frame = 0;
            }
        }
	}

    public void ShowPerfect()
    {
        state = State.SHOW;
        frame = 0;
        text.text = scoreBoard.Combo + "\n" + "Perfect";
        text.color = new Color(1, 1, 0, 1);
    }

    public void ShowGood()
    {
        state = State.SHOW;
        frame = 0;
        text.text = scoreBoard.Combo + "\n" + "Good";
        text.color = new Color(0, 1, 0, 1);
    }

    public void ShowBad()
    {
        state = State.SHOW;
        frame = 0;
        text.text = scoreBoard.Combo + "\n" + "Bad";
        text.color = new Color(0, 0, 1, 1);
    }

    public void ShowMiss()
    {
        state = State.SHOW;
        frame = 0;
        text.text = "Miss";
        text.color = new Color(1, 0, 1, 1);
    }
}
