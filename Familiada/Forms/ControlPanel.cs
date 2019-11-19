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
            //this.treeList1.DataSource = Controller.Instance.data;
            //var data = Controller.Instance.data;
            //foreach (Question q in data)
            //{
            //    this.CreateNodes(this.treeList1,q);
            //}
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

        private void treeList1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                popupMenu1.ShowPopup(new Point { X = MousePosition.X, Y = MousePosition.Y });

        }

        private void popupMenu1_CloseUp(object sender, EventArgs e)
        {
            
        }
    }
}
