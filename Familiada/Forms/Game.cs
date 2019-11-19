using Familiada.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Familiada.Forms
{
    public partial class Game : DevExpress.XtraEditors.XtraForm
    {

        private static Game instance;

        public static Game Instance
        {
            get
            {
                if (instance != null) return instance;
                instance = new Game();
                return instance;
            }
        }

        public Game()
        {
            InitializeComponent();
        }

        private void Game_FormClosing(object sender, FormClosingEventArgs e)
        {
            instance = null;
            GameController.Instance.FlagGameStarted = false;
        }
    }
}
