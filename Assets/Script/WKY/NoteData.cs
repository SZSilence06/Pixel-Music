using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MusicGame
{
    public class NoteData
    {
        public enum NoteType
        {
            SIMPLE,
            HOLD
        }

        private NoteType type;

        public NoteType Type
        {
            get
            {
                return this.type;
            }
            set
            {
                this.type = value;
            }
        }

        private int occurFrame = 0;

        public int OccurFrame
        {
            get
            {
                return this.occurFrame;
            }
            set
            {
                this.occurFrame = value;
            }
        }

        private int lastTime = 0;

        public int LastTime
        {
            get
            {
                return this.lastTime;
            }
            set
            {
                if (this.type == NoteType.SIMPLE)
                {
                    this.lastTime = 0;
                }
                else
                {
                    this.lastTime = value - 8;
                }
            }
        }

        private int channel;

        public int Channel
        {
            get
            {
                return this.channel;
            }
            set
            {
                this.channel = value;
            }
        }
    }
}
