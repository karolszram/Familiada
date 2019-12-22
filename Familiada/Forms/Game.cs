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
            ControlPanel.Instance.StartBtn.Enabled = true;
            GameController.Instance.CurrentQuestionNode = null;
            ControlPanel.Instance.Btn1.Visible = false;
            ControlPanel.Instance.Btn2.Visible = false;
            ControlPanel.Instance.Btn3.Visible = false;
            ControlPanel.Instance.Btn4.Visible = false;
            ControlPanel.Instance.Btn5.Visible = false;
            ControlPanel.Instance.Btn6.Visible = false;
            ControlPanel.Instance.WrongBtn1.Visible = false;
            ControlPanel.Instance.WrongBtn2.Visible = false;
            ControlPanel.Instance.WrongBtn3.Visible = false;
            ControlPanel.Instance.WrongBtn4.Visible = false;
            ControlPanel.Instance.WrongBtn5.Visible = false;
            ControlPanel.Instance.WrongBtn6.Visible = false;
            ControlPanel.Instance.PointsLeft.Visible = false;
            ControlPanel.Instance.PointsRight.Visible = false;
            ControlPanel.Instance.PointsToLeft.Visible = false;
            ControlPanel.Instance.PointsToRight.Visible = false;
        }
        public void ClearBeforeNext()
        {
            
            GameController.Instance.PointsBeforeAdd = 0;
            ControlPanel.Instance.Btn1.Visible = false;
            ControlPanel.Instance.Btn2.Visible = false;
            ControlPanel.Instance.Btn3.Visible = false;
            ControlPanel.Instance.Btn4.Visible = false;
            ControlPanel.Instance.Btn5.Visible = false;
            ControlPanel.Instance.Btn6.Visible = false;

            ControlPanel.Instance.WrongBtn1.Visible = true;
            ControlPanel.Instance.WrongBtn1.ForeColor = Color.Black;
            ControlPanel.Instance.WrongBtn2.Visible = true;
            ControlPanel.Instance.WrongBtn2.ForeColor = Color.Black;
            ControlPanel.Instance.WrongBtn3.Visible = true;
            ControlPanel.Instance.WrongBtn3.ForeColor = Color.Black;
            ControlPanel.Instance.WrongBtn4.Visible = true;
            ControlPanel.Instance.WrongBtn4.ForeColor = Color.Black;
            ControlPanel.Instance.WrongBtn5.Visible = true;
            ControlPanel.Instance.WrongBtn5.ForeColor = Color.Black;
            ControlPanel.Instance.WrongBtn6.Visible = true;
            ControlPanel.Instance.WrongBtn6.ForeColor = Color.Black;
            Wrong1.Visible = false;
            Wrong2.Visible = false;
            Wrong3.Visible = false;
            Wrong4.Visible = false;
            Wrong5.Visible = false;
            Wrong6.Visible = false;
            Answer1.Visible = false;
            Answer2.Visible = false;
            Answer3.Visible = false;
            Answer4.Visible = false;
            Answer5.Visible = false;
            Answer6.Visible = false;
            Pkt1.Visible = false;
            Pkt2.Visible = false;
            Pkt3.Visible = false;
            Pkt4.Visible = false;       
            Pkt5.Visible = false;
            Pkt6.Visible = false;
            Answer1.Text = "1. ...................................................................";
            Answer2.Text = "2. ...................................................................";
            Answer3.Text = "3. ...................................................................";
            Answer4.Text = "4. ...................................................................";
            Answer5.Text = "5. ...................................................................";
            Answer6.Text = "6. ...................................................................";
            Pkt1.Text = "--";
            Pkt2.Text = "--";
            Pkt3.Text = "--";
            Pkt4.Text = "--";
            Pkt5.Text = "--";
            Pkt6.Text = "--";
        }

        private void Game_Load(object sender, EventArgs e)
        {
            GameController.Instance.PointsLeft = 0;
            GameController.Instance.PointsRight = 0;
            GameController.Instance.PointsBeforeAdd= 0;

            ControlPanel.Instance.PointsLeft.Text = "0";
            ControlPanel.Instance.PointsRight.Text = "0";
            ControlPanel.Instance.PointsLeft.Visible = true;
            ControlPanel.Instance.PointsRight.Visible = true;

            ControlPanel.Instance.PointsToLeft.Visible = true;
            ControlPanel.Instance.PointsToRight.Visible = true;

            ControlPanel.Instance.StartBtn.Enabled = false;

            ClearBeforeNext();

        }



    }
}
