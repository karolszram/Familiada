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
                    //Game.Instance.CurrentGameQuestionLbl.Text = "-";
                }
                ControlPanel.Instance.CurrentQuestionLbl.Text = CurrentQuestionNode.Tag +". "+ CurrentQuestionNode.GetDisplayText(0);
                //Game.Instance.CurrentGameQuestionLbl.Text = CurrentQuestionNode.GetDisplayText(0);

            }
            catch{}
        }
        public TreeListNode NextQUestionNode { get; set; }

        public TreeListNode _currentQuestionNode;
        public TreeListNode CurrentQuestionNode { get { return _currentQuestionNode; }
            set { _currentQuestionNode = value;
                    UpdateCurrentLabel();
            } }


        private int _pointsBeforeAdd;
        public int PointsBeforeAdd
        {

            get { return _pointsBeforeAdd; }
            set
            {
                _pointsBeforeAdd = value;
                ControlPanel.Instance.CurrentPointsLbl.Text = value.ToString();
                Game.Instance.CurrentPointsLBL.Text = value.ToString();
            }
        } 

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

            Game.Instance.ClearBeforeNext();
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
                        ControlPanel.Instance.Btn1.Visible = true;
                        
                        ControlPanel.Instance.Btn1.Tag = CurrentQuestionNode.Nodes[i - 1].GetDisplayText(1); ;
                        ControlPanel.Instance.Btn1.Text = CurrentQuestionNode.Nodes[i - 1].GetDisplayText(0);
                        Game.Instance.Answer1.Visible = true;
                        Game.Instance.Pkt1.Visible = true;

                        break;
                    case 2:
                        ControlPanel.Instance.Btn2.Visible = true;
                        
                        ControlPanel.Instance.Btn2.Tag = CurrentQuestionNode.Nodes[i - 1].GetDisplayText(1);
                        ControlPanel.Instance.Btn2.Text = CurrentQuestionNode.Nodes[i - 1].GetDisplayText(0);
                        Game.Instance.Answer2.Visible = true;
                        Game.Instance.Pkt2.Visible = true;
                        break;
                    case 3:
                        ControlPanel.Instance.Btn3.Visible = true;
                       
                        ControlPanel.Instance.Btn3.Tag = CurrentQuestionNode.Nodes[i - 1].GetDisplayText(1);
                        ControlPanel.Instance.Btn3.Text = CurrentQuestionNode.Nodes[i - 1].GetDisplayText(0);
                        Game.Instance.Answer3.Visible = true;
                        Game.Instance.Pkt3.Visible = true;
                        break;
                    case 4:
                        ControlPanel.Instance.Btn4.Visible = true;
                        
                        ControlPanel.Instance.Btn4.Tag = CurrentQuestionNode.Nodes[i - 1].GetDisplayText(1);
                        ControlPanel.Instance.Btn4.Text = CurrentQuestionNode.Nodes[i - 1].GetDisplayText(0);
                        Game.Instance.Answer4.Visible = true;
                        Game.Instance.Pkt4.Visible = true;
                        break;
                    case 5:
                        ControlPanel.Instance.Btn5.Visible = true;
                        ControlPanel.Instance.Btn5.Tag = CurrentQuestionNode.Nodes[i - 1].GetDisplayText(1);
                        ControlPanel.Instance.Btn5.Text = CurrentQuestionNode.Nodes[i - 1].GetDisplayText(0);
                        Game.Instance.Answer5.Visible = true;
                        Game.Instance.Pkt5.Visible = true;
                        break;
                    case 6:
                        ControlPanel.Instance.Btn6.Visible = true;
                        ControlPanel.Instance.Btn6.Tag = CurrentQuestionNode.Nodes[i - 1].GetDisplayText(1);
                        ControlPanel.Instance.Btn6.Text = CurrentQuestionNode.Nodes[i - 1].GetDisplayText(0);
                        Game.Instance.Answer6.Visible = true;
                        Game.Instance.Pkt6.Visible = true;
                        break;

                }
            }

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
