using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace MusicGame
{
    class Stage01 : Stage
    {
        const float FRAME_PER_BEAT = 3000f / 94f;

        public Stage01()
        {
            base.BackgroundImage = Resources.Load("image/SongImage/song_image01") as Texture2D;
            base.music = Resources.Load("audio/QLOCKS - 篝火蛍-inst.ver- - instrumental") as AudioClip;
            base.Title = "Song01";
            base.Author = "QLOCKS";

            CreatePattern01((int)(FRAME_PER_BEAT * 1));
            CreatePattern111((int)(FRAME_PER_BEAT * 16));
            CreateDrum01((int)(FRAME_PER_BEAT * 29));
            CreatePattern02((int)(FRAME_PER_BEAT * 33));
            CreateDrum02((int)(FRAME_PER_BEAT * 33));
            CreatePattern03((int)(FRAME_PER_BEAT * 65));
            CreatePattern04((int)(FRAME_PER_BEAT * 81));
            CreateDrum04((int)(FRAME_PER_BEAT * 81));
            CreatePattern05((int)(FRAME_PER_BEAT * 135));
            CreatePattern01((int)(FRAME_PER_BEAT * 167));
            CreatePattern111A((int)(FRAME_PER_BEAT * 182));
        }

        void CreatePattern01(int startFrame)
        {
            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame,
                Channel = 4,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 1)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 1),
                Channel = 3,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 1.25),
                Channel = 4,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 1.5),
                Channel = 1,
                Type = NoteData.NoteType.SIMPLE,
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 2.0),
                Channel = 4,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 2.5),
                Channel = 3,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 2.75),
                Channel = 4,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 3),
                Channel = 5,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 3.5),
                Channel = 4,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 4),
                Channel = 3,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 1)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 5),
                Channel = 0,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 5.25),
                Channel = 1,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 5.5),
                Channel = 2,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 5.75),
                Channel = 5,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 6),
                Channel = 3,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 1)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 7),
                Channel = 3,
                Type = NoteData.NoteType.SIMPLE,
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 7.5),
                Channel = 4,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 8),
                Channel = 5,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 1.5)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 9.5),
                Channel = 3,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 9.75),
                Channel = 5,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 10),
                Channel = 3,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 10.5),
                Channel = 2,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 11),
                Channel = 1,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 11.5),
                Channel = 0,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 12),
                Channel = 3,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 1)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 13),
                Channel = 1,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 13.5),
                Channel = 2,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 14),
                Channel = 4,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 1)
            });
        }

        void CreatePattern111(int startFrame)
        {
            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame,
                Channel = 3,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 1)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 1),
                Channel = 4,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 1)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 2),
                Channel = 3,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 2.25),
                Channel = 4,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 2.5),
                Channel = 1,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 3.0),
                Channel = 4,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 3.5),
                Channel = 3,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 3.75),
                Channel = 4,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 4),
                Channel = 5,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 4.5),
                Channel = 2,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 5),
                Channel = 3,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 5.5),
                Channel = 5,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 5.75),
                Channel = 3,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 0.75)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 6.5),
                Channel = 2,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 7),
                Channel = 2,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 1)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 8),
                Channel = 1,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 8.25),
                Channel = 2,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 8.5),
                Channel = 1,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 8.75),
                Channel = 0,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 9),
                Channel = 1,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 1.5)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 10.5),
                Channel = 0,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 10.75),
                Channel = 1,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 11),
                Channel = 2,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 1)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 12),
                Channel = 0,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 0.5)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 12.5),
                Channel = 2,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 0.5)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 13),
                Channel = 4,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 0.5)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 13.5),
                Channel = 5,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 13.75),
                Channel = 4,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 0.75)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 14.5),
                Channel = 2,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 0.5)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 15),
                Channel = 3,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 2)
            });
        }
        
        void CreateDrum01(int startFrame)
        {
            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame,
                Channel = 0,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 0.5),
                Channel = 0,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 1.25),
                Channel = 1,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 1.75),
                Channel = 1,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 2.25),
                Channel = 0,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 2.5),
                Channel = 0,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 3.5),
                Channel = 1,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 3.75),
                Channel = 1,
                Type = NoteData.NoteType.SIMPLE
            });
        }

        void CreatePattern02(int startFrame)
        {
            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame,
                Channel = 2,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 0.5)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 0.5),
                Channel = 1,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 0.75),
                Channel = 1,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 0.75)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT *1.5),
                Channel = 2,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 1.75),
                Channel = 0,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 1.25),
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 3),
                Channel = 1,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 0.5),
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 3.5),
                Channel = 0,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 3.75),
                Channel = 1,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 0.75)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 4.5),
                Channel = 0,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 4.75),
                Channel = 1,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 0.75)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 5.5),
                Channel = 2,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 5.75),
                Channel = 1,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 1.25)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 7),
                Channel = 1,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 0.5)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 7.5),
                Channel = 2,
                Type = NoteData.NoteType.SIMPLE,
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 7.75),
                Channel = 0,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 1.25)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 9),
                Channel = 1,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 0.5)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 9.5),
                Channel = 2,
                Type = NoteData.NoteType.SIMPLE,
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 9.75),
                Channel = 0,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 1.25)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 11),
                Channel = 1,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 0.5)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 11.5),
                Channel = 0,
                Type = NoteData.NoteType.SIMPLE,
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 11.75),
                Channel = 1,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 1.25)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 13),
                Channel = 2,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 1)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 14),
                Channel = 3,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 2)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 16),
                Channel = 5,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 0.5)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 16.5),
                Channel = 4,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 16.75),
                Channel = 4,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 0.75)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 17.5),
                Channel = 5,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 17.75),
                Channel = 4,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 1.25),
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 19),
                Channel = 3,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 0.5),
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 19.5),
                Channel = 2,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 19.75),
                Channel = 3,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 1)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 20.75),
                Channel = 5,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 1)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 21.75),
                Channel = 4,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 1.25)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT *23),
                Channel = 3,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 0.5)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 23.5),
                Channel = 5,
                Type = NoteData.NoteType.SIMPLE,
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 23.75),
                Channel = 2,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 1.25)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 25),
                Channel = 3,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 0.5)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 25.5),
                Channel = 4,
                Type = NoteData.NoteType.SIMPLE,
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 25.75),
                Channel = 5,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 1.25)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 27),
                Channel = 2,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 0.5)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 27.5),
                Channel = 3,
                Type = NoteData.NoteType.SIMPLE,
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 27.75),
                Channel = 5,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 0.5)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 28.25),
                Channel = 4,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 0.5)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 28.75),
                Channel = 3,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 0.5)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 29.25),
                Channel = 2,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 29.5),
                Channel = 3,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 2.5)
            });
        }

        void CreateDrum02(int startFrame)
        {
            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame,
                Channel = 5,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 1),
                Channel = 4,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 2),
                Channel = 5,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 3),
                Channel = 4,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 4),
                Channel = 5,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 5),
                Channel = 4,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 6),
                Channel = 5,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 7),
                Channel = 4,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 7.5),
                Channel = 4,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 8),
                Channel = 5,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 9),
                Channel = 4,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 10),
                Channel = 5,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 11),
                Channel = 4,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 12),
                Channel = 5,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 13),
                Channel = 4,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 14),
                Channel = 5,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 15),
                Channel = 4,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 16),
                Channel = 0,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 17),
                Channel = 1,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 18),
                Channel = 0,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 19),
                Channel = 1,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 20),
                Channel = 0,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 21),
                Channel = 1,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 22),
                Channel = 0,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 23),
                Channel = 1,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 23.5),
                Channel = 1,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 24),
                Channel = 0,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 25),
                Channel = 1,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 26),
                Channel = 0,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 27),
                Channel = 1,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 28),
                Channel = 0,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 29),
                Channel = 1,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 30),
                Channel = 0,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 31),
                Channel = 0,
                Type = NoteData.NoteType.SIMPLE
            });
        }

        void CreatePattern03(int startFrame)
        {
            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame,
                Channel = 3,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 0.5),
                Channel = 2,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 0.75),
                Channel = 3,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 1),
                Channel = 1,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 1.5),
                Channel = 3,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 2),
                Channel = 2,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 2.25),
                Channel = 3,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 2.5),
                Channel = 4,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 1)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 3.5),
                Channel = 3,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 3.75),
                Channel = 4,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 4),
                Channel = 3,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 1)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 5),
                Channel = 2,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 0.5)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 5.5),
                Channel = 0,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 5.75),
                Channel = 1,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 6),
                Channel = 3,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 1)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 7),
                Channel = 2,
                Type = NoteData.NoteType.SIMPLE,
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 7.25),
                Channel = 3,
                Type = NoteData.NoteType.SIMPLE,
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 7.5),
                Channel = 0,
                Type = NoteData.NoteType.SIMPLE,
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 8),
                Channel = 3,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 8.5),
                Channel = 2,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 8.75),
                Channel = 3,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 9),
                Channel = 1,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 9.5),
                Channel = 3,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 10),
                Channel = 2,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 10.25),
                Channel = 3,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 10.5),
                Channel = 4,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 1)
            });


            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 11.5),
                Channel = 4,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 11.75),
                Channel = 5,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 12),
                Channel = 4,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 0.5)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 12.5),
                Channel = 3,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 12.75),
                Channel = 3,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 3.25)
            });
        }

        void CreatePattern04(int startFrame)
        {
            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame,
                Channel = 2,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 1.5)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 1.5),
                Channel = 1,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 2),
                Channel = 1,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 1)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 3),
                Channel = 4,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 3.5),
                Channel = 0,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 3.75),
                Channel = 0,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 3.25)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 7),
                Channel = 2,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 7.5),
                Channel = 3,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 8),
                Channel = 4,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 1.5)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 9.5),
                Channel = 3,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 9.75),
                Channel = 4,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 10),
                Channel = 3,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 1)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 11),
                Channel = 2,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 0.5)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 11.5),
                Channel = 4,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 11.75),
                Channel = 4,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 3.75)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 15.5),
                Channel = 2,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 15.75),
                Channel = 3,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 16),
                Channel = 4,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 1.5)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 17.5),
                Channel = 2,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 18),
                Channel = 2,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 1)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 19),
                Channel = 4,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 1)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 20),
                Channel = 5,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 3.5)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 23.5),
                Channel = 3,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 23.75),
                Channel = 4,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 24),
                Channel = 2,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 1.5)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 25.5),
                Channel = 3,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 25.75),
                Channel = 4,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 26),
                Channel = 2,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 0.75)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 26.75),
                Channel = 1,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 0.75)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 27.5),
                Channel = 2,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 27.75),
                Channel = 1,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 4.25)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 32),
                Channel = 2,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 1)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 33),
                Channel = 1,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 33.5),
                Channel = 2,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 33.75),
                Channel = 0,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 34.5),
                Channel = 1,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 35),
                Channel = 1,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 35.5),
                Channel = 2,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 35.75),
                Channel = 2,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 0.75)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 36.5),
                Channel = 1,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 0.5)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 37),
                Channel = 2,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 1)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 38),
                Channel = 3,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 1)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 39),
                Channel = 2,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 0.5)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 39.5),
                Channel = 1,
                Type = NoteData.NoteType.SIMPLE,
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 39.75),
                Channel = 3,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 1.25)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 41),
                Channel = 2,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 0.5)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 41.5),
                Channel = 3,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 41.75),
                Channel = 4,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 1.25)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 43),
                Channel = 2,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 0.5)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 43.5),
                Channel = 4,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 43.75),
                Channel = 5,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 4.25)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 48),
                Channel = 4,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 6)
            });
        }

        void CreateDrum04(int startFrame)
        {
            for(int i = 0; i < 8; i++)
            {
                this.Notes.AddLast(new NoteData
                {
                    OccurFrame = startFrame + (int)(FRAME_PER_BEAT * i),
                    Channel = 5,
                    Type = NoteData.NoteType.SIMPLE
                });
            }

            for (int i = 8; i < 16; i++)
            {
                this.Notes.AddLast(new NoteData
                {
                    OccurFrame = startFrame + (int)(FRAME_PER_BEAT * i),
                    Channel = 0,
                    Type = NoteData.NoteType.SIMPLE
                });
            }

            for (int i = 16; i < 24; i++)
            {
                this.Notes.AddLast(new NoteData
                {
                    OccurFrame = startFrame + (int)(FRAME_PER_BEAT * i),
                    Channel = 1,
                    Type = NoteData.NoteType.SIMPLE
                });
            }

            for (int i = 24; i < 32; i++)
            {
                this.Notes.AddLast(new NoteData
                {
                    OccurFrame = startFrame + (int)(FRAME_PER_BEAT * i),
                    Channel = 3,
                    Type = NoteData.NoteType.SIMPLE
                });
            }

            for(int i = 32; i < 40; i++)
            {
                this.Notes.AddLast(new NoteData
                {
                    OccurFrame = startFrame + (int)(FRAME_PER_BEAT * i),
                    Channel = i%2 == 1? 1:4,
                    Type = NoteData.NoteType.SIMPLE
                });
            }

            for (int i = 40; i < 50; i++)
            {
                this.Notes.AddLast(new NoteData
                {
                    OccurFrame = startFrame + (int)(FRAME_PER_BEAT * i),
                    Channel = i % 2 == 1 ? 0 : 1,
                    Type = NoteData.NoteType.SIMPLE
                });
            }

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 50),
                Channel = 0,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 50.5),
                Channel = 2,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 50.75),
                Channel = 2,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 51),
                Channel = 0,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 52),
                Channel = 2,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 52.5),
                Channel = 2,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 52.75),
                Channel = 0,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 53),
                Channel = 2,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 53.5),
                Channel = 2,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 53.75),
                Channel = 2,
                Type = NoteData.NoteType.SIMPLE
            });
        }

        void CreatePattern05(int startFrame)
        {
            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame,
                Channel = 2,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 0.5)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame,
                Channel = 5,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 0.5)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 0.5),
                Channel = 1,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 0.5),
                Channel = 4,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 0.75),
                Channel = 1,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 0.75)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 0.75),
                Channel = 4,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 0.75)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 1.5),
                Channel = 2,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 1.5),
                Channel = 5,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 1.75),
                Channel = 0,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 1.25)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 1.75),
                Channel = 3,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 1.25)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 3),
                Channel = 1,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 0.5)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 3),
                Channel = 4,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 0.5)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 3.5),
                Channel = 0,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 3.5),
                Channel = 3,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 3.75),
                Channel = 1,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 0.75)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 3.75),
                Channel = 4,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 0.75)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 4.5),
                Channel = 0,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 4.5),
                Channel = 3,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 4.75),
                Channel = 1,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 0.75)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 4.75),
                Channel = 4,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 0.75)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 5.5),
                Channel = 2,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 5.5),
                Channel = 5,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 5.75),
                Channel = 1,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 1.25)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 5.75),
                Channel = 4,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 1.25)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 7),
                Channel = 1,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 0.5)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 7),
                Channel = 4,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 0.5)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 7.5),
                Channel = 2,
                Type = NoteData.NoteType.SIMPLE,
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 7.5),
                Channel = 5,
                Type = NoteData.NoteType.SIMPLE,
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 7.75),
                Channel = 0,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 1.25)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 7.75),
                Channel = 3,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 1.25)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 9),
                Channel = 1,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 0.5)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 9),
                Channel = 4,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 0.5)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 9.5),
                Channel = 2,
                Type = NoteData.NoteType.SIMPLE,
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 9.5),
                Channel = 5,
                Type = NoteData.NoteType.SIMPLE,
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 9.75),
                Channel = 0,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 1.25)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 9.75),
                Channel = 3,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 1.25)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 11),
                Channel = 1,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 0.5)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 11),
                Channel = 4,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 0.5)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 11.5),
                Channel = 0,
                Type = NoteData.NoteType.SIMPLE,
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 11.5),
                Channel = 3,
                Type = NoteData.NoteType.SIMPLE,
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 11.75),
                Channel = 1,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 1.25)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 11.75),
                Channel = 4,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 1.25)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 13),
                Channel = 2,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 1)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 13),
                Channel = 5,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 1)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 14),
                Channel = 3,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 2)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 14),
                Channel = 5,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 2)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 16),
                Channel = 5,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 0.5)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 16),
                Channel = 2,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 0.5)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 16.5),
                Channel = 4,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 16.5),
                Channel = 1,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 16.75),
                Channel = 4,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 0.75)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 16.75),
                Channel = 1,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 0.75)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 17.5),
                Channel = 5,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 17.5),
                Channel = 2,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 17.75),
                Channel = 4,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 1.25),
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 17.75),
                Channel = 1,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 1.25),
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 19),
                Channel = 3,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 0.5),
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 19),
                Channel = 0,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 0.5),
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 19.5),
                Channel = 2,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 19.5),
                Channel = 0,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 19.75),
                Channel = 3,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 1)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 19.75),
                Channel = 1,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 1)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 20.75),
                Channel = 5,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 1)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 20.75),
                Channel = 3,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 1)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 21.75),
                Channel = 4,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 1.25)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 21.75),
                Channel = 2,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 1.25)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 23),
                Channel = 3,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 0.5)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 23),
                Channel = 1,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 0.5)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 23.5),
                Channel = 5,
                Type = NoteData.NoteType.SIMPLE,
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 23.5),
                Channel = 3,
                Type = NoteData.NoteType.SIMPLE,
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 23.75),
                Channel = 2,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 1.25)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 23.75),
                Channel = 0,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 1.25)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 25),
                Channel = 3,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 0.5)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 25),
                Channel = 1,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 0.5)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 25.5),
                Channel = 4,
                Type = NoteData.NoteType.SIMPLE,
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 25.5),
                Channel = 2,
                Type = NoteData.NoteType.SIMPLE,
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 25.75),
                Channel = 5,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 1.25)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 25.75),
                Channel = 3,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 1.25)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 27),
                Channel = 2,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 0.5)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 27),
                Channel = 0,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 0.5)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 27.5),
                Channel = 3,
                Type = NoteData.NoteType.SIMPLE,
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 27.5),
                Channel = 1,
                Type = NoteData.NoteType.SIMPLE,
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 27.75),
                Channel = 5,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 0.5)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 27.75),
                Channel = 3,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 0.5)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 28.25),
                Channel = 4,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 0.5)
            });


            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 28.25),
                Channel = 2,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 0.5)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 28.75),
                Channel = 3,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 0.5)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 28.75),
                Channel = 1,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 0.5)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 29.25),
                Channel = 2,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 29.25),
                Channel = 0,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 29.5),
                Channel = 3,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 2.5)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 29.5),
                Channel = 1,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 2.5)
            });
        }

        void CreatePattern01A(int startFrame)
        {
            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame,
                Channel = 4,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 1)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 1),
                Channel = 3,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 1.25),
                Channel = 4,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 1.5),
                Channel = 1,
                Type = NoteData.NoteType.SIMPLE,
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 2.0),
                Channel = 4,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 2.5),
                Channel = 3,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 2.75),
                Channel = 4,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 3),
                Channel = 5,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 3.5),
                Channel = 4,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 4),
                Channel = 3,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 1)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 5),
                Channel = 0,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 5.25),
                Channel = 1,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 5.5),
                Channel = 2,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 5.75),
                Channel = 5,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 6),
                Channel = 3,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 1)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 7),
                Channel = 3,
                Type = NoteData.NoteType.SIMPLE,
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 7.5),
                Channel = 4,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 8),
                Channel = 5,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 1.5)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 9.5),
                Channel = 3,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 9.75),
                Channel = 5,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 10),
                Channel = 3,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 10.5),
                Channel = 2,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 11),
                Channel = 1,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 11.5),
                Channel = 0,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 12),
                Channel = 3,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 1)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 13),
                Channel = 1,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 13.5),
                Channel = 2,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 14),
                Channel = 4,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 2)
            });
        }

        void CreatePattern111A(int startFrame)
        {
            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame,
                Channel = 3,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 1)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 1),
                Channel = 4,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 1)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 2),
                Channel = 3,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 2.25),
                Channel = 4,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 2.5),
                Channel = 1,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 3.0),
                Channel = 4,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 3.5),
                Channel = 3,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 3.75),
                Channel = 4,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 4),
                Channel = 5,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 4.5),
                Channel = 2,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 5),
                Channel = 3,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 5.5),
                Channel = 5,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 5.75),
                Channel = 3,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 0.75)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 6.5),
                Channel = 2,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 7),
                Channel = 2,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 1)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 8),
                Channel = 1,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 8.25),
                Channel = 2,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 8.5),
                Channel = 1,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 8.75),
                Channel = 0,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 9),
                Channel = 1,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 1.5)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 10.5),
                Channel = 0,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 10.75),
                Channel = 1,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 11),
                Channel = 2,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 1)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 12),
                Channel = 0,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 0.5)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 12.5),
                Channel = 2,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 0.5)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 13),
                Channel = 4,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 0.5)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 13.5),
                Channel = 5,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 13.75),
                Channel = 4,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 0.75)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 14.5),
                Channel = 2,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 0.5)
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = startFrame + (int)(FRAME_PER_BEAT * 15),
                Channel = 3,
                Type = NoteData.NoteType.HOLD,
                LastTime = (int)(FRAME_PER_BEAT * 4)
            });
        }
    }
}
