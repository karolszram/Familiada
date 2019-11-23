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
        private static ControlPanel instance;

        public static ControlPanel Instance
        {
            get
            {
                if (instance != null) return instance;
                instance = new ControlPanel();
                return instance;
            }
        }


        public ControlPanel()
        {
            InitializeComponent();
            //QuestionsCtrl.Instance.LoadXml(out Controller.Instance.data, out string msg);
            treeList1.ImportFromXml("pytania.xml");
            treeList1.Nodes.Count
            //this.treelist1.datasource = controller.instance.data;
            //var data = controller.instance.data;
            //foreach (question q in data)
            //{
            //    this.createnodes(this.treelist1,q);
            //}
        }
        public bool SelectRandomQuestion()
        {
            var NodesCOunt= this.treeList1.Nodes.Count();
            treeList1.SelectNode()
        }

        //private void CreateNodes(TreeList tl,Question q)
        //    {
        //        tl.BeginUnboundLoad();
        //    // Create a root node . 
        //    TreeListNode parentForRootNodes = null;
        //    TreeListNode rootNode = tl.AppendNode(
        //        new object[] { q.Name },
        //        parentForRootNodes);
        //    foreach (Answer a in q.Answers)
        //    {
        //        tl.AppendNode(new object[] { a.Name, a.Points }, rootNode);
        //    }

        //    tl.EndUnboundLoad();
        //}

        private void StartBtn_Click(object sender, EventArgs e)
        {
            GameController.Instance.GameStart();
        }



        private void treeList1_RowClick(object sender, RowClickEventArgs e)
        {


            if (!e.Node.HasChildren) return;


            GameController.Instance.CurrentQuestion.Name = e.Node.GetDisplayText(0);
            foreach(TreeListNode Node in e.Node.Nodes)
            {
                var Answer = new Answer();
                Answer.Name = Node.GetDisplayText(0);
                bool ParseSucces = Int32.TryParse( Node.GetDisplayText(1), out int points);
                if (ParseSucces) Answer.Points = points;
                GameController.Instance.CurrentQuestion.Answers.Add(Answer);
            }
            
        }

        private void treeList1_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            treeList1.ExportToXml("pytania.xml");
        }


        private void treeList1_MouseClick(object sender, MouseEventArgs e)
        {
            
            if (e.Button == MouseButtons.Right)
                popupMenu1.ShowPopup(new Point { X = MousePosition.X, Y = MousePosition.Y });

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
        }

        private void popupMenu1_CloseUp(object sender, EventArgs e)
        {
            treeList1.ExportToXml("pytania.xml");
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
        }

        private void treeList1_FocusedNodeChanged(object sender, FocusedNodeChangedEventArgs e)
        {
            if (e.Node.ParentNode != null)
            {
                NextQuestionLabel.Text = e.Node.ParentNode.GetDisplayText(0);
                return;
            }
            NextQuestionLabel.Text =  e.Node.GetDisplayText(0);
        }
    }
}
