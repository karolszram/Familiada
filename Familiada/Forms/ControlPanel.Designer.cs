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
            this.label2 = new System.Windows.Forms.Label();
            this.CurrentQuestionLbl = new System.Windows.Forms.Label();
            this.WrongBtn1 = new System.Windows.Forms.Button();
            this.WrongBtn3 = new System.Windows.Forms.Button();
            this.WrongBtn5 = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ErrorLogLbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Btn1 = new DevExpress.XtraEditors.SimpleButton();
            this.WrongBtn6 = new System.Windows.Forms.Button();
            this.WrongBtn4 = new System.Windows.Forms.Button();
            this.WrongBtn2 = new System.Windows.Forms.Button();
            this.Btn2 = new DevExpress.XtraEditors.SimpleButton();
            this.Btn3 = new DevExpress.XtraEditors.SimpleButton();
            this.Btn4 = new DevExpress.XtraEditors.SimpleButton();
            this.Btn5 = new DevExpress.XtraEditors.SimpleButton();
            this.Btn6 = new DevExpress.XtraEditors.SimpleButton();
            this.PointsLeft = new DevExpress.XtraEditors.TextEdit();
            this.PointsRight = new DevExpress.XtraEditors.TextEdit();
            this.PointsToLeft = new System.Windows.Forms.Button();
            this.PointsToRight = new System.Windows.Forms.Button();
            this.CurrentPointsLbl = new System.Windows.Forms.Label();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.FullScreenBtn = new System.Windows.Forms.Button();
            this.PictureBtn = new System.Windows.Forms.Button();
            this.MusicStartBtn = new System.Windows.Forms.Button();
            this.MusicEndBtn = new System.Windows.Forms.Button();
            this.MusicStopBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PointsLeft.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PointsRight.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
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
            this.treeList1.ActiveFilterEnabled = false;
            this.treeList1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeList1.Appearance.BandPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeList1.Appearance.BandPanel.Options.UseFont = true;
            this.treeList1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeList1.Appearance.Row.Options.UseFont = true;
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1,
            this.treeListColumn2});
            this.treeList1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.treeList1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.treeList1.Location = new System.Drawing.Point(12, 12);
            this.treeList1.Name = "treeList1";
            this.treeList1.OptionsBehavior.AutoScrollOnSorting = false;
            this.treeList1.OptionsBehavior.EditorShowMode = DevExpress.XtraTreeList.TreeListEditorShowMode.DoubleClick;
            this.treeList1.OptionsSelection.SelectNodesOnRightClick = true;
            this.treeList1.Size = new System.Drawing.Size(430, 642);
            this.treeList1.TabIndex = 0;
            this.treeList1.TreeViewFieldName = "Name";
            this.treeList1.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.treeList1_FocusedNodeChanged);
            this.treeList1.ValidatingEditor += new DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventHandler(this.treeList1_ValidatingEditor);
            this.treeList1.CustomDrawNodeIndicator += new DevExpress.XtraTreeList.CustomDrawNodeIndicatorEventHandler(this.treeList1_CustomDrawNodeIndicator);
            this.treeList1.CellValueChanged += new DevExpress.XtraTreeList.CellValueChangedEventHandler(this.treeList1_CellValueChanged);
            this.treeList1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.treeList1_KeyDown);
            this.treeList1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.treeList1_MouseDown);
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeListColumn1.AppearanceCell.Options.UseFont = true;
            this.treeListColumn1.Caption = "Pytanie/Odpowiedź";
            this.treeListColumn1.FieldName = "Pytanie/Odpowiedź";
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.OptionsColumn.ShowInExpressionEditor = false;
            this.treeListColumn1.OptionsFilter.AllowAutoFilter = false;
            this.treeListColumn1.OptionsFilter.AllowFilter = false;
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 0;
            this.treeListColumn1.Width = 258;
            // 
            // treeListColumn2
            // 
            this.treeListColumn2.Caption = "Pkt";
            this.treeListColumn2.FieldName = "Punkty";
            this.treeListColumn2.Name = "treeListColumn2";
            this.treeListColumn2.OptionsColumn.ShowInExpressionEditor = false;
            this.treeListColumn2.OptionsFilter.AllowAutoFilter = false;
            this.treeListColumn2.OptionsFilter.AllowFilter = false;
            this.treeListColumn2.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value;
            this.treeListColumn2.SortOrder = System.Windows.Forms.SortOrder.Descending;
            this.treeListColumn2.Visible = true;
            this.treeListColumn2.VisibleIndex = 1;
            this.treeListColumn2.Width = 35;
            // 
            // StartBtn
            // 
            this.StartBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StartBtn.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartBtn.ForeColor = System.Drawing.Color.DarkRed;
            this.StartBtn.Location = new System.Drawing.Point(12, 660);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(430, 48);
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
            this.barDockControlTop.Size = new System.Drawing.Size(948, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 718);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(948, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 718);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(948, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 718);
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
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(448, 629);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Następne pytanie:";
            // 
            // NextQuestionLabel
            // 
            this.NextQuestionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NextQuestionLabel.AutoSize = true;
            this.NextQuestionLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextQuestionLabel.Location = new System.Drawing.Point(448, 660);
            this.NextQuestionLabel.Name = "NextQuestionLabel";
            this.NextQuestionLabel.Size = new System.Drawing.Size(15, 19);
            this.NextQuestionLabel.TabIndex = 12;
            this.NextQuestionLabel.Text = "-";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(448, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Aktualne pytanie:";
            // 
            // CurrentQuestionLbl
            // 
            this.CurrentQuestionLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CurrentQuestionLbl.AutoSize = true;
            this.CurrentQuestionLbl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentQuestionLbl.Location = new System.Drawing.Point(449, 34);
            this.CurrentQuestionLbl.Name = "CurrentQuestionLbl";
            this.CurrentQuestionLbl.Size = new System.Drawing.Size(15, 19);
            this.CurrentQuestionLbl.TabIndex = 18;
            this.CurrentQuestionLbl.Text = "-";
            // 
            // WrongBtn1
            // 
            this.WrongBtn1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.WrongBtn1.Font = new System.Drawing.Font("Tahoma", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WrongBtn1.ForeColor = System.Drawing.Color.Black;
            this.WrongBtn1.Location = new System.Drawing.Point(448, 208);
            this.WrongBtn1.Name = "WrongBtn1";
            this.WrongBtn1.Size = new System.Drawing.Size(60, 60);
            this.WrongBtn1.TabIndex = 23;
            this.WrongBtn1.Text = "X";
            this.WrongBtn1.UseVisualStyleBackColor = true;
            this.WrongBtn1.Visible = false;
            this.WrongBtn1.Click += new System.EventHandler(this.WrongBtn1_Click);
            // 
            // WrongBtn3
            // 
            this.WrongBtn3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.WrongBtn3.Font = new System.Drawing.Font("Tahoma", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WrongBtn3.ForeColor = System.Drawing.Color.Black;
            this.WrongBtn3.Location = new System.Drawing.Point(448, 274);
            this.WrongBtn3.Name = "WrongBtn3";
            this.WrongBtn3.Size = new System.Drawing.Size(60, 60);
            this.WrongBtn3.TabIndex = 24;
            this.WrongBtn3.Text = "X";
            this.WrongBtn3.UseVisualStyleBackColor = true;
            this.WrongBtn3.Visible = false;
            this.WrongBtn3.Click += new System.EventHandler(this.WrongBtn3_Click);
            // 
            // WrongBtn5
            // 
            this.WrongBtn5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.WrongBtn5.Font = new System.Drawing.Font("Tahoma", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WrongBtn5.ForeColor = System.Drawing.Color.Black;
            this.WrongBtn5.Location = new System.Drawing.Point(448, 340);
            this.WrongBtn5.Name = "WrongBtn5";
            this.WrongBtn5.Size = new System.Drawing.Size(60, 60);
            this.WrongBtn5.TabIndex = 25;
            this.WrongBtn5.Text = "X";
            this.WrongBtn5.UseVisualStyleBackColor = true;
            this.WrongBtn5.Visible = false;
            this.WrongBtn5.Click += new System.EventHandler(this.WrongBtn5_Click);
            // 
            // ErrorLogLbl
            // 
            this.ErrorLogLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ErrorLogLbl.AutoSize = true;
            this.ErrorLogLbl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorLogLbl.Location = new System.Drawing.Point(324, 690);
            this.ErrorLogLbl.Name = "ErrorLogLbl";
            this.ErrorLogLbl.Size = new System.Drawing.Size(0, 19);
            this.ErrorLogLbl.TabIndex = 30;
            this.ErrorLogLbl.TextChanged += new System.EventHandler(this.ErrorLogLbl_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Btn1
            // 
            this.Btn1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn1.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.Btn1.Appearance.Options.UseFont = true;
            this.Btn1.Location = new System.Drawing.Point(514, 142);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(360, 60);
            this.Btn1.TabIndex = 32;
            this.Btn1.Visible = false;
            this.Btn1.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // WrongBtn6
            // 
            this.WrongBtn6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.WrongBtn6.Font = new System.Drawing.Font("Tahoma", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WrongBtn6.ForeColor = System.Drawing.Color.Black;
            this.WrongBtn6.Location = new System.Drawing.Point(880, 340);
            this.WrongBtn6.Name = "WrongBtn6";
            this.WrongBtn6.Size = new System.Drawing.Size(60, 60);
            this.WrongBtn6.TabIndex = 35;
            this.WrongBtn6.Text = "X";
            this.WrongBtn6.UseVisualStyleBackColor = true;
            this.WrongBtn6.Visible = false;
            this.WrongBtn6.Click += new System.EventHandler(this.WrongBtn6_Click);
            // 
            // WrongBtn4
            // 
            this.WrongBtn4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.WrongBtn4.Font = new System.Drawing.Font("Tahoma", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WrongBtn4.ForeColor = System.Drawing.Color.Black;
            this.WrongBtn4.Location = new System.Drawing.Point(880, 274);
            this.WrongBtn4.Name = "WrongBtn4";
            this.WrongBtn4.Size = new System.Drawing.Size(60, 60);
            this.WrongBtn4.TabIndex = 34;
            this.WrongBtn4.Text = "X";
            this.WrongBtn4.UseVisualStyleBackColor = true;
            this.WrongBtn4.Visible = false;
            this.WrongBtn4.Click += new System.EventHandler(this.WrongBtn4_Click);
            // 
            // WrongBtn2
            // 
            this.WrongBtn2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.WrongBtn2.Font = new System.Drawing.Font("Tahoma", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WrongBtn2.ForeColor = System.Drawing.Color.Black;
            this.WrongBtn2.Location = new System.Drawing.Point(880, 208);
            this.WrongBtn2.Name = "WrongBtn2";
            this.WrongBtn2.Size = new System.Drawing.Size(60, 60);
            this.WrongBtn2.TabIndex = 33;
            this.WrongBtn2.Text = "X";
            this.WrongBtn2.UseVisualStyleBackColor = true;
            this.WrongBtn2.Visible = false;
            this.WrongBtn2.Click += new System.EventHandler(this.WrongBtn2_Click);
            // 
            // Btn2
            // 
            this.Btn2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn2.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.Btn2.Appearance.Options.UseFont = true;
            this.Btn2.Location = new System.Drawing.Point(514, 208);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(360, 60);
            this.Btn2.TabIndex = 36;
            this.Btn2.Visible = false;
            this.Btn2.Click += new System.EventHandler(this.Btn2_Click);
            // 
            // Btn3
            // 
            this.Btn3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn3.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.Btn3.Appearance.Options.UseFont = true;
            this.Btn3.Location = new System.Drawing.Point(514, 274);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(360, 60);
            this.Btn3.TabIndex = 37;
            this.Btn3.Visible = false;
            this.Btn3.Click += new System.EventHandler(this.Btn3_Click);
            // 
            // Btn4
            // 
            this.Btn4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn4.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.Btn4.Appearance.Options.UseFont = true;
            this.Btn4.Location = new System.Drawing.Point(514, 340);
            this.Btn4.Name = "Btn4";
            this.Btn4.Size = new System.Drawing.Size(360, 60);
            this.Btn4.TabIndex = 38;
            this.Btn4.Visible = false;
            this.Btn4.Click += new System.EventHandler(this.Btn4_Click);
            // 
            // Btn5
            // 
            this.Btn5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn5.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.Btn5.Appearance.Options.UseFont = true;
            this.Btn5.Location = new System.Drawing.Point(514, 406);
            this.Btn5.Name = "Btn5";
            this.Btn5.Size = new System.Drawing.Size(360, 60);
            this.Btn5.TabIndex = 39;
            this.Btn5.Visible = false;
            this.Btn5.Click += new System.EventHandler(this.Btn5_Click);
            // 
            // Btn6
            // 
            this.Btn6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn6.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.Btn6.Appearance.Options.UseFont = true;
            this.Btn6.Location = new System.Drawing.Point(514, 472);
            this.Btn6.Name = "Btn6";
            this.Btn6.Size = new System.Drawing.Size(360, 60);
            this.Btn6.TabIndex = 40;
            this.Btn6.Visible = false;
            this.Btn6.Click += new System.EventHandler(this.Btn6_Click);
            // 
            // PointsLeft
            // 
            this.PointsLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PointsLeft.EditValue = "0";
            this.PointsLeft.Location = new System.Drawing.Point(448, 66);
            this.PointsLeft.MenuManager = this.barManager1;
            this.PointsLeft.Name = "PointsLeft";
            this.PointsLeft.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PointsLeft.Properties.Appearance.Options.UseFont = true;
            this.PointsLeft.Properties.Mask.EditMask = "d";
            this.PointsLeft.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.PointsLeft.Size = new System.Drawing.Size(60, 32);
            this.PointsLeft.TabIndex = 51;
            this.PointsLeft.Visible = false;
            this.PointsLeft.EditValueChanged += new System.EventHandler(this.PointsLeft_EditValueChanged);
            // 
            // PointsRight
            // 
            this.PointsRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PointsRight.EditValue = "0";
            this.PointsRight.Location = new System.Drawing.Point(880, 66);
            this.PointsRight.MenuManager = this.barManager1;
            this.PointsRight.Name = "PointsRight";
            this.PointsRight.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PointsRight.Properties.Appearance.Options.UseFont = true;
            this.PointsRight.Properties.Mask.EditMask = "d";
            this.PointsRight.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.PointsRight.Size = new System.Drawing.Size(60, 32);
            this.PointsRight.TabIndex = 52;
            this.PointsRight.Visible = false;
            this.PointsRight.EditValueChanged += new System.EventHandler(this.PointsRight_EditValueChanged);
            // 
            // PointsToLeft
            // 
            this.PointsToLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PointsToLeft.Font = new System.Drawing.Font("Tahoma", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PointsToLeft.ForeColor = System.Drawing.Color.Green;
            this.PointsToLeft.Location = new System.Drawing.Point(448, 142);
            this.PointsToLeft.Name = "PointsToLeft";
            this.PointsToLeft.Size = new System.Drawing.Size(60, 60);
            this.PointsToLeft.TabIndex = 57;
            this.PointsToLeft.Text = "<";
            this.PointsToLeft.UseVisualStyleBackColor = true;
            this.PointsToLeft.Visible = false;
            this.PointsToLeft.Click += new System.EventHandler(this.PointsToLeft_Click);
            // 
            // PointsToRight
            // 
            this.PointsToRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PointsToRight.Font = new System.Drawing.Font("Tahoma", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PointsToRight.ForeColor = System.Drawing.Color.Green;
            this.PointsToRight.Location = new System.Drawing.Point(880, 142);
            this.PointsToRight.Name = "PointsToRight";
            this.PointsToRight.Size = new System.Drawing.Size(60, 60);
            this.PointsToRight.TabIndex = 58;
            this.PointsToRight.Text = ">";
            this.PointsToRight.UseVisualStyleBackColor = true;
            this.PointsToRight.Visible = false;
            this.PointsToRight.Click += new System.EventHandler(this.PointsToRight_Click);
            // 
            // CurrentPointsLbl
            // 
            this.CurrentPointsLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CurrentPointsLbl.AutoSize = true;
            this.CurrentPointsLbl.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentPointsLbl.Location = new System.Drawing.Point(665, 73);
            this.CurrentPointsLbl.Name = "CurrentPointsLbl";
            this.CurrentPointsLbl.Size = new System.Drawing.Size(23, 25);
            this.CurrentPointsLbl.TabIndex = 63;
            this.CurrentPointsLbl.Text = "0";
            this.CurrentPointsLbl.Visible = false;
            // 
            // textEdit1
            // 
            this.textEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textEdit1.EditValue = "";
            this.textEdit1.Location = new System.Drawing.Point(448, 104);
            this.textEdit1.MenuManager = this.barManager1;
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit1.Properties.Appearance.Options.UseFont = true;
            this.textEdit1.Properties.Mask.EditMask = "d";
            this.textEdit1.Properties.NullText = "Drużyna A";
            this.textEdit1.Properties.NullValuePrompt = "Drużyna A";
            this.textEdit1.Properties.NullValuePromptShowForEmptyValue = true;
            this.textEdit1.Properties.ShowNullValuePromptWhenFocused = true;
            this.textEdit1.ShowToolTips = false;
            this.textEdit1.Size = new System.Drawing.Size(240, 32);
            this.textEdit1.TabIndex = 68;
            this.textEdit1.EditValueChanged += new System.EventHandler(this.textEdit1_EditValueChanged);
            this.textEdit1.TextChanged += new System.EventHandler(this.textEdit1_TextChanged);
            // 
            // textEdit2
            // 
            this.textEdit2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textEdit2.EditValue = "";
            this.textEdit2.Location = new System.Drawing.Point(697, 104);
            this.textEdit2.MenuManager = this.barManager1;
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit2.Properties.Appearance.Options.UseFont = true;
            this.textEdit2.Properties.Mask.EditMask = "d";
            this.textEdit2.Properties.NullValuePrompt = "Drużyna B";
            this.textEdit2.Properties.NullValuePromptShowForEmptyValue = true;
            this.textEdit2.Properties.ShowNullValuePromptWhenFocused = true;
            this.textEdit2.Size = new System.Drawing.Size(243, 32);
            this.textEdit2.TabIndex = 69;
            this.textEdit2.EditValueChanged += new System.EventHandler(this.textEdit2_EditValueChanged);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseBtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.CloseBtn.ForeColor = System.Drawing.Color.Black;
            this.CloseBtn.Location = new System.Drawing.Point(852, 566);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(88, 60);
            this.CloseBtn.TabIndex = 70;
            this.CloseBtn.Text = "Zamknij";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Visible = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // FullScreenBtn
            // 
            this.FullScreenBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FullScreenBtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.FullScreenBtn.ForeColor = System.Drawing.Color.Black;
            this.FullScreenBtn.Location = new System.Drawing.Point(524, 566);
            this.FullScreenBtn.Name = "FullScreenBtn";
            this.FullScreenBtn.Size = new System.Drawing.Size(101, 60);
            this.FullScreenBtn.TabIndex = 71;
            this.FullScreenBtn.Text = "FullScreen";
            this.FullScreenBtn.UseVisualStyleBackColor = true;
            this.FullScreenBtn.Visible = false;
            this.FullScreenBtn.Click += new System.EventHandler(this.FullScreenBtn_Click);
            // 
            // PictureBtn
            // 
            this.PictureBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureBtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.PictureBtn.ForeColor = System.Drawing.Color.Black;
            this.PictureBtn.Location = new System.Drawing.Point(448, 566);
            this.PictureBtn.Name = "PictureBtn";
            this.PictureBtn.Size = new System.Drawing.Size(70, 60);
            this.PictureBtn.TabIndex = 81;
            this.PictureBtn.Text = "Obraz";
            this.PictureBtn.UseVisualStyleBackColor = true;
            this.PictureBtn.Visible = false;
            this.PictureBtn.Click += new System.EventHandler(this.PictureBtn_Click);
            // 
            // MusicStartBtn
            // 
            this.MusicStartBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MusicStartBtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.MusicStartBtn.ForeColor = System.Drawing.Color.Black;
            this.MusicStartBtn.Location = new System.Drawing.Point(631, 566);
            this.MusicStartBtn.Name = "MusicStartBtn";
            this.MusicStartBtn.Size = new System.Drawing.Size(70, 60);
            this.MusicStartBtn.TabIndex = 82;
            this.MusicStartBtn.Text = "Start";
            this.MusicStartBtn.UseVisualStyleBackColor = true;
            this.MusicStartBtn.Visible = false;
            this.MusicStartBtn.Click += new System.EventHandler(this.MusicStartBtn_Click);
            // 
            // MusicEndBtn
            // 
            this.MusicEndBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MusicEndBtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.MusicEndBtn.ForeColor = System.Drawing.Color.Black;
            this.MusicEndBtn.Location = new System.Drawing.Point(707, 566);
            this.MusicEndBtn.Name = "MusicEndBtn";
            this.MusicEndBtn.Size = new System.Drawing.Size(77, 60);
            this.MusicEndBtn.TabIndex = 83;
            this.MusicEndBtn.Text = "Koniec";
            this.MusicEndBtn.UseVisualStyleBackColor = true;
            this.MusicEndBtn.Visible = false;
            this.MusicEndBtn.Click += new System.EventHandler(this.MusicEndBtn_Click);
            // 
            // MusicStopBtn
            // 
            this.MusicStopBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MusicStopBtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.MusicStopBtn.ForeColor = System.Drawing.Color.Black;
            this.MusicStopBtn.Location = new System.Drawing.Point(790, 566);
            this.MusicStopBtn.Name = "MusicStopBtn";
            this.MusicStopBtn.Size = new System.Drawing.Size(56, 60);
            this.MusicStopBtn.TabIndex = 88;
            this.MusicStopBtn.Text = "Stop";
            this.MusicStopBtn.UseVisualStyleBackColor = true;
            this.MusicStopBtn.Visible = false;
            this.MusicStopBtn.Click += new System.EventHandler(this.MusicStopBtn_Click);
            // 
            // ControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 718);
            this.Controls.Add(this.MusicStopBtn);
            this.Controls.Add(this.MusicEndBtn);
            this.Controls.Add(this.MusicStartBtn);
            this.Controls.Add(this.PictureBtn);
            this.Controls.Add(this.FullScreenBtn);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.textEdit2);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.CurrentPointsLbl);
            this.Controls.Add(this.PointsToRight);
            this.Controls.Add(this.PointsToLeft);
            this.Controls.Add(this.PointsRight);
            this.Controls.Add(this.PointsLeft);
            this.Controls.Add(this.Btn6);
            this.Controls.Add(this.Btn5);
            this.Controls.Add(this.Btn4);
            this.Controls.Add(this.Btn3);
            this.Controls.Add(this.Btn2);
            this.Controls.Add(this.WrongBtn6);
            this.Controls.Add(this.WrongBtn4);
            this.Controls.Add(this.WrongBtn2);
            this.Controls.Add(this.Btn1);
            this.Controls.Add(this.ErrorLogLbl);
            this.Controls.Add(this.WrongBtn5);
            this.Controls.Add(this.WrongBtn3);
            this.Controls.Add(this.WrongBtn1);
            this.Controls.Add(this.CurrentQuestionLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NextQuestionLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.treeList1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.MinimumSize = new System.Drawing.Size(950, 750);
            this.Name = "ControlPanel";
            this.ShowIcon = false;
            this.Text = "Panel kontrolny";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PointsLeft.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PointsRight.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn2;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem AddQuestion;
        private DevExpress.XtraBars.BarButtonItem AddAnswer;
        private DevExpress.XtraBars.BarButtonItem Delete;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        public DevExpress.XtraTreeList.TreeList treeList1;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button StartBtn;
        public System.Windows.Forms.Label CurrentQuestionLbl;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label NextQuestionLabel;
        private System.Windows.Forms.BindingSource bindingSource1;
        public System.Windows.Forms.Label ErrorLogLbl;
        public System.Windows.Forms.Timer timer1;
        public DevExpress.XtraEditors.SimpleButton Btn6;
        public DevExpress.XtraEditors.SimpleButton Btn5;
        public DevExpress.XtraEditors.SimpleButton Btn4;
        public DevExpress.XtraEditors.SimpleButton Btn3;
        public DevExpress.XtraEditors.SimpleButton Btn2;
        public DevExpress.XtraEditors.SimpleButton Btn1;
        public System.Windows.Forms.Button WrongBtn1;
        public System.Windows.Forms.Button WrongBtn5;
        public System.Windows.Forms.Button WrongBtn3;
        public System.Windows.Forms.Button WrongBtn6;
        public System.Windows.Forms.Button WrongBtn4;
        public System.Windows.Forms.Button WrongBtn2;
        public DevExpress.XtraEditors.TextEdit PointsRight;
        public DevExpress.XtraEditors.TextEdit PointsLeft;
        public System.Windows.Forms.Button PointsToRight;
        public System.Windows.Forms.Button PointsToLeft;
        public System.Windows.Forms.Label CurrentPointsLbl;
        public DevExpress.XtraEditors.TextEdit textEdit2;
        public DevExpress.XtraEditors.TextEdit textEdit1;
        public System.Windows.Forms.Button FullScreenBtn;
        public System.Windows.Forms.Button CloseBtn;
        public System.Windows.Forms.Button PictureBtn;
        public System.Windows.Forms.Button MusicEndBtn;
        public System.Windows.Forms.Button MusicStartBtn;
        public System.Windows.Forms.Button MusicStopBtn;
    }
}