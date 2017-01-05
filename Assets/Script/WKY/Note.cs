using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using MusicGame;

public abstract class Note : MonoBehaviour
{
    public static readonly int MISS_TIME = 10;
    public static readonly int BAD_TIME = 7;
    public static readonly int GOOD_TIME = 3;

    public static float INIT_HEIGHT = 5.0f;
    public static readonly float FALL_SPEED = 0.05f;
    public static readonly float MIN_VALID_HEIGHT = 0.5f - FALL_SPEED * MISS_TIME;

    public static GameController gameController = null;

    protected NoteData noteData;

    public NoteData Data
    {
        get
        {
            return this.noteData;
        }
        set
        {
            this.noteData = value;
        }
    }

    virtual protected void Start()
    {
        gameController = GameObject.Find("GameController").GetComponent<GameController>();
        gameController.NoteList.AddLast(this.gameObject);
    }

    virtual protected void Update()
    {
        if(this.transform.position.y < MIN_VALID_HEIGHT)
        {
            ScoreBoard.GetInstance().HitMiss();
        }
    }

    protected void DestroySelf()
    {
        gameController.NoteList.Remove(this.gameObject);
        Destroy(this.gameObject);
    }

    public abstract void Init();

    public virtual void OnClicked()
    {

    }
    public virtual void OnHold()
    {

    }

    public virtual void OnTouchUp()
    {

    }

    public virtual bool IsValid()
    {
        return this.transform.position.y >= MIN_VALID_HEIGHT;
    }
}
