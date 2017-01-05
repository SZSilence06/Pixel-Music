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
    }
}
