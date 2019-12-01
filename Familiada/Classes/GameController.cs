using DevExpress.XtraTreeList.Nodes;
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

        protected void UpdateCurrentLabel()
        {
            try
            {
                if (_currentQuestionNode == null)
                {
                    ControlPanel.Instance.CurrentQuestionLbl.Text = "-";
                    Game.Instance.CurrentGameQuestionLbl.Text = "-";
                }
                ControlPanel.Instance.CurrentQuestionLbl.Text = CurrentQuestionNode.GetDisplayText(0);
                Game.Instance.CurrentGameQuestionLbl.Text = CurrentQuestionNode.GetDisplayText(0);

            }
            catch{}
        }
        public TreeListNode NextQUestionNode { get; set; }

        public TreeListNode _currentQuestionNode;
        public TreeListNode CurrentQuestionNode { get { return _currentQuestionNode; }
            set { _currentQuestionNode = value;
                    UpdateCurrentLabel();
            } }
        public int PointsBeforeAdd { get; set; } = 0;
        private int _pointsLeft;
        public int PointsLeft
        {

            get { return _pointsLeft; }
            set
            {
                _pointsLeft= value;
                ControlPanel.Instance.PointsLeft.Text = value.ToString();
                Game.Instance.LeftPoints.Text = value.ToString();
            }
        }
        private int _pointsRight;
        public int PointsRight
        {

            get { return _pointsRight; }
            set
            {
                _pointsRight = value;
                ControlPanel.Instance.PointsRight.Text = value.ToString();
                Game.Instance.RightPoints.Text = value.ToString();
            }
        }

        public void GameStart()
        {

            CurrentQuestionNode = NextQUestionNode;

            if (!NextQUestionNode.HasChildren)  return;


            Game.Instance.Show();
            CurrentQuestionNode = NextQUestionNode;


            ControlPanel.Instance.SelectRandomNextQuestion();

            for(int i=1; i<=CurrentQuestionNode.Nodes.Count(); i++ )
            {


                switch (i)
                {
                    case 1:
                        ControlPanel.Instance.Btn1.Click += new EventHandler(Btn1Click);
                        ControlPanel.Instance.Btn1.Visible = true;
                        
                        ControlPanel.Instance.Btn1.Tag = CurrentQuestionNode.Nodes[i - 1].GetDisplayText(1); ;
                        ControlPanel.Instance.Btn1.Text = CurrentQuestionNode.Nodes[i - 1].GetDisplayText(0);
                        Game.Instance.Answer1.Visible = true;
                        Game.Instance.Pkt1.Visible = true;

                        break;
                    case 2:
                        ControlPanel.Instance.Btn2.Click += new EventHandler(Btn2Click);
                        ControlPanel.Instance.Btn2.Visible = true;
                        
                        ControlPanel.Instance.Btn2.Tag = CurrentQuestionNode.Nodes[i - 1].GetDisplayText(1);
                        ControlPanel.Instance.Btn2.Text = CurrentQuestionNode.Nodes[i - 1].GetDisplayText(0);
                        Game.Instance.Answer2.Visible = true;
                        Game.Instance.Pkt2.Visible = true;
                        break;
                    case 3:
                        ControlPanel.Instance.Btn3.Click += new EventHandler(Btn3Click);
                        ControlPanel.Instance.Btn3.Visible = true;
                       
                        ControlPanel.Instance.Btn3.Tag = CurrentQuestionNode.Nodes[i - 1].GetDisplayText(1);
                        ControlPanel.Instance.Btn3.Text = CurrentQuestionNode.Nodes[i - 1].GetDisplayText(0);
                        Game.Instance.Answer3.Visible = true;
                        Game.Instance.Pkt3.Visible = true;
                        break;
                    case 4:
                        ControlPanel.Instance.Btn4.Click += new EventHandler(Btn4Click);
                        ControlPanel.Instance.Btn4.Visible = true;
                        
                        ControlPanel.Instance.Btn4.Tag = CurrentQuestionNode.Nodes[i - 1].GetDisplayText(1);
                        ControlPanel.Instance.Btn4.Text = CurrentQuestionNode.Nodes[i - 1].GetDisplayText(0);
                        Game.Instance.Answer4.Visible = true;
                        Game.Instance.Pkt4.Visible = true;
                        break;
                    case 5:
                        ControlPanel.Instance.Btn5.Click += new EventHandler(Btn5Click);
                        ControlPanel.Instance.Btn5.Visible = true;
                        ControlPanel.Instance.Btn5.Tag = CurrentQuestionNode.Nodes[i - 1].GetDisplayText(1);
                        ControlPanel.Instance.Btn5.Text = CurrentQuestionNode.Nodes[i - 1].GetDisplayText(0);
                        Game.Instance.Answer5.Visible = true;
                        Game.Instance.Pkt5.Visible = true;
                        break;
                    case 6:
                        ControlPanel.Instance.Btn6.Click += new EventHandler(Btn6Click);
                        ControlPanel.Instance.Btn6.Visible = true;
                        ControlPanel.Instance.Btn6.Tag = CurrentQuestionNode.Nodes[i - 1].GetDisplayText(1);
                        ControlPanel.Instance.Btn6.Text = CurrentQuestionNode.Nodes[i - 1].GetDisplayText(0);
                        Game.Instance.Answer1.Visible = true;
                        Game.Instance.Pkt1.Visible = true;
                        break;

                }
            }

        }



        void Btn1Click(object sender, EventArgs e)
        {

        }
        void Btn2Click(object sender, EventArgs e)
        {
        }
        void Btn3Click(object sender, EventArgs e)
        {
        }
        void Btn4Click(object sender, EventArgs e)
        {
        }
        void Btn5Click(object sender, EventArgs e)
        {
        }
        void Btn6Click(object sender, EventArgs e)
        {
        }

        public void SoundPlay(string name)
        {
            try
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                player.SoundLocation = name;
                player.Play();
            }
            catch
            {
                ControlPanel.Instance.ErrorLogLbl.Text = "Problem z odtworzeniem pliku dźwiękowego " + name;
            }
        }



    }
}
