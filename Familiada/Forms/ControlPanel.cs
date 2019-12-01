using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Columns;
using DevExpress.XtraTreeList.Nodes;
using Familiada.Classes;
using Familiada.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Familiada
{
    public partial class ControlPanel : DevExpress.XtraEditors.XtraForm
    {
        private static ControlPanel _instance;

        public static ControlPanel Instance
        {
            get
            {
                if (_instance != null) return _instance;
                _instance = new ControlPanel();
                return _instance;
            }
        }

        private bool AddNodeflag = false;

        public ControlPanel()
        {
            InitializeComponent();

            try
            {
                treeList1.ImportFromXml("pytania.xml");
                //treeList1.BeginSort();
                //treeListColumn2.SortOrder = SortOrder.Descending;
                //treeList1.EndSort();
                //treeList1.Refresh();
            }
            catch
            {
                ErrorLogLbl.Text = "Problem z odczytaniem pliku pytania.xml";
            }
            SelectRandomNextQuestion();

        }
        public bool SelectRandomNextQuestion()
        {
            if (treeList1 == null) return false;
            if (treeList1.AllNodesCount == 0) return false;
            var NodesCount= this.treeList1.Nodes.Count();
            Random rnd = new Random();            
            var node = treeList1.Nodes[rnd.Next(NodesCount - 1)];
            treeList1.SetFocusedNode(node);
            GameController.Instance.NextQUestionNode = treeList1.FocusedNode;
            return true;
        }


        private void StartBtn_Click(object sender, EventArgs e)
        {
            GameController.Instance.GameStart();
        }



        private void treeList1_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            treeList1.ExportToXml("pytania.xml");
            //treeList1.BeginSort();
            //treeListColumn2.SortOrder = SortOrder.Descending;
            //treeList1.EndSort();
            //treeList1.Refresh();
            //treeList1.Update();


        }


        private void AddQuestion_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var addedNode = treeList1.AppendNode(new object[] { "Nowe Pytanie"},null);
            treeList1.SetFocusedNode(addedNode);
            treeList1.ShowEditor();
        }

        private void Delete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            treeList1.DeleteSelectedNodes();
        }

        private void AddAnswer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddNodeflag = true;
            var parrent = treeList1.Selection.SingleOrDefault().ParentNode;
            if (parrent != null)
            {
                treeList1.AppendNode(new object[] {"Nowa odpowiedź", "0" }, parrent);            
                return;
            }
            var parrentId = treeList1.Selection.SingleOrDefault().Id;
            treeList1.FindNodeByID(parrentId).Expand();
            var addedNode = treeList1.AppendNode(new object[] { "Nowa odpowiedź","0" }, parrentId);
            treeList1.SetFocusedNode(addedNode);
            treeList1.ShowEditor();
            AddNodeflag = false;
        }

        private void popupMenu1_CloseUp(object sender, EventArgs e)
        {
            try
            {
                treeList1.ExportToXml("pytania.xml");
            }
            catch
            {

            }
        }

        private void treeList1_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            if (e.Value == null) return;

            if (treeList1.FocusedColumn.Caption == "Pkt" )
            {
                if (treeList1.FocusedNode.HasChildren)
                {
                    e.Value = string.Empty; 
                    return;
                }
                var result = int.TryParse(e.Value.ToString(), out int output);
                if (!result)
                {
                    e.ErrorText = " Podaj liczbę z zakresu od 0 do 100";
                    e.Valid = false;

                }

                if (output < 0 || output > 100)
                {
                    e.ErrorText = " Podaj liczbę z zakresu od 0 do 100";
                    e.Valid = false;
                    return;
                }
                                                          
            }

            if (e.Value.ToString() == string.Empty)
            {
                e.ErrorText = "Pole nie może być puste";
                e.Valid = false;
            }


        }

        private void treeList1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                treeList1.FocusedNode.Remove();
            if (e.KeyCode == Keys.Right)
                treeList1.FocusedNode.Expand();
            if (e.KeyCode == Keys.Left)
                treeList1.FocusedNode.Collapse();
            if (e.KeyCode == Keys.Down)
            {
                if (treeList1.FocusedNode.NextNode == null) return;
                treeList1.SetFocusedNode(treeList1.FocusedNode.NextNode);

            }
        }

        private void treeList1_FocusedNodeChanged(object sender, FocusedNodeChangedEventArgs e)
        {
            if (AddNodeflag) return;
            if (treeList1.FocusedNode == null) return;
            if (!popupMenu1.Opened & treeList1.FocusedNode.HasChildren)
            {
                treeList1.CollapseAll();
                treeList1.FocusedNode.Expand();
            }
            if (e.Node.ParentNode != null)
            {
                NextQuestionLabel.Text = e.Node.ParentNode.GetDisplayText(0);
                GameController.Instance.NextQUestionNode = e.Node.ParentNode;
                return;
            }
            if(treeList1.FocusedNode.Nodes.Count == 0)
            {
                NextQuestionLabel.Text = "Pytanie bez odpowiedzi, wybierz inne";
                return;
            }
            NextQuestionLabel.Text =  e.Node.GetDisplayText(0);
            GameController.Instance.NextQUestionNode = e.Node;

        }


        private void treeList1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                popupMenu1.ShowPopup(new Point { X = MousePosition.X, Y = MousePosition.Y });
        }

        private void WrongBtn1_Click(object sender, EventArgs e)
        {
            Game.Instance.Wrong1.Visible = !Game.Instance.Wrong1.Visible;
            if (!Game.Instance.Wrong1.Visible) return;
            GameController.Instance.SoundPlay("strata.wav");
            WrongBtn1.ForeColor = Color.Red;

        }

        private void WrongBtn3_Click(object sender, EventArgs e)
        {
            Game.Instance.Wrong3.Visible = !Game.Instance.Wrong3.Visible;
            if (!Game.Instance.Wrong3.Visible) return;
            GameController.Instance.SoundPlay("strata.wav");
            WrongBtn3.ForeColor = Color.Red;
        }

        private void WrongBtn5_Click(object sender, EventArgs e)
        {
            Game.Instance.Wrong5.Visible = !Game.Instance.Wrong5.Visible;
            if (!Game.Instance.Wrong5.Visible) return;
            GameController.Instance.SoundPlay("strata.wav");
            WrongBtn5.ForeColor = Color.Red;
        }

        private void WrongBtn2_Click(object sender, EventArgs e)
        {
            Game.Instance.Wrong2.Visible = !Game.Instance.Wrong2.Visible;
            if (!Game.Instance.Wrong2.Visible) return;
            GameController.Instance.SoundPlay("strata.wav");
            WrongBtn2.ForeColor = Color.Red;
        }

        private void WrongBtn4_Click(object sender, EventArgs e)
        {
            Game.Instance.Wrong4.Visible = !Game.Instance.Wrong4.Visible;
            if (!Game.Instance.Wrong4.Visible) return;
            GameController.Instance.SoundPlay("strata.wav");
            WrongBtn4.ForeColor = Color.Red;
        }

        private void WrongBtn6_Click(object sender, EventArgs e)
        {
            Game.Instance.Wrong6.Visible = !Game.Instance.Wrong6.Visible;
            if (!Game.Instance.Wrong6.Visible) return;
            GameController.Instance.SoundPlay("strata.wav");
            WrongBtn6.ForeColor = Color.Red;
        }

        private void ErrorLogLbl_TextChanged(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ErrorLogLbl.Text = string.Empty;
        }

        string StringPoints = string.Empty;
        int points = 0;

        private void Btn1_Click(object sender, EventArgs e)
        {
            Game.Instance.Answer1.Text = "1. " + Btn1.Text;
            Game.Instance.Pkt1.Text = Btn1.Tag.ToString();
            GameController.Instance.SoundPlay("pkt.wav");


            StringPoints = Btn1.Tag.ToString();
            int.TryParse(StringPoints, out points);
            GameController.Instance.PointsBeforeAdd += points;
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            Game.Instance.Answer2.Text = "2. " + Btn2.Text;
            Game.Instance.Pkt2.Text = Btn2.Tag.ToString();
            GameController.Instance.SoundPlay("pkt.wav");

            StringPoints = Btn2.Tag.ToString();
            int.TryParse(StringPoints, out points);
            GameController.Instance.PointsBeforeAdd += points;
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            Game.Instance.Answer3.Text = "3. " + Btn3.Text;
            Game.Instance.Pkt3.Text = Btn3.Tag.ToString();
            GameController.Instance.SoundPlay("pkt.wav");

            StringPoints = Btn3.Tag.ToString();
            int.TryParse(StringPoints, out points);
            GameController.Instance.PointsBeforeAdd += points;
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            Game.Instance.Answer4.Text = "4. " + Btn4.Text;
            Game.Instance.Pkt4.Text = Btn4.Tag.ToString();
            GameController.Instance.SoundPlay("pkt.wav");

            StringPoints = Btn4.Tag.ToString();
            int.TryParse(StringPoints, out points);
            GameController.Instance.PointsBeforeAdd += points;
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            Game.Instance.Answer5.Text = "5. " + Btn5.Text;
            Game.Instance.Pkt5.Text = Btn5.Tag.ToString();
            GameController.Instance.SoundPlay("pkt.wav");

            StringPoints = Btn5.Tag.ToString();
            int.TryParse(StringPoints, out points);
            GameController.Instance.PointsBeforeAdd += points;
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            Game.Instance.Answer6.Text = "6. " + Btn6.Text;
            Game.Instance.Pkt6.Text = Btn6.Tag.ToString();
            GameController.Instance.SoundPlay("pkt.wav");

            StringPoints = Btn6.Tag.ToString();
            int.TryParse(StringPoints, out points);
            GameController.Instance.PointsBeforeAdd += points;
        }

        private void PointsToLeft_Click(object sender, EventArgs e)
        {
            GameController.Instance.PointsLeft += GameController.Instance.PointsBeforeAdd;
        }

        private void PointsToRight_Click(object sender, EventArgs e)
        {
            GameController.Instance.PointsRight += GameController.Instance.PointsBeforeAdd;

        }

        private void PointsRight_EditValueChanged(object sender, EventArgs e)
        {
            int.TryParse( PointsRight.Text.ToString(), out int num );
            GameController.Instance.PointsRight = num;
        }

        private void PointsLeft_EditValueChanged(object sender, EventArgs e)
        {
            int.TryParse(PointsLeft.Text.ToString(), out int num);
            GameController.Instance.PointsLeft= num;
        }






            //private void Sort()
            //{
            //    foreach(TreeListNode listNode in treeList1.Nodes)
            //    {
            //        foreach (TreeListNode subnode in listNode.Nodes)
            //        {
            //            if (subnode.NextNode == null) continue;
            //            int.TryParse(subnode.GetDisplayText(1), out int out1);
            //            int.TryParse(subnode.NextNode.GetDisplayText(1), out int out2);
            //            if (out1 >= out2) continue;
            //            var bufor = subnode.NextNode;
            //            treeList1.MoveNode(subnode, subnode.NextNode);
            //            treeList1.MoveNode(bufor, subnode);
            //        }

            //    }
            //}

        }
}
