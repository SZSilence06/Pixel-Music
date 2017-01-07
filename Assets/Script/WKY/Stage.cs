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

        private string title;
        private string author;

        public string Title
        {
            get
            {
                return this.title;
            }
            set
            {
                this.title = value;
            }
        }

        public string Author
        {
            get
            {
                return this.author;
            }
            set
            {
                this.author = value;
            }
        }

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
