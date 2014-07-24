namespace PatientCard.Forms
{
    partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.bindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
			this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
			this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.clinicDataSet = new PatientCard.Data.ClinicDataSet();
			this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
			this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
			this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.patientCardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.diagnosticFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.historyFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.curePlanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.researchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dataGridPatients = new System.Windows.Forms.DataGridView();
			this.cardIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.middleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.birthDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.socialStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.workDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.createdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.patientCardsTableAdapter = new PatientCard.Data.ClinicDataSetTableAdapters.PatientCardsTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.bindingNavigator)).BeginInit();
			this.bindingNavigator.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.clinicDataSet)).BeginInit();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridPatients)).BeginInit();
			this.SuspendLayout();
			// 
			// bindingNavigator
			// 
			this.bindingNavigator.AddNewItem = null;
			this.bindingNavigator.BindingSource = this.bindingSource;
			this.bindingNavigator.CountItem = this.bindingNavigatorCountItem;
			this.bindingNavigator.DeleteItem = null;
			this.bindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
			this.bindingNavigator.Location = new System.Drawing.Point(0, 24);
			this.bindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.bindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.bindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.bindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.bindingNavigator.Name = "bindingNavigator";
			this.bindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
			this.bindingNavigator.Size = new System.Drawing.Size(1251, 25);
			this.bindingNavigator.TabIndex = 1;
			this.bindingNavigator.Text = "bindingNavigator";
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
			// bindingSource
			// 
			this.bindingSource.AllowNew = true;
			this.bindingSource.DataMember = "PatientCards";
			this.bindingSource.DataSource = this.clinicDataSet;
			// 
			// clinicDataSet
			// 
			this.clinicDataSet.DataSetName = "ClinicDataSet";
			this.clinicDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// bindingNavigatorCountItem
			// 
			this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
			this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
			this.bindingNavigatorCountItem.Text = "of {0}";
			this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
			// 
			// bindingNavigatorDeleteItem
			// 
			this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
			this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
			this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorDeleteItem.Text = "Delete";
			this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
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
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1251, 24);
			this.menuStrip1.TabIndex = 3;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// testToolStripMenuItem
			// 
			this.testToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.patientCardToolStripMenuItem,
            this.diagnosticFormToolStripMenuItem,
            this.historyFormToolStripMenuItem,
            this.curePlanToolStripMenuItem,
            this.researchToolStripMenuItem});
			this.testToolStripMenuItem.Name = "testToolStripMenuItem";
			this.testToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
			this.testToolStripMenuItem.Text = "Test";
			// 
			// patientCardToolStripMenuItem
			// 
			this.patientCardToolStripMenuItem.Name = "patientCardToolStripMenuItem";
			this.patientCardToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
			this.patientCardToolStripMenuItem.Text = "Patient card";
			this.patientCardToolStripMenuItem.Click += new System.EventHandler(this.patientCardToolStripMenuItem_Click);
			// 
			// diagnosticFormToolStripMenuItem
			// 
			this.diagnosticFormToolStripMenuItem.Name = "diagnosticFormToolStripMenuItem";
			this.diagnosticFormToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
			this.diagnosticFormToolStripMenuItem.Text = "Diagnostic";
			this.diagnosticFormToolStripMenuItem.Click += new System.EventHandler(this.diagnosticFormToolStripMenuItem_Click);
			// 
			// historyFormToolStripMenuItem
			// 
			this.historyFormToolStripMenuItem.Name = "historyFormToolStripMenuItem";
			this.historyFormToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
			this.historyFormToolStripMenuItem.Text = "History";
			this.historyFormToolStripMenuItem.Click += new System.EventHandler(this.historyFormToolStripMenuItem_Click);
			// 
			// curePlanToolStripMenuItem
			// 
			this.curePlanToolStripMenuItem.Name = "curePlanToolStripMenuItem";
			this.curePlanToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
			this.curePlanToolStripMenuItem.Text = "Cure plan";
			this.curePlanToolStripMenuItem.Click += new System.EventHandler(this.curePlanToolStripMenuItem_Click);
			// 
			// researchToolStripMenuItem
			// 
			this.researchToolStripMenuItem.Name = "researchToolStripMenuItem";
			this.researchToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
			this.researchToolStripMenuItem.Text = "Research";
			this.researchToolStripMenuItem.Click += new System.EventHandler(this.researchToolStripMenuItem_Click);
			// 
			// dataGridPatients
			// 
			this.dataGridPatients.AllowUserToAddRows = false;
			this.dataGridPatients.AutoGenerateColumns = false;
			this.dataGridPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridPatients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cardIdDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.middleNameDataGridViewTextBoxColumn,
            this.birthDateDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.socialStatusDataGridViewTextBoxColumn,
            this.workDataGridViewTextBoxColumn,
            this.createdDataGridViewTextBoxColumn});
			this.dataGridPatients.DataSource = this.bindingSource;
			this.dataGridPatients.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridPatients.Location = new System.Drawing.Point(0, 49);
			this.dataGridPatients.Name = "dataGridPatients";
			this.dataGridPatients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridPatients.Size = new System.Drawing.Size(1251, 561);
			this.dataGridPatients.TabIndex = 2;
			this.dataGridPatients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPatients_CellContentClick);
			this.dataGridPatients.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
			// 
			// cardIdDataGridViewTextBoxColumn
			// 
			this.cardIdDataGridViewTextBoxColumn.DataPropertyName = "CardId";
			this.cardIdDataGridViewTextBoxColumn.HeaderText = "CardId";
			this.cardIdDataGridViewTextBoxColumn.Name = "cardIdDataGridViewTextBoxColumn";
			// 
			// lastNameDataGridViewTextBoxColumn
			// 
			this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
			this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
			this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
			// 
			// firstNameDataGridViewTextBoxColumn
			// 
			this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
			this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
			this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
			// 
			// middleNameDataGridViewTextBoxColumn
			// 
			this.middleNameDataGridViewTextBoxColumn.DataPropertyName = "MiddleName";
			this.middleNameDataGridViewTextBoxColumn.HeaderText = "MiddleName";
			this.middleNameDataGridViewTextBoxColumn.Name = "middleNameDataGridViewTextBoxColumn";
			// 
			// birthDateDataGridViewTextBoxColumn
			// 
			this.birthDateDataGridViewTextBoxColumn.DataPropertyName = "BirthDate";
			this.birthDateDataGridViewTextBoxColumn.HeaderText = "BirthDate";
			this.birthDateDataGridViewTextBoxColumn.Name = "birthDateDataGridViewTextBoxColumn";
			// 
			// genderDataGridViewTextBoxColumn
			// 
			this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
			this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
			this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
			// 
			// addressDataGridViewTextBoxColumn
			// 
			this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
			this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
			this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
			// 
			// phoneDataGridViewTextBoxColumn
			// 
			this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
			this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
			this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
			// 
			// socialStatusDataGridViewTextBoxColumn
			// 
			this.socialStatusDataGridViewTextBoxColumn.DataPropertyName = "SocialStatus";
			this.socialStatusDataGridViewTextBoxColumn.HeaderText = "SocialStatus";
			this.socialStatusDataGridViewTextBoxColumn.Name = "socialStatusDataGridViewTextBoxColumn";
			// 
			// workDataGridViewTextBoxColumn
			// 
			this.workDataGridViewTextBoxColumn.DataPropertyName = "Work";
			this.workDataGridViewTextBoxColumn.HeaderText = "Work";
			this.workDataGridViewTextBoxColumn.Name = "workDataGridViewTextBoxColumn";
			// 
			// createdDataGridViewTextBoxColumn
			// 
			this.createdDataGridViewTextBoxColumn.DataPropertyName = "Created";
			this.createdDataGridViewTextBoxColumn.HeaderText = "Created";
			this.createdDataGridViewTextBoxColumn.Name = "createdDataGridViewTextBoxColumn";
			// 
			// patientCardsTableAdapter
			// 
			this.patientCardsTableAdapter.ClearBeforeFill = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1251, 610);
			this.Controls.Add(this.dataGridPatients);
			this.Controls.Add(this.bindingNavigator);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "MainForm";
			this.Load += new System.EventHandler(this.MainForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.bindingNavigator)).EndInit();
			this.bindingNavigator.ResumeLayout(false);
			this.bindingNavigator.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.clinicDataSet)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridPatients)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator bindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView dataGridPatients;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientCardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diagnosticFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem curePlanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem researchToolStripMenuItem;
		private Data.ClinicDataSet clinicDataSet;
		private System.Windows.Forms.BindingSource bindingSource;
		private Data.ClinicDataSetTableAdapters.PatientCardsTableAdapter patientCardsTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn cardIdDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn middleNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn birthDateDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn socialStatusDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn workDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn createdDataGridViewTextBoxColumn;


    }
}