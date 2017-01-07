using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MusicGame
{
    class StageData
    {
        private Stage stage = null;

        public Stage CurrentStage
        {
            get
            {
                return stage;
            }
            set
            {
                this.stage = value;
            }
        }

        private static StageData instance = null;

        private StageData()
        {
            this.stage = new StageTest();
        }

        public static StageData GetInstance()
        {
            if(instance == null)
            {
                instance = new StageData();
            }
            return instance;
        }

        public string Title
        {
            get
            {
                if(stage != null)
                {
                    return stage.Title;
                }
                return null;
            }
        }

        public string Author
        {
            get
            {
                if(stage != null)
                {
                    return stage.Author;
                }
                return null;
            }
        }

        private bool muted = false;

        public bool Muted
        {
            get
            {
                return this.muted;
            }
            set
            {
                this.muted = value;
            }
        }

        public int MaxScore
        {
            get
            {
                if(stage == null)
                {
                    return 0;
                }
                int noteNum = 0;
                var notes = stage.Notes;
                foreach(NoteData note in notes)
                {
                    if(note.Type == NoteData.NoteType.SIMPLE)
                    {
                        noteNum++;
                    }
                    else if(note.Type == NoteData.NoteType.HOLD)
                    {
                        noteNum += note.LastTime;
                    }
                }
                if(noteNum <= 20)
                {
                    return 40 * noteNum;
                }
                else if (noteNum <= 50)
                {
                    return 40 * 20 + 60 * (noteNum - 20);
                }
                else
                {
                    return 40 * 20 + 60 * 30 + 80 * (noteNum - 50);
                }
            }
        }
    }
}
