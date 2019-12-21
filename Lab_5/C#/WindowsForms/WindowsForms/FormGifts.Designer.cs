namespace WindowsForms
{
    partial class FormGifts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGifts));
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.giftsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gifts_for_children_of_employeesDataSet = new WindowsForms.Gifts_for_children_of_employeesDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.childIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giftvalueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateofissueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberofissueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giftsTableAdapter = new WindowsForms.Gifts_for_children_of_employeesDataSetTableAdapters.GiftsTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Drop_filter_button = new System.Windows.Forms.Button();
            this.Filter_by_Gift_value_button = new System.Windows.Forms.Button();
            this.Filter_by_Date_of_issue_button = new System.Windows.Forms.Button();
            this.childrenOfEmployeersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.childrenOfEmployeersTableAdapter = new WindowsForms.Gifts_for_children_of_employeesDataSetTableAdapters.ChildrenOfEmployeersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.giftsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gifts_for_children_of_employeesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.childrenOfEmployeersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.giftsBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(613, 27);
            this.bindingNavigator1.TabIndex = 0;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // giftsBindingSource
            // 
            this.giftsBindingSource.DataMember = "Gifts";
            this.giftsBindingSource.DataSource = this.gifts_for_children_of_employeesDataSet;
            // 
            // gifts_for_children_of_employeesDataSet
            // 
            this.gifts_for_children_of_employeesDataSet.DataSetName = "Gifts_for_children_of_employeesDataSet";
            this.gifts_for_children_of_employeesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.childIDDataGridViewTextBoxColumn,
            this.giftvalueDataGridViewTextBoxColumn,
            this.dateofissueDataGridViewTextBoxColumn,
            this.numberofissueDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.giftsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(589, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // childIDDataGridViewTextBoxColumn
            // 
            this.childIDDataGridViewTextBoxColumn.DataPropertyName = "Child_ID";
            this.childIDDataGridViewTextBoxColumn.HeaderText = "Child_ID";
            this.childIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.childIDDataGridViewTextBoxColumn.Name = "childIDDataGridViewTextBoxColumn";
            this.childIDDataGridViewTextBoxColumn.ReadOnly = true;
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
            // giftsTableAdapter
            // 
            this.giftsTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(277, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 27);
            this.button1.TabIndex = 19;
            this.button1.Text = "Update";
            this.button1.UseCompatibleTextRendering = true;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Update_Button_Click);
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.giftsBindingSource, "Number_of_issue", true));
            this.textBox3.Location = new System.Drawing.Point(138, 300);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(121, 22);
            this.textBox3.TabIndex = 18;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.giftsBindingSource, "Date_of_issue", true));
            this.textBox2.Location = new System.Drawing.Point(138, 270);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 22);
            this.textBox2.TabIndex = 17;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.giftsBindingSource, "Gift_value", true));
            this.textBox1.Location = new System.Drawing.Point(138, 240);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 22);
            this.textBox1.TabIndex = 16;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.giftsBindingSource, "Child_ID", true));
            this.comboBox1.DataSource = this.childrenOfEmployeersBindingSource;
            this.comboBox1.DisplayMember = "FirstName";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(138, 207);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.ValueMember = "Child_ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Number of issue";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Date of issue";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Gift value";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Child First Name";
            // 
            // Drop_filter_button
            // 
            this.Drop_filter_button.Location = new System.Drawing.Point(406, 270);
            this.Drop_filter_button.Name = "Drop_filter_button";
            this.Drop_filter_button.Size = new System.Drawing.Size(195, 23);
            this.Drop_filter_button.TabIndex = 26;
            this.Drop_filter_button.Text = "Drop filter";
            this.Drop_filter_button.UseCompatibleTextRendering = true;
            this.Drop_filter_button.UseVisualStyleBackColor = true;
            this.Drop_filter_button.Click += new System.EventHandler(this.Drop_filter_button_Click);
            // 
            // Filter_by_Gift_value_button
            // 
            this.Filter_by_Gift_value_button.Location = new System.Drawing.Point(406, 210);
            this.Filter_by_Gift_value_button.Name = "Filter_by_Gift_value_button";
            this.Filter_by_Gift_value_button.Size = new System.Drawing.Size(195, 23);
            this.Filter_by_Gift_value_button.TabIndex = 24;
            this.Filter_by_Gift_value_button.Text = "Filter by Gift value";
            this.Filter_by_Gift_value_button.UseCompatibleTextRendering = true;
            this.Filter_by_Gift_value_button.UseVisualStyleBackColor = true;
            this.Filter_by_Gift_value_button.Click += new System.EventHandler(this.Filter_by_Gift_value_button_Click);
            // 
            // Filter_by_Date_of_issue_button
            // 
            this.Filter_by_Date_of_issue_button.Location = new System.Drawing.Point(406, 239);
            this.Filter_by_Date_of_issue_button.Name = "Filter_by_Date_of_issue_button";
            this.Filter_by_Date_of_issue_button.Size = new System.Drawing.Size(195, 23);
            this.Filter_by_Date_of_issue_button.TabIndex = 23;
            this.Filter_by_Date_of_issue_button.Text = "Filter by Data of issue";
            this.Filter_by_Date_of_issue_button.UseCompatibleTextRendering = true;
            this.Filter_by_Date_of_issue_button.UseVisualStyleBackColor = true;
            this.Filter_by_Date_of_issue_button.Click += new System.EventHandler(this.Filter_by_Date_of_issue_button_Click);
            // 
            // childrenOfEmployeersBindingSource
            // 
            this.childrenOfEmployeersBindingSource.DataMember = "ChildrenOfEmployeers";
            this.childrenOfEmployeersBindingSource.DataSource = this.gifts_for_children_of_employeesDataSet;
            // 
            // childrenOfEmployeersTableAdapter
            // 
            this.childrenOfEmployeersTableAdapter.ClearBeforeFill = true;
            // 
            // FormGifts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 352);
            this.Controls.Add(this.Drop_filter_button);
            this.Controls.Add(this.Filter_by_Gift_value_button);
            this.Controls.Add(this.Filter_by_Date_of_issue_button);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bindingNavigator1);
            this.Name = "FormGifts";
            this.Text = "Gifts";
            this.Load += new System.EventHandler(this.FormGifts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.giftsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gifts_for_children_of_employeesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.childrenOfEmployeersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Gifts_for_children_of_employeesDataSet gifts_for_children_of_employeesDataSet;
        private System.Windows.Forms.BindingSource giftsBindingSource;
        private Gifts_for_children_of_employeesDataSetTableAdapters.GiftsTableAdapter giftsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn childIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giftvalueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateofissueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberofissueDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Drop_filter_button;
        private System.Windows.Forms.Button Filter_by_Gift_value_button;
        private System.Windows.Forms.Button Filter_by_Date_of_issue_button;
        private System.Windows.Forms.BindingSource childrenOfEmployeersBindingSource;
        private Gifts_for_children_of_employeesDataSetTableAdapters.ChildrenOfEmployeersTableAdapter childrenOfEmployeersTableAdapter;
    }
}