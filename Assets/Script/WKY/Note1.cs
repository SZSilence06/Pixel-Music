using UnityEngine;
using System.Collections;
using System;

namespace MusicGame
{
    public class Note1 : Note
    {
        ScoreBoard scoreBoard = null;
        private bool valid = true;

        // Use this for initialization
        protected override void Start()
        {
            base.Start();
            scoreBoard = ScoreBoard.GetInstance();

            float resolutionRatio = Screen.width * 1.0f / Screen.height / (800f / 480f);
            this.transform.localScale = new Vector3(resolutionRatio, 1, 1);

            Vector3 newPos = this.transform.position;
            newPos.x = (newPos.x - 4) * resolutionRatio + 4;
            this.transform.position = newPos;
        }

        // Update is called once per frame
        protected override void FixedUpdate()
        {
            if (this.transform.position.y < MIN_VALID_HEIGHT)
            {
                if (valid == true)
                {
                    valid = false;
                    base.gameController.HitMiss();
                }
            }

            if (transform.position.y < -1f)
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
                    base.gameController.HitBad();
                }
                else if (absLeftFrame >= Note.GOOD_TIME)
                {
                    base.gameController.HitGood();
                }
                else
                {
                    base.gameController.HitPerfect();
                }
                base.gameController.ShowClickEffect(this.noteData.Channel);
            }
        }

        public override bool IsValid()
        {
            return this.valid;
        }
    }
}

