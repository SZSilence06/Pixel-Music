using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace MusicGame
{
    class Stage
    {
        private Texture2D backgroundImage = null;

        protected AudioClip music = null;

        private LinkedList<NoteData> notes = new LinkedList<NoteData>();

        public Texture2D BackgroundImage
        {
            get
            {
                return backgroundImage;
            }
            set
            {
                backgroundImage = value;
            }
        }

        public AudioClip Music
        {
            get
            {
                return this.music;
            }
        }

        public LinkedList<NoteData> Notes
        {
            get
            {
                return this.notes;
            }
        }
    }
}
