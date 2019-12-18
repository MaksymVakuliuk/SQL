namespace WindowsForms
{
    partial class Form_Gifts_for_children_of_employeers_DB
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
            this.childrenOfEmployeers = new System.Windows.Forms.DataGridView();
            this.employeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateofbirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.childIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.childrenOfEmployeersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gifts_for_children_of_employeesDataSet = new WindowsForms.Gifts_for_children_of_employeesDataSet();
            this.childrenOfEmployeersTableAdapter = new WindowsForms.Gifts_for_children_of_employeesDataSetTableAdapters.ChildrenOfEmployeersTableAdapter();
            this.employeers = new System.Windows.Forms.DataGridView();
            this.employeeIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patronymicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hiringdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeersTableAdapter = new WindowsForms.Gifts_for_children_of_employeesDataSetTableAdapters.EmployeersTableAdapter();
            this.gifts = new System.Windows.Forms.DataGridView();
            this.childIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giftvalueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateofissueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberofissueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giftsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.giftsTableAdapter = new WindowsForms.Gifts_for_children_of_employeesDataSetTableAdapters.GiftsTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.работаСТаблицамиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.childrenOfEmployeersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giftsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Work_with_procedure = new System.Windows.Forms.ToolStripMenuItem();
            this.childsWithGiftsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeersWithAdultChildrenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeersWithChildrenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giftvaluemoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.fileSystemWatcher2 = new System.IO.FileSystemWatcher();
            this.fileSystemWatcher3 = new System.IO.FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)(this.childrenOfEmployeers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.childrenOfEmployeersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gifts_for_children_of_employeesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gifts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giftsBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher3)).BeginInit();
            this.SuspendLayout();
            // 
            // childrenOfEmployeers
            // 
            this.childrenOfEmployeers.AccessibleName = "";
            this.childrenOfEmployeers.AllowUserToAddRows = false;
            this.childrenOfEmployeers.AllowUserToDeleteRows = false;
            this.childrenOfEmployeers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.childrenOfEmployeers.AutoGenerateColumns = false;
            this.childrenOfEmployeers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.childrenOfEmployeers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.childrenOfEmployeers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeIDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.dateofbirthDataGridViewTextBoxColumn,
            this.childIDDataGridViewTextBoxColumn});
            this.childrenOfEmployeers.DataSource = this.childrenOfEmployeersBindingSource;
            this.childrenOfEmployeers.Location = new System.Drawing.Point(12, 209);
            this.childrenOfEmployeers.Name = "childrenOfEmployeers";
            this.childrenOfEmployeers.ReadOnly = true;
            this.childrenOfEmployeers.RowHeadersWidth = 51;
            this.childrenOfEmployeers.RowTemplate.Height = 24;
            this.childrenOfEmployeers.Size = new System.Drawing.Size(936, 150);
            this.childrenOfEmployeers.TabIndex = 0;
            // 
            // employeeIDDataGridViewTextBoxColumn
            // 
            this.employeeIDDataGridViewTextBoxColumn.DataPropertyName = "Employee_ID";
            this.employeeIDDataGridViewTextBoxColumn.HeaderText = "Employee_ID";
            this.employeeIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.employeeIDDataGridViewTextBoxColumn.Name = "employeeIDDataGridViewTextBoxColumn";
            this.employeeIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateofbirthDataGridViewTextBoxColumn
            // 
            this.dateofbirthDataGridViewTextBoxColumn.DataPropertyName = "Date_of_birth";
            this.dateofbirthDataGridViewTextBoxColumn.HeaderText = "Date_of_birth";
            this.dateofbirthDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateofbirthDataGridViewTextBoxColumn.Name = "dateofbirthDataGridViewTextBoxColumn";
            this.dateofbirthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // childIDDataGridViewTextBoxColumn
            // 
            this.childIDDataGridViewTextBoxColumn.DataPropertyName = "Child_ID";
            this.childIDDataGridViewTextBoxColumn.HeaderText = "Child_ID";
            this.childIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.childIDDataGridViewTextBoxColumn.Name = "childIDDataGridViewTextBoxColumn";
            this.childIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // childrenOfEmployeersBindingSource
            // 
            this.childrenOfEmployeersBindingSource.DataMember = "ChildrenOfEmployeers";
            this.childrenOfEmployeersBindingSource.DataSource = this.gifts_for_children_of_employeesDataSet;
            // 
            // gifts_for_children_of_employeesDataSet
            // 
            this.gifts_for_children_of_employeesDataSet.DataSetName = "Gifts_for_children_of_employeesDataSet";
            this.gifts_for_children_of_employeesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // childrenOfEmployeersTableAdapter
            // 
            this.childrenOfEmployeersTableAdapter.ClearBeforeFill = true;
            // 
            // employeers
            // 
            this.employeers.AccessibleName = "employeers";
            this.employeers.AllowUserToAddRows = false;
            this.employeers.AllowUserToDeleteRows = false;
            this.employeers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.employeers.AutoGenerateColumns = false;
            this.employeers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.employeers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeIDDataGridViewTextBoxColumn1,
            this.lastNameDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn1,
            this.patronymicDataGridViewTextBoxColumn,
            this.positionDataGridViewTextBoxColumn,
            this.departmentDataGridViewTextBoxColumn,
            this.hiringdateDataGridViewTextBoxColumn});
            this.employeers.DataSource = this.employeersBindingSource;
            this.employeers.Location = new System.Drawing.Point(12, 31);
            this.employeers.Name = "employeers";
            this.employeers.ReadOnly = true;
            this.employeers.RowHeadersWidth = 51;
            this.employeers.RowTemplate.Height = 24;
            this.employeers.Size = new System.Drawing.Size(936, 160);
            this.employeers.TabIndex = 1;
            // 
            // employeeIDDataGridViewTextBoxColumn1
            // 
            this.employeeIDDataGridViewTextBoxColumn1.DataPropertyName = "Employee_ID";
            this.employeeIDDataGridViewTextBoxColumn1.HeaderText = "Employee_ID";
            this.employeeIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.employeeIDDataGridViewTextBoxColumn1.Name = "employeeIDDataGridViewTextBoxColumn1";
            this.employeeIDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn1
            // 
            this.firstNameDataGridViewTextBoxColumn1.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn1.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.firstNameDataGridViewTextBoxColumn1.Name = "firstNameDataGridViewTextBoxColumn1";
            this.firstNameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // patronymicDataGridViewTextBoxColumn
            // 
            this.patronymicDataGridViewTextBoxColumn.DataPropertyName = "Patronymic";
            this.patronymicDataGridViewTextBoxColumn.HeaderText = "Patronymic";
            this.patronymicDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.patronymicDataGridViewTextBoxColumn.Name = "patronymicDataGridViewTextBoxColumn";
            this.patronymicDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // positionDataGridViewTextBoxColumn
            // 
            this.positionDataGridViewTextBoxColumn.DataPropertyName = "Position";
            this.positionDataGridViewTextBoxColumn.HeaderText = "Position";
            this.positionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            this.positionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // departmentDataGridViewTextBoxColumn
            // 
            this.departmentDataGridViewTextBoxColumn.DataPropertyName = "Department";
            this.departmentDataGridViewTextBoxColumn.HeaderText = "Department";
            this.departmentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.departmentDataGridViewTextBoxColumn.Name = "departmentDataGridViewTextBoxColumn";
            this.departmentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hiringdateDataGridViewTextBoxColumn
            // 
            this.hiringdateDataGridViewTextBoxColumn.DataPropertyName = "Hiring_date";
            this.hiringdateDataGridViewTextBoxColumn.HeaderText = "Hiring_date";
            this.hiringdateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hiringdateDataGridViewTextBoxColumn.Name = "hiringdateDataGridViewTextBoxColumn";
            this.hiringdateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeersBindingSource
            // 
            this.employeersBindingSource.DataMember = "Employeers";
            this.employeersBindingSource.DataSource = this.gifts_for_children_of_employeesDataSet;
            // 
            // employeersTableAdapter
            // 
            this.employeersTableAdapter.ClearBeforeFill = true;
            // 
            // gifts
            // 
            this.gifts.AccessibleName = "gifts";
            this.gifts.AllowUserToAddRows = false;
            this.gifts.AllowUserToDeleteRows = false;
            this.gifts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gifts.AutoGenerateColumns = false;
            this.gifts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gifts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gifts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.childIDDataGridViewTextBoxColumn1,
            this.giftvalueDataGridViewTextBoxColumn,
            this.dateofissueDataGridViewTextBoxColumn,
            this.numberofissueDataGridViewTextBoxColumn});
            this.gifts.DataSource = this.giftsBindingSource;
            this.gifts.Location = new System.Drawing.Point(12, 382);
            this.gifts.Name = "gifts";
            this.gifts.ReadOnly = true;
            this.gifts.RowHeadersWidth = 51;
            this.gifts.RowTemplate.Height = 24;
            this.gifts.Size = new System.Drawing.Size(936, 150);
            this.gifts.TabIndex = 2;
            // 
            // childIDDataGridViewTextBoxColumn1
            // 
            this.childIDDataGridViewTextBoxColumn1.DataPropertyName = "Child_ID";
            this.childIDDataGridViewTextBoxColumn1.HeaderText = "Child_ID";
            this.childIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.childIDDataGridViewTextBoxColumn1.Name = "childIDDataGridViewTextBoxColumn1";
            this.childIDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // giftvalueDataGridViewTextBoxColumn
            // 
            this.giftvalueDataGridViewTextBoxColumn.DataPropertyName = "Gift_value";
            this.giftvalueDataGridViewTextBoxColumn.HeaderText = "Gift_value";
            this.giftvalueDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.giftvalueDataGridViewTextBoxColumn.Name = "giftvalueDataGridViewTextBoxColumn";
            this.giftvalueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateofissueDataGridViewTextBoxColumn
            // 
            this.dateofissueDataGridViewTextBoxColumn.DataPropertyName = "Date_of_issue";
            this.dateofissueDataGridViewTextBoxColumn.HeaderText = "Date_of_issue";
            this.dateofissueDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateofissueDataGridViewTextBoxColumn.Name = "dateofissueDataGridViewTextBoxColumn";
            this.dateofissueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numberofissueDataGridViewTextBoxColumn
            // 
            this.numberofissueDataGridViewTextBoxColumn.DataPropertyName = "Number_of_issue";
            this.numberofissueDataGridViewTextBoxColumn.HeaderText = "Number_of_issue";
            this.numberofissueDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numberofissueDataGridViewTextBoxColumn.Name = "numberofissueDataGridViewTextBoxColumn";
            this.numberofissueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // giftsBindingSource
            // 
            this.giftsBindingSource.DataMember = "Gifts";
            this.giftsBindingSource.DataSource = this.gifts_for_children_of_employeesDataSet;
            // 
            // giftsTableAdapter
            // 
            this.giftsTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.работаСТаблицамиToolStripMenuItem,
            this.Work_with_procedure});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(966, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // работаСТаблицамиToolStripMenuItem
            // 
            this.работаСТаблицамиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeersToolStripMenuItem,
            this.childrenOfEmployeersToolStripMenuItem,
            this.giftsToolStripMenuItem});
            this.работаСТаблицамиToolStripMenuItem.Name = "работаСТаблицамиToolStripMenuItem";
            this.работаСТаблицамиToolStripMenuItem.Size = new System.Drawing.Size(163, 24);
            this.работаСТаблицамиToolStripMenuItem.Text = "Работа с таблицами";
            // 
            // employeersToolStripMenuItem
            // 
            this.employeersToolStripMenuItem.Name = "employeersToolStripMenuItem";
            this.employeersToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.employeersToolStripMenuItem.Text = "Employeers";
            this.employeersToolStripMenuItem.Click += new System.EventHandler(this.Open_Form_Employeers_Click);
            // 
            // childrenOfEmployeersToolStripMenuItem
            // 
            this.childrenOfEmployeersToolStripMenuItem.Name = "childrenOfEmployeersToolStripMenuItem";
            this.childrenOfEmployeersToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.childrenOfEmployeersToolStripMenuItem.Text = "ChildrenOfEmployeers";
            this.childrenOfEmployeersToolStripMenuItem.Click += new System.EventHandler(this.Open_Form_ChildrenOfEmployeers_Click);
            // 
            // giftsToolStripMenuItem
            // 
            this.giftsToolStripMenuItem.Name = "giftsToolStripMenuItem";
            this.giftsToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.giftsToolStripMenuItem.Text = "Gifts";
            this.giftsToolStripMenuItem.Click += new System.EventHandler(this.Open_Form_Gifts_Click);
            // 
            // Work_with_procedure
            // 
            this.Work_with_procedure.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.childsWithGiftsToolStripMenuItem,
            this.employeersWithAdultChildrenToolStripMenuItem,
            this.employeersWithChildrenToolStripMenuItem,
            this.giftvaluemoreToolStripMenuItem});
            this.Work_with_procedure.Name = "Work_with_procedure";
            this.Work_with_procedure.Size = new System.Drawing.Size(186, 24);
            this.Work_with_procedure.Text = "Работа с процедурами ";
            // 
            // childsWithGiftsToolStripMenuItem
            // 
            this.childsWithGiftsToolStripMenuItem.Name = "childsWithGiftsToolStripMenuItem";
            this.childsWithGiftsToolStripMenuItem.Size = new System.Drawing.Size(296, 26);
            this.childsWithGiftsToolStripMenuItem.Text = "children with gifts";
            // 
            // employeersWithAdultChildrenToolStripMenuItem
            // 
            this.employeersWithAdultChildrenToolStripMenuItem.Name = "employeersWithAdultChildrenToolStripMenuItem";
            this.employeersWithAdultChildrenToolStripMenuItem.Size = new System.Drawing.Size(296, 26);
            this.employeersWithAdultChildrenToolStripMenuItem.Text = "employeers with adult children";
            // 
            // employeersWithChildrenToolStripMenuItem
            // 
            this.employeersWithChildrenToolStripMenuItem.Name = "employeersWithChildrenToolStripMenuItem";
            this.employeersWithChildrenToolStripMenuItem.Size = new System.Drawing.Size(296, 26);
            this.employeersWithChildrenToolStripMenuItem.Text = "employeers with children";
            this.employeersWithChildrenToolStripMenuItem.Click += new System.EventHandler(this.employeersWithChildrenToolStripMenuItem_Click);
            // 
            // giftvaluemoreToolStripMenuItem
            // 
            this.giftvaluemoreToolStripMenuItem.Name = "giftvaluemoreToolStripMenuItem";
            this.giftvaluemoreToolStripMenuItem.Size = new System.Drawing.Size(296, 26);
            this.giftvaluemoreToolStripMenuItem.Text = "gift value more";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // fileSystemWatcher2
            // 
            this.fileSystemWatcher2.EnableRaisingEvents = true;
            this.fileSystemWatcher2.SynchronizingObject = this;
            // 
            // fileSystemWatcher3
            // 
            this.fileSystemWatcher3.EnableRaisingEvents = true;
            this.fileSystemWatcher3.SynchronizingObject = this;
            // 
            // Form_Gifts_for_children_of_employeers_DB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 554);
            this.Controls.Add(this.gifts);
            this.Controls.Add(this.employeers);
            this.Controls.Add(this.childrenOfEmployeers);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_Gifts_for_children_of_employeers_DB";
            this.Text = "Gifts_for_children_of_employeers_DB";
            this.Activated += new System.EventHandler(this.FormGifts_for_children_of_employeers_Load);
            this.Load += new System.EventHandler(this.FormGifts_for_children_of_employeers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.childrenOfEmployeers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.childrenOfEmployeersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gifts_for_children_of_employeesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gifts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giftsBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView childrenOfEmployeers;
        private Gifts_for_children_of_employeesDataSet gifts_for_children_of_employeesDataSet;
        private System.Windows.Forms.BindingSource childrenOfEmployeersBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateofbirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn childIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView employeers;
        private System.Windows.Forms.BindingSource employeersBindingSource;
        private Gifts_for_children_of_employeesDataSetTableAdapters.EmployeersTableAdapter employeersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn patronymicDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hiringdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView gifts;
        private System.Windows.Forms.BindingSource giftsBindingSource;
        private Gifts_for_children_of_employeesDataSetTableAdapters.GiftsTableAdapter giftsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn childIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn giftvalueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateofissueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberofissueDataGridViewTextBoxColumn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem работаСТаблицамиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem childrenOfEmployeersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giftsToolStripMenuItem;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.IO.FileSystemWatcher fileSystemWatcher2;
        private System.IO.FileSystemWatcher fileSystemWatcher3;
        private Gifts_for_children_of_employeesDataSetTableAdapters.ChildrenOfEmployeersTableAdapter childrenOfEmployeersTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem Work_with_procedure;
        private System.Windows.Forms.ToolStripMenuItem childsWithGiftsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeersWithAdultChildrenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeersWithChildrenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giftvaluemoreToolStripMenuItem;
    }
}

