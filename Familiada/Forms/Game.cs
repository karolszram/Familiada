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
    public partial class Game : Form
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


        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }


        private void Game_FormClosing(object sender, FormClosingEventArgs e)
        {
            instance = null;
            ControlPanel.Instance.StartBtn.Text = "Start";
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
            ControlPanel.Instance.CloseBtn.Visible = false;
            ControlPanel.Instance.FullScreenBtn.Visible = false;
            ControlPanel.Instance.CurrentPointsLbl.Visible = false;
        }
        public void ClearBeforeNext()
        {
            TeamAlbl.Text = ControlPanel.Instance.textEdit1.Text;
            TeamBLbl.Text = ControlPanel.Instance.textEdit2.Text;
            pictureBox1.Dock = DockStyle.Fill;
            if (ControlPanel.Instance.PictureBox.Checked) pictureBox1.Visible = true;
            else pictureBox1.Visible = false;
            ControlPanel.Instance.CurrentPointsLbl.Visible = true ;
            GameController.Instance.PointsBeforeAdd = 0;
            ControlPanel.Instance.Btn1.Visible = false;
            ControlPanel.Instance.Btn2.Visible = false;
            ControlPanel.Instance.Btn3.Visible = false;
            ControlPanel.Instance.Btn4.Visible = false;
            ControlPanel.Instance.Btn5.Visible = false;
            ControlPanel.Instance.Btn6.Visible = false;
            ControlPanel.Instance.Btn1.Enabled= true;
            ControlPanel.Instance.Btn2.Enabled= true;
            ControlPanel.Instance.Btn3.Enabled= true;
            ControlPanel.Instance.Btn4.Enabled= true;
            ControlPanel.Instance.Btn5.Enabled= true;
            ControlPanel.Instance.Btn6.Enabled= true;
            ControlPanel.Instance.CloseBtn.Visible = true;
            ControlPanel.Instance.FullScreenBtn.Visible = true;


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
            Answer1.Text = "1 ________________";
            Answer2.Text = "2 ________________";
            Answer3.Text = "3 ________________";
            Answer4.Text = "4 ________________";
            Answer5.Text = "5 ________________";
            Answer6.Text = "6 ________________";
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
            ControlPanel.Instance.textEdit1.Visible = true;
            ControlPanel.Instance.textEdit2.Visible = true;


            ClearBeforeNext();

        }

        private bool change_flag = false;
        private void Answer6_TextChanged(object sender, EventArgs e)
        {
            if(change_flag)
            {
                change_flag = false;
                return;
            }
            var label = sender as Label;
            string Text =label.Text;
            if (label.Text.Length > 19) 
            Text = label.Text.Remove(19, label.Text.Length-19);
            Text = Text.Replace(" ", "   ");
            if (Text != label.Text) change_flag = true;
            label.Text = Text;
            
        }

        private void CurrentPointsLBL_TextChanged(object sender, EventArgs e)
        {
            if (change_flag )
            {
                change_flag = false;
                return;
            }
            if(int.TryParse(CurrentPointsLBL.Text,out int x))
            {
                change_flag = true;
                if (x < 10)
                {
                    CurrentPointsLBL.Text = "00" + CurrentPointsLBL.Text;
                    return;
                }
                if (x < 100)
                {
                    CurrentPointsLBL.Text = "0" + CurrentPointsLBL.Text;
                    return;
                }
                change_flag = false;
            }   

            
        }

        private void Pkt6_TextChanged(object sender, EventArgs e)
        {
            if (change_flag)
            {
                change_flag = false;
                return;
            }
            var label = sender as Label;
            if (int.TryParse(label.Text, out int x))
            {
                if (x > 10) return;

                string Text = 0 + label.Text;

                if (Text != label.Text) change_flag = true;
                label.Text = Text;
            }
        }
    }
}
