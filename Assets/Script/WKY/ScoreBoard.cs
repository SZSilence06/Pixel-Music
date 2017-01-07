using UnityEngine;
using UnityEngine.UI;

namespace MusicGame
{
    public class ScoreBoard
    {
        static private ScoreBoard instance = null;

        private int score = 0;
        private int combo = 0;
        private int maxCombo = 0;
        private int miss = 0;
        private int bad = 0;
        private int good = 0;
        private int perfect = 0;

        public int Score
        {
            get
            {
                return this.score;
            }
            set
            {
                this.score = value;
            }
        }

        public int Combo
        {
            get
            {
                return this.combo;
            }
            set
            {
                this.combo = value;
                if (this.combo > this.maxCombo)
                {
                    this.maxCombo = this.combo;
                }
            }
        }

        public int MaxCombo
        {
            get
            {
                return this.maxCombo;
            }
        }

        public int Miss
        {
            get
            {
                return this.miss;
            }
            set
            {
                this.miss = value;
            }
        }

        public int Bad
        {
            get
            {
                return this.bad;
            }
            set
            {
                this.bad = value;
            }
        }

        public int Good
        {
            get
            {
                return this.good;
            }
            set
            {
                this.good = value;
            }
        }

        public int Perfect
        {
            get
            {
                return this.perfect;
            }
            set
            {
                this.perfect = value;
            }
        }

        private ScoreBoard()
        {
            Reset();
        }

        public static ScoreBoard GetInstance()
        {
            if(instance == null)
            {
                instance = new ScoreBoard();
            }
            return instance;
        }

        public void Reset()
        {
            this.score = this.combo = this.miss = this.good = this.perfect = this.bad = this.maxCombo = 0;
        }

        public void HitBad()
        {
            this.bad++;
            this.Combo = this.Combo + 1;
            if(this.Combo <= 20)
            {
                this.score += 20;
            }
            else if(this.combo <= 50)
            {
                this.score += 30;
            }
            else
            {
                this.score += 40;
            } 
        }

        public void HitGood()
        {
            this.good++;
            this.Combo = this.Combo + 1;
            if (this.Combo <= 20)
            {
                this.score += 30;
            }
            else if (this.combo <= 50)
            {
                this.score += 45;
            }
            else
            {
                this.score += 60;
            }
        }

        public void HitPerfect()
        {
            this.perfect++;
            this.Combo = this.Combo + 1;
            if (this.Combo <= 20)
            {
                this.score += 40;
            }
            else if (this.combo <= 50)
            {
                this.score += 60;
            }
            else
            {
                this.score += 80;
            }
        }

        public void HitMiss()
        {
            this.miss++;
            this.Combo = 0;
        }
    }
}

