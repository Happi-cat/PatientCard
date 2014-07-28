namespace PatientCard.Forms
{
    partial class HistoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistoryForm));
            this.tabsGlobal = new System.Windows.Forms.TabControl();
            this.tabDiagnostics = new System.Windows.Forms.TabPage();
            this.diagnosticsDataGridView = new System.Windows.Forms.DataGridView();
            this.diagnosticsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clinicDataSet = new PatientCard.Data.ClinicDataSet();
            this.diagnosticsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.tabCurePlans = new System.Windows.Forms.TabPage();
            this.curePlansDataGridView = new System.Windows.Forms.DataGridView();
            this.curePlansBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.curePlansBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem1 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem1 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem1 = new System.Windows.Forms.ToolStripButton();
            this.curePlansTableAdapter = new PatientCard.Data.ClinicDataSetTableAdapters.CurePlansTableAdapter();
            this.diagnosticsTableAdapter = new PatientCard.Data.ClinicDataSetTableAdapters.DiagnosticsTableAdapter();
            this.createdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reasonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.limbDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstAidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingNavigatorDeleteItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.DiagnosticId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlanId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabsGlobal.SuspendLayout();
            this.tabDiagnostics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosticsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosticsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosticsBindingNavigator)).BeginInit();
            this.diagnosticsBindingNavigator.SuspendLayout();
            this.tabCurePlans.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.curePlansDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.curePlansBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.curePlansBindingNavigator)).BeginInit();
            this.curePlansBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabsGlobal
            // 
            this.tabsGlobal.Controls.Add(this.tabDiagnostics);
            this.tabsGlobal.Controls.Add(this.tabCurePlans);
            this.tabsGlobal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabsGlobal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabsGlobal.Location = new System.Drawing.Point(0, 0);
            this.tabsGlobal.Name = "tabsGlobal";
            this.tabsGlobal.SelectedIndex = 0;
            this.tabsGlobal.Size = new System.Drawing.Size(808, 465);
            this.tabsGlobal.TabIndex = 0;
            // 
            // tabDiagnostics
            // 
            this.tabDiagnostics.Controls.Add(this.diagnosticsDataGridView);
            this.tabDiagnostics.Controls.Add(this.diagnosticsBindingNavigator);
            this.tabDiagnostics.Location = new System.Drawing.Point(4, 25);
            this.tabDiagnostics.Name = "tabDiagnostics";
            this.tabDiagnostics.Padding = new System.Windows.Forms.Padding(3);
            this.tabDiagnostics.Size = new System.Drawing.Size(800, 436);
            this.tabDiagnostics.TabIndex = 0;
            this.tabDiagnostics.Text = "Обследования";
            this.tabDiagnostics.UseVisualStyleBackColor = true;
            // 
            // diagnosticsDataGridView
            // 
            this.diagnosticsDataGridView.AllowUserToAddRows = false;
            this.diagnosticsDataGridView.AllowUserToDeleteRows = false;
            this.diagnosticsDataGridView.AutoGenerateColumns = false;
            this.diagnosticsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.diagnosticsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.createdDataGridViewTextBoxColumn,
            this.reasonDataGridViewTextBoxColumn,
            this.faceDataGridViewTextBoxColumn,
            this.skinDataGridViewTextBoxColumn,
            this.limbDataGridViewTextBoxColumn,
            this.boneDataGridViewTextBoxColumn,
            this.DiagnosticId});
            this.diagnosticsDataGridView.DataSource = this.diagnosticsBindingSource;
            this.diagnosticsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diagnosticsDataGridView.Location = new System.Drawing.Point(3, 28);
            this.diagnosticsDataGridView.Name = "diagnosticsDataGridView";
            this.diagnosticsDataGridView.ReadOnly = true;
            this.diagnosticsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.diagnosticsDataGridView.Size = new System.Drawing.Size(794, 405);
            this.diagnosticsDataGridView.TabIndex = 1;
            this.diagnosticsDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.diagnosticsDataGridView_CellDoubleClick);
            // 
            // diagnosticsBindingSource
            // 
            this.diagnosticsBindingSource.DataMember = "Diagnostics";
            this.diagnosticsBindingSource.DataSource = this.clinicDataSet;
            // 
            // clinicDataSet
            // 
            this.clinicDataSet.DataSetName = "ClinicDataSet";
            this.clinicDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // diagnosticsBindingNavigator
            // 
            this.diagnosticsBindingNavigator.AddNewItem = null;
            this.diagnosticsBindingNavigator.BindingSource = this.diagnosticsBindingSource;
            this.diagnosticsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.diagnosticsBindingNavigator.DeleteItem = null;
            this.diagnosticsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.diagnosticsBindingNavigator.Location = new System.Drawing.Point(3, 3);
            this.diagnosticsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.diagnosticsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.diagnosticsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.diagnosticsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.diagnosticsBindingNavigator.Name = "diagnosticsBindingNavigator";
            this.diagnosticsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.diagnosticsBindingNavigator.Size = new System.Drawing.Size(794, 25);
            this.diagnosticsBindingNavigator.TabIndex = 0;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // tabCurePlans
            // 
            this.tabCurePlans.Controls.Add(this.curePlansDataGridView);
            this.tabCurePlans.Controls.Add(this.curePlansBindingNavigator);
            this.tabCurePlans.Location = new System.Drawing.Point(4, 25);
            this.tabCurePlans.Name = "tabCurePlans";
            this.tabCurePlans.Padding = new System.Windows.Forms.Padding(3);
            this.tabCurePlans.Size = new System.Drawing.Size(800, 436);
            this.tabCurePlans.TabIndex = 1;
            this.tabCurePlans.Text = "Лечения";
            this.tabCurePlans.UseVisualStyleBackColor = true;
            // 
            // curePlansDataGridView
            // 
            this.curePlansDataGridView.AllowUserToAddRows = false;
            this.curePlansDataGridView.AllowUserToDeleteRows = false;
            this.curePlansDataGridView.AutoGenerateColumns = false;
            this.curePlansDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.curePlansDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.createdDataGridViewTextBoxColumn1,
            this.firstAidDataGridViewTextBoxColumn,
            this.doctorDataGridViewTextBoxColumn,
            this.PlanId});
            this.curePlansDataGridView.DataSource = this.curePlansBindingSource;
            this.curePlansDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.curePlansDataGridView.Location = new System.Drawing.Point(3, 28);
            this.curePlansDataGridView.Name = "curePlansDataGridView";
            this.curePlansDataGridView.ReadOnly = true;
            this.curePlansDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.curePlansDataGridView.Size = new System.Drawing.Size(794, 405);
            this.curePlansDataGridView.TabIndex = 1;
            this.curePlansDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.curePlansDataGridView_CellDoubleClick);
            // 
            // curePlansBindingSource
            // 
            this.curePlansBindingSource.DataMember = "CurePlans";
            this.curePlansBindingSource.DataSource = this.clinicDataSet;
            // 
            // curePlansBindingNavigator
            // 
            this.curePlansBindingNavigator.AddNewItem = null;
            this.curePlansBindingNavigator.BindingSource = this.curePlansBindingSource;
            this.curePlansBindingNavigator.CountItem = this.bindingNavigatorCountItem1;
            this.curePlansBindingNavigator.DeleteItem = null;
            this.curePlansBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem1,
            this.bindingNavigatorMovePreviousItem1,
            this.bindingNavigatorSeparator3,
            this.bindingNavigatorPositionItem1,
            this.bindingNavigatorCountItem1,
            this.bindingNavigatorSeparator4,
            this.bindingNavigatorMoveNextItem1,
            this.bindingNavigatorMoveLastItem1,
            this.bindingNavigatorSeparator5,
            this.bindingNavigatorAddNewItem1,
            this.bindingNavigatorDeleteItem1});
            this.curePlansBindingNavigator.Location = new System.Drawing.Point(3, 3);
            this.curePlansBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem1;
            this.curePlansBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem1;
            this.curePlansBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem1;
            this.curePlansBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem1;
            this.curePlansBindingNavigator.Name = "curePlansBindingNavigator";
            this.curePlansBindingNavigator.PositionItem = this.bindingNavigatorPositionItem1;
            this.curePlansBindingNavigator.Size = new System.Drawing.Size(794, 25);
            this.curePlansBindingNavigator.TabIndex = 0;
            // 
            // bindingNavigatorCountItem1
            // 
            this.bindingNavigatorCountItem1.Name = "bindingNavigatorCountItem1";
            this.bindingNavigatorCountItem1.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem1.Text = "of {0}";
            this.bindingNavigatorCountItem1.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem1
            // 
            this.bindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem1.Image")));
            this.bindingNavigatorMoveFirstItem1.Name = "bindingNavigatorMoveFirstItem1";
            this.bindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem1.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem1
            // 
            this.bindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem1.Image")));
            this.bindingNavigatorMovePreviousItem1.Name = "bindingNavigatorMovePreviousItem1";
            this.bindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem1.Text = "Move previous";
            // 
            // bindingNavigatorSeparator3
            // 
            this.bindingNavigatorSeparator3.Name = "bindingNavigatorSeparator3";
            this.bindingNavigatorSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem1
            // 
            this.bindingNavigatorPositionItem1.AccessibleName = "Position";
            this.bindingNavigatorPositionItem1.AutoSize = false;
            this.bindingNavigatorPositionItem1.Name = "bindingNavigatorPositionItem1";
            this.bindingNavigatorPositionItem1.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem1.Text = "0";
            this.bindingNavigatorPositionItem1.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator4
            // 
            this.bindingNavigatorSeparator4.Name = "bindingNavigatorSeparator4";
            this.bindingNavigatorSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem1
            // 
            this.bindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem1.Image")));
            this.bindingNavigatorMoveNextItem1.Name = "bindingNavigatorMoveNextItem1";
            this.bindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem1.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem1
            // 
            this.bindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem1.Image")));
            this.bindingNavigatorMoveLastItem1.Name = "bindingNavigatorMoveLastItem1";
            this.bindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem1.Text = "Move last";
            // 
            // bindingNavigatorSeparator5
            // 
            this.bindingNavigatorSeparator5.Name = "bindingNavigatorSeparator5";
            this.bindingNavigatorSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem1
            // 
            this.bindingNavigatorAddNewItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem1.Image")));
            this.bindingNavigatorAddNewItem1.Name = "bindingNavigatorAddNewItem1";
            this.bindingNavigatorAddNewItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem1.Text = "Add new";
            this.bindingNavigatorAddNewItem1.Click += new System.EventHandler(this.bindingNavigatorAddNewItem1_Click);
            // 
            // curePlansTableAdapter
            // 
            this.curePlansTableAdapter.ClearBeforeFill = true;
            // 
            // diagnosticsTableAdapter
            // 
            this.diagnosticsTableAdapter.ClearBeforeFill = true;
            // 
            // createdDataGridViewTextBoxColumn
            // 
            this.createdDataGridViewTextBoxColumn.DataPropertyName = "Created";
            this.createdDataGridViewTextBoxColumn.HeaderText = "Created";
            this.createdDataGridViewTextBoxColumn.Name = "createdDataGridViewTextBoxColumn";
            this.createdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // reasonDataGridViewTextBoxColumn
            // 
            this.reasonDataGridViewTextBoxColumn.DataPropertyName = "Reason";
            this.reasonDataGridViewTextBoxColumn.HeaderText = "Reason";
            this.reasonDataGridViewTextBoxColumn.Name = "reasonDataGridViewTextBoxColumn";
            this.reasonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // faceDataGridViewTextBoxColumn
            // 
            this.faceDataGridViewTextBoxColumn.DataPropertyName = "Face";
            this.faceDataGridViewTextBoxColumn.HeaderText = "Face";
            this.faceDataGridViewTextBoxColumn.Name = "faceDataGridViewTextBoxColumn";
            this.faceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // skinDataGridViewTextBoxColumn
            // 
            this.skinDataGridViewTextBoxColumn.DataPropertyName = "Skin";
            this.skinDataGridViewTextBoxColumn.HeaderText = "Skin";
            this.skinDataGridViewTextBoxColumn.Name = "skinDataGridViewTextBoxColumn";
            this.skinDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // limbDataGridViewTextBoxColumn
            // 
            this.limbDataGridViewTextBoxColumn.DataPropertyName = "Limb";
            this.limbDataGridViewTextBoxColumn.HeaderText = "Limb";
            this.limbDataGridViewTextBoxColumn.Name = "limbDataGridViewTextBoxColumn";
            this.limbDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // boneDataGridViewTextBoxColumn
            // 
            this.boneDataGridViewTextBoxColumn.DataPropertyName = "Bone";
            this.boneDataGridViewTextBoxColumn.HeaderText = "Bone";
            this.boneDataGridViewTextBoxColumn.Name = "boneDataGridViewTextBoxColumn";
            this.boneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // createdDataGridViewTextBoxColumn1
            // 
            this.createdDataGridViewTextBoxColumn1.DataPropertyName = "Created";
            this.createdDataGridViewTextBoxColumn1.HeaderText = "Created";
            this.createdDataGridViewTextBoxColumn1.Name = "createdDataGridViewTextBoxColumn1";
            this.createdDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // firstAidDataGridViewTextBoxColumn
            // 
            this.firstAidDataGridViewTextBoxColumn.DataPropertyName = "FirstAid";
            this.firstAidDataGridViewTextBoxColumn.HeaderText = "FirstAid";
            this.firstAidDataGridViewTextBoxColumn.Name = "firstAidDataGridViewTextBoxColumn";
            this.firstAidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // doctorDataGridViewTextBoxColumn
            // 
            this.doctorDataGridViewTextBoxColumn.DataPropertyName = "Doctor";
            this.doctorDataGridViewTextBoxColumn.HeaderText = "Doctor";
            this.doctorDataGridViewTextBoxColumn.Name = "doctorDataGridViewTextBoxColumn";
            this.doctorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bindingNavigatorDeleteItem1
            // 
            this.bindingNavigatorDeleteItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem1.Image")));
            this.bindingNavigatorDeleteItem1.Name = "bindingNavigatorDeleteItem1";
            this.bindingNavigatorDeleteItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem1.Text = "Delete";
            this.bindingNavigatorDeleteItem1.Visible = false;
            this.bindingNavigatorDeleteItem1.Click += new System.EventHandler(this.bindingNavigatorDeleteItem1_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Visible = false;
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // DiagnosticId
            // 
            this.DiagnosticId.DataPropertyName = "DiagnosticId";
            this.DiagnosticId.HeaderText = "DiagnosticId";
            this.DiagnosticId.Name = "DiagnosticId";
            this.DiagnosticId.ReadOnly = true;
            // 
            // PlanId
            // 
            this.PlanId.DataPropertyName = "PlanId";
            this.PlanId.HeaderText = "PlanId";
            this.PlanId.Name = "PlanId";
            this.PlanId.ReadOnly = true;
            // 
            // HistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 465);
            this.Controls.Add(this.tabsGlobal);
            this.Name = "HistoryForm";
            this.Text = "История обследований";
            this.Load += new System.EventHandler(this.HistoryForm_Load);
            this.tabsGlobal.ResumeLayout(false);
            this.tabDiagnostics.ResumeLayout(false);
            this.tabDiagnostics.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosticsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosticsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosticsBindingNavigator)).EndInit();
            this.diagnosticsBindingNavigator.ResumeLayout(false);
            this.diagnosticsBindingNavigator.PerformLayout();
            this.tabCurePlans.ResumeLayout(false);
            this.tabCurePlans.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.curePlansDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.curePlansBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.curePlansBindingNavigator)).EndInit();
            this.curePlansBindingNavigator.ResumeLayout(false);
            this.curePlansBindingNavigator.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabsGlobal;
        private System.Windows.Forms.TabPage tabDiagnostics;
        private System.Windows.Forms.TabPage tabCurePlans;
        private Data.ClinicDataSetTableAdapters.CurePlansTableAdapter curePlansTableAdapter;
        private Data.ClinicDataSetTableAdapters.DiagnosticsTableAdapter diagnosticsTableAdapter;
        private Data.ClinicDataSet clinicDataSet;
        private System.Windows.Forms.BindingSource curePlansBindingSource;
        private System.Windows.Forms.BindingSource diagnosticsBindingSource;
        private System.Windows.Forms.BindingNavigator diagnosticsBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.DataGridView diagnosticsDataGridView;
        private System.Windows.Forms.BindingNavigator curePlansBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator3;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator5;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem1;
        private System.Windows.Forms.DataGridView curePlansDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reasonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn faceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn skinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn limbDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn boneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstAidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiagnosticId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlanId;

    }
}