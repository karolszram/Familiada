using Familiada.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Familiada.Classes
{
    public class GameController
    {
        private static GameController instance;

        public static GameController Instance
        {
            get
            {
                if (instance != null) return instance;
                instance = new GameController();
                return instance;
            }
        }

        public bool FlagGameStarted = true;

        public Question CurrentQuestion = new Question();

        public void GameStart()
        {
            Game.Instance.Show();
            this.FlagGameStarted = true;

        }
    }
}
