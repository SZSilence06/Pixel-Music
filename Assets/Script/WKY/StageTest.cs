using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace MusicGame
{
    class StageTest : Stage
    {
        public StageTest()
        {
            base.BackgroundImage = Resources.Load("image/SongImage/song_image01") as Texture2D;
            base.music = Resources.Load("audio/卡农钢琴曲（Variations on the Canon）") as AudioClip;

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = 45,
                Channel = 5,
                Type = NoteData.NoteType.HOLD,
                LastTime = 110,  
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = 160,
                Channel = 3,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = 230,
                Channel = 3,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = 290,
                Channel = 2,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = 405,
                Channel = 4,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = 470,
                Channel = 4,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = 495,
                Channel = 5,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = 525,
                Channel = 4,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = 555,
                Channel = 3,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = 585,
                Channel = 2,
                Type = NoteData.NoteType.SIMPLE
            });

            this.Notes.AddLast(new NoteData
            {
                OccurFrame = 615,
                Channel = 4,
                Type = NoteData.NoteType.SIMPLE
            });
        }
    }
}
