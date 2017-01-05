using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

namespace MusicGame
{
    class Note2 : Note
    {
        private enum HitType
        {
            PERFECT,
            GOOD,
            BAD,
            NONE
        }

        private Image image;
        private ScoreBoard scoreBoard = null;
        private int duration;

        private bool beingClicked = false;
        private bool valid = true;

        private HitType hitType = HitType.NONE;

        public int Duration
        {
            get
            {
                return this.duration;
            }
        }

        protected override void Start()
        {
            base.Start();

            this.image = GetComponent<Image>();
            var newSize = image.rectTransform.sizeDelta;
            newSize.y = 52 + noteData.LastTime * Note.FALL_SPEED * 100f;
            image.rectTransform.sizeDelta = newSize;

            this.scoreBoard = ScoreBoard.GetInstance();
        }

        protected override void Update()
        {
            if (this.transform.position.y < (MIN_VALID_HEIGHT - 0.2f) * 100f)
            {
                if(valid == true)
                {
                    valid = false;
                    ScoreBoard.GetInstance().HitMiss();
                }
            }

            if (transform.position.y < -16 - this.image.rectTransform.sizeDelta.y)
            {
                DestroySelf();
            }

            if(beingClicked)
            {
                this.duration--;
                var newSize = image.rectTransform.sizeDelta;
                newSize.y -= Note.FALL_SPEED * 100f;
                this.image.rectTransform.sizeDelta = newSize;
                switch (this.hitType)
                {
                    case HitType.BAD:
                        scoreBoard.HitBad();
                        break;
                    case HitType.GOOD:
                        scoreBoard.HitGood();
                        break;
                    case HitType.PERFECT:
                        scoreBoard.HitPerfect();
                        break;
                }
                if (this.duration == 0)
                {
                    Note.gameController.ShowClickEffect(this.noteData.Channel);
                    DestroySelf();
                }
            }
            else
            {
                var newPos = transform.position;
                newPos.y -= FALL_SPEED * 100f;
                transform.position = newPos;
            }
        }

        public override bool IsValid()
        {
            return this.valid;
        }

        public override void Init()
        {
            this.transform.SetParent(GameObject.Find("Canvas").transform, true);
            this.transform.position = new Vector3(80f + 128f * this.noteData.Channel, 480f, 0f);
            this.duration = noteData.LastTime;
        }

        public override void OnClicked()
        {
            base.OnClicked();

            if(IsValid() == false)
            {
                return;
            }

            int leftFrame = (int)((this.transform.position.y - GameController.TIMELINE_HEIGHT + 20f) / (Note.FALL_SPEED * 100f));
            int absLeftFrame = Math.Abs(leftFrame);
            if (absLeftFrame <= Note.MISS_TIME)
            {
                if(beingClicked == false)
                {
                    beingClicked = true;
                    if (absLeftFrame >= Note.BAD_TIME)
                    {
                        hitType = HitType.BAD;
                    }
                    else if (absLeftFrame >= Note.GOOD_TIME)
                    {
                        hitType = HitType.GOOD;
                    }
                    else
                    {
                        hitType = HitType.PERFECT;
                    }
                    Note.gameController.ShowClickEffect(this.noteData.Channel);
                }
                var newPos = transform.position;
                newPos.y = 0.3f;
                transform.position = newPos;
            }
        }

        public override void OnTouchUp()
        {
            base.OnTouchUp();

            if (IsValid() == false)
            {
                return;
            }

            if(beingClicked == true)
            {
                beingClicked = false;
                valid = false;
                if (this.duration >= 5)
                {
                    scoreBoard.HitMiss();
                }
            }
        }
    }
}
