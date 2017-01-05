using UnityEngine;
using System.Collections;
using System;

namespace MusicGame
{
    public class Note1 : Note
    {
        ScoreBoard scoreBoard = null;

        // Use this for initialization
        protected override void Start()
        {
            base.Start();
            scoreBoard = ScoreBoard.GetInstance();
        }

        // Update is called once per frame
        protected override void Update()
        {
            base.Update();

            if (transform.position.y < -0.16f)
            {
                DestroySelf();
            }

            var newPos = transform.position;
            newPos.y -= FALL_SPEED;
            transform.position = newPos;
        }

        public override void Init()
        {
            this.transform.position = new Vector3(0.8f + 1.28f * this.noteData.Channel, 5f, 0f);
        }

        public override void OnClicked()
        {
            base.OnClicked();

            if (IsValid() == false)
            {
                return;
            }

            int leftFrame = (int)((this.transform.position.y - GameController.TIMELINE_HEIGHT) / Note.FALL_SPEED);
            int absLeftFrame = Math.Abs(leftFrame);
            if (absLeftFrame <= Note.MISS_TIME)
            {
                DestroySelf();
                if (absLeftFrame >= Note.BAD_TIME)
                {
                    //bad
                    scoreBoard.HitBad();
                }
                else if (absLeftFrame >= Note.GOOD_TIME)
                {
                    scoreBoard.HitGood();
                }
                else
                {
                    scoreBoard.HitPerfect();
                }
                Note.gameController.ShowClickEffect(this.noteData.Channel);
            }
        }
    }
}

