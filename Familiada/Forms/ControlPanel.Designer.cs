namespace Familiada
{
    partial class ControlPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.StartBtn = new System.Windows.Forms.Button();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.AddQuestion = new DevExpress.XtraBars.BarButtonItem();
            this.AddAnswer = new DevExpress.XtraBars.BarButtonItem();
            this.Delete = new DevExpress.XtraBars.BarButtonItem();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.NextQuestionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(800, 450);
            this.panelControl1.TabIndex = 1;
            // 
            // treeList1
            // 
            this.treeList1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1,
            this.treeListColumn2});
            this.treeList1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.treeList1.Location = new System.Drawing.Point(12, 12);
            this.treeList1.Name = "treeList1";
            this.treeList1.OptionsBehavior.EditorShowMode = DevExpress.XtraTreeList.TreeListEditorShowMode.DoubleClick;
            this.treeList1.OptionsSelection.SelectNodesOnRightClick = true;
            this.treeList1.Size = new System.Drawing.Size(305, 565);
            this.treeList1.TabIndex = 0;
            this.treeList1.TreeViewFieldName = "Name";
            this.treeList1.RowClick += new DevExpress.XtraTreeList.RowClickEventHandler(this.treeList1_RowClick);
            this.treeList1.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.treeList1_FocusedNodeChanged);
            this.treeList1.ValidatingEditor += new DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventHandler(this.treeList1_ValidatingEditor);
            this.treeList1.CellValueChanged += new DevExpress.XtraTreeList.CellValueChangedEventHandler(this.treeList1_CellValueChanged);
            this.treeList1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.treeList1_KeyDown);
            this.treeList1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.treeList1_MouseClick);
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "Pytanie/Odpowiedź";
            this.treeListColumn1.FieldName = "Pytanie/Odpowiedź";
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 0;
            this.treeListColumn1.Width = 245;
            // 
            // treeListColumn2
            // 
            this.treeListColumn2.Caption = "Pkt";
            this.treeListColumn2.FieldName = "Punkty";
            this.treeListColumn2.Name = "treeListColumn2";
            this.treeListColumn2.Visible = true;
            this.treeListColumn2.VisibleIndex = 1;
            this.treeListColumn2.Width = 39;
            // 
            // StartBtn
            // 
            this.StartBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.StartBtn.ForeColor = System.Drawing.Color.DarkRed;
            this.StartBtn.Location = new System.Drawing.Point(12, 583);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(305, 48);
            this.StartBtn.TabIndex = 1;
            this.StartBtn.Text = "Start!";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.AddQuestion,
            this.AddAnswer,
            this.Delete});
            this.barManager1.MaxItemId = 3;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1349, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 641);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1349, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 641);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1349, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 641);
            // 
            // AddQuestion
            // 
            this.AddQuestion.Caption = "Dodaj pytanie";
            this.AddQuestion.Id = 0;
            this.AddQuestion.Name = "AddQuestion";
            this.AddQuestion.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.AddQuestion_ItemClick);
            // 
            // AddAnswer
            // 
            this.AddAnswer.Caption = "Dodaj odpowiedź";
            this.AddAnswer.Id = 1;
            this.AddAnswer.Name = "AddAnswer";
            this.AddAnswer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.AddAnswer_ItemClick);
            // 
            // Delete
            // 
            this.Delete.Caption = "Usuń";
            this.Delete.Id = 2;
            this.Delete.Name = "Delete";
            this.Delete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Delete_ItemClick);
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.AddQuestion),
            new DevExpress.XtraBars.LinkPersistInfo(this.AddAnswer),
            new DevExpress.XtraBars.LinkPersistInfo(this.Delete)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            this.popupMenu1.CloseUp += new System.EventHandler(this.popupMenu1_CloseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(323, 552);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Następne pytanie:";
            // 
            // NextQuestionLabel
            // 
            this.NextQuestionLabel.AutoSize = true;
            this.NextQuestionLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextQuestionLabel.Location = new System.Drawing.Point(323, 583);
            this.NextQuestionLabel.Name = "NextQuestionLabel";
            this.NextQuestionLabel.Size = new System.Drawing.Size(0, 19);
            this.NextQuestionLabel.TabIndex = 12;
            // 
            // ControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1349, 641);
            this.Controls.Add(this.NextQuestionLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.treeList1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "ControlPanel";
            this.ShowIcon = false;
            this.Text = "Panel kontrolny";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraTreeList.TreeList treeList1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn2;
        private System.Windows.Forms.Button StartBtn;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem AddQuestion;
        private DevExpress.XtraBars.BarButtonItem AddAnswer;
        private DevExpress.XtraBars.BarButtonItem Delete;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label NextQuestionLabel;
    }
}