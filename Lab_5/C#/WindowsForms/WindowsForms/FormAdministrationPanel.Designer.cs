namespace WindowsForms
{
    partial class FormAdministrationPanel
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
            this.EnterLoginOfTheUser = new System.Windows.Forms.Label();
            this.EnterThePassword = new System.Windows.Forms.Label();
            this.EnteredLoginOfTheUserTextBox = new System.Windows.Forms.TextBox();
            this.EnteredThePasswordTextBox = new System.Windows.Forms.TextBox();
            this.AddTheNewUserButton = new System.Windows.Forms.Button();
            this.DropTheNewUserButton = new System.Windows.Forms.Button();
            this.SelectTableLabel = new System.Windows.Forms.Label();
            this.SelectedTableComboBox = new System.Windows.Forms.ComboBox();
            this.gifts_for_children_of_employeesDataSet = new WindowsForms.Gifts_for_children_of_employeesDataSet();
            this.giftsforchildrenofemployeesDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SelectedOperationComboBox = new System.Windows.Forms.ComboBox();
            this.SelectOperationLabel = new System.Windows.Forms.Label();
            this.GrantUserRightButton = new System.Windows.Forms.Button();
            this.DenyUserRightButton = new System.Windows.Forms.Button();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.addTheNewUserSqlCommand = new System.Data.SqlClient.SqlCommand();
            this.dropTheNewUserSqlCommand = new System.Data.SqlClient.SqlCommand();
            this.grantUserRightSqlCommand = new System.Data.SqlClient.SqlCommand();
            this.denyUserRightSqlCommand = new System.Data.SqlClient.SqlCommand();
            ((System.ComponentModel.ISupportInitialize)(this.gifts_for_children_of_employeesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giftsforchildrenofemployeesDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // EnterLoginOfTheUser
            // 
            this.EnterLoginOfTheUser.AutoSize = true;
            this.EnterLoginOfTheUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnterLoginOfTheUser.Location = new System.Drawing.Point(20, 13);
            this.EnterLoginOfTheUser.Name = "EnterLoginOfTheUser";
            this.EnterLoginOfTheUser.Size = new System.Drawing.Size(174, 20);
            this.EnterLoginOfTheUser.TabIndex = 0;
            this.EnterLoginOfTheUser.Text = "Enter login of the user";
            // 
            // EnterThePassword
            // 
            this.EnterThePassword.AutoSize = true;
            this.EnterThePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnterThePassword.Location = new System.Drawing.Point(20, 43);
            this.EnterThePassword.Name = "EnterThePassword";
            this.EnterThePassword.Size = new System.Drawing.Size(154, 20);
            this.EnterThePassword.TabIndex = 1;
            this.EnterThePassword.Text = "Enter the password";
            // 
            // EnteredLoginOfTheUserTextBox
            // 
            this.EnteredLoginOfTheUserTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnteredLoginOfTheUserTextBox.Location = new System.Drawing.Point(226, 10);
            this.EnteredLoginOfTheUserTextBox.Name = "EnteredLoginOfTheUserTextBox";
            this.EnteredLoginOfTheUserTextBox.Size = new System.Drawing.Size(130, 27);
            this.EnteredLoginOfTheUserTextBox.TabIndex = 2;
            // 
            // EnteredThePasswordTextBox
            // 
            this.EnteredThePasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnteredThePasswordTextBox.Location = new System.Drawing.Point(226, 40);
            this.EnteredThePasswordTextBox.Name = "EnteredThePasswordTextBox";
            this.EnteredThePasswordTextBox.Size = new System.Drawing.Size(130, 27);
            this.EnteredThePasswordTextBox.TabIndex = 3;
            this.EnteredThePasswordTextBox.UseWaitCursor = true;
            // 
            // AddTheNewUserButton
            // 
            this.AddTheNewUserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddTheNewUserButton.Location = new System.Drawing.Point(375, 10);
            this.AddTheNewUserButton.Name = "AddTheNewUserButton";
            this.AddTheNewUserButton.Size = new System.Drawing.Size(163, 27);
            this.AddTheNewUserButton.TabIndex = 4;
            this.AddTheNewUserButton.Text = "Add the new user";
            this.AddTheNewUserButton.UseCompatibleTextRendering = true;
            this.AddTheNewUserButton.UseVisualStyleBackColor = true;
            this.AddTheNewUserButton.Click += new System.EventHandler(this.AddTheNewUserButton_Click);
            // 
            // DropTheNewUserButton
            // 
            this.DropTheNewUserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DropTheNewUserButton.Location = new System.Drawing.Point(375, 40);
            this.DropTheNewUserButton.Name = "DropTheNewUserButton";
            this.DropTheNewUserButton.Size = new System.Drawing.Size(163, 27);
            this.DropTheNewUserButton.TabIndex = 5;
            this.DropTheNewUserButton.Text = "Drop the new user";
            this.DropTheNewUserButton.UseCompatibleTextRendering = true;
            this.DropTheNewUserButton.UseVisualStyleBackColor = true;
            this.DropTheNewUserButton.Click += new System.EventHandler(this.DropTheNewUserButton_Click);
            // 
            // SelectTableLabel
            // 
            this.SelectTableLabel.AutoSize = true;
            this.SelectTableLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectTableLabel.Location = new System.Drawing.Point(20, 73);
            this.SelectTableLabel.Name = "SelectTableLabel";
            this.SelectTableLabel.Size = new System.Drawing.Size(97, 20);
            this.SelectTableLabel.TabIndex = 6;
            this.SelectTableLabel.Text = "Select table";
            // 
            // SelectedTableComboBox
            // 
            this.SelectedTableComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectedTableComboBox.FormattingEnabled = true;
            this.SelectedTableComboBox.Items.AddRange(new object[] {
            "Employeers",
            "ChildrenOfEmployeers",
            "Gifts"});
            this.SelectedTableComboBox.Location = new System.Drawing.Point(226, 70);
            this.SelectedTableComboBox.Name = "SelectedTableComboBox";
            this.SelectedTableComboBox.Size = new System.Drawing.Size(130, 28);
            this.SelectedTableComboBox.TabIndex = 7;
            // 
            // gifts_for_children_of_employeesDataSet
            // 
            this.gifts_for_children_of_employeesDataSet.DataSetName = "Gifts_for_children_of_employeesDataSet";
            this.gifts_for_children_of_employeesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // giftsforchildrenofemployeesDataSetBindingSource
            // 
            this.giftsforchildrenofemployeesDataSetBindingSource.DataSource = this.gifts_for_children_of_employeesDataSet;
            this.giftsforchildrenofemployeesDataSetBindingSource.Position = 0;
            // 
            // SelectedOperationComboBox
            // 
            this.SelectedOperationComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectedOperationComboBox.FormattingEnabled = true;
            this.SelectedOperationComboBox.Items.AddRange(new object[] {
            "INSERT",
            "UPDATE",
            "DELETE"});
            this.SelectedOperationComboBox.Location = new System.Drawing.Point(226, 102);
            this.SelectedOperationComboBox.Name = "SelectedOperationComboBox";
            this.SelectedOperationComboBox.Size = new System.Drawing.Size(130, 28);
            this.SelectedOperationComboBox.TabIndex = 9;
            // 
            // SelectOperationLabel
            // 
            this.SelectOperationLabel.AutoSize = true;
            this.SelectOperationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectOperationLabel.Location = new System.Drawing.Point(20, 105);
            this.SelectOperationLabel.Name = "SelectOperationLabel";
            this.SelectOperationLabel.Size = new System.Drawing.Size(130, 20);
            this.SelectOperationLabel.TabIndex = 8;
            this.SelectOperationLabel.Text = "Select operation";
            // 
            // GrantUserRightButton
            // 
            this.GrantUserRightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GrantUserRightButton.Location = new System.Drawing.Point(375, 71);
            this.GrantUserRightButton.Name = "GrantUserRightButton";
            this.GrantUserRightButton.Size = new System.Drawing.Size(163, 27);
            this.GrantUserRightButton.TabIndex = 10;
            this.GrantUserRightButton.Text = "Grant user right";
            this.GrantUserRightButton.UseCompatibleTextRendering = true;
            this.GrantUserRightButton.UseVisualStyleBackColor = true;
            this.GrantUserRightButton.Click += new System.EventHandler(this.GrantUserRightButton_Click);
            // 
            // DenyUserRightButton
            // 
            this.DenyUserRightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DenyUserRightButton.Location = new System.Drawing.Point(375, 104);
            this.DenyUserRightButton.Name = "DenyUserRightButton";
            this.DenyUserRightButton.Size = new System.Drawing.Size(163, 27);
            this.DenyUserRightButton.TabIndex = 11;
            this.DenyUserRightButton.Text = "Deny user right";
            this.DenyUserRightButton.UseCompatibleTextRendering = true;
            this.DenyUserRightButton.UseVisualStyleBackColor = true;
            this.DenyUserRightButton.Click += new System.EventHandler(this.DenyUserRightButton_Click);
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=Gifts_for_children_of_employees;" +
    "Integrated Security=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // addTheNewUserSqlCommand
            // 
            this.addTheNewUserSqlCommand.CommandText = "add_the_new_user";
            this.addTheNewUserSqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            this.addTheNewUserSqlCommand.Connection = this.sqlConnection1;
            this.addTheNewUserSqlCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@login", System.Data.SqlDbType.VarChar),
            new System.Data.SqlClient.SqlParameter("@password", System.Data.SqlDbType.VarChar)});
            // 
            // dropTheNewUserSqlCommand
            // 
            this.dropTheNewUserSqlCommand.CommandText = "drop_the_new_user";
            this.dropTheNewUserSqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            this.dropTheNewUserSqlCommand.Connection = this.sqlConnection1;
            this.dropTheNewUserSqlCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@login", System.Data.SqlDbType.VarChar)});
            // 
            // grantUserRightSqlCommand
            // 
            this.grantUserRightSqlCommand.CommandText = "grant_user_right";
            this.grantUserRightSqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            this.grantUserRightSqlCommand.Connection = this.sqlConnection1;
            this.grantUserRightSqlCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@right", System.Data.SqlDbType.VarChar),
            new System.Data.SqlClient.SqlParameter("@table", System.Data.SqlDbType.VarChar),
            new System.Data.SqlClient.SqlParameter("@login", System.Data.SqlDbType.VarChar)});
            // 
            // denyUserRightSqlCommand
            // 
            this.denyUserRightSqlCommand.CommandText = "deny_user_right";
            this.denyUserRightSqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            this.denyUserRightSqlCommand.Connection = this.sqlConnection1;
            this.denyUserRightSqlCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@right", System.Data.SqlDbType.VarChar),
            new System.Data.SqlClient.SqlParameter("@table", System.Data.SqlDbType.VarChar),
            new System.Data.SqlClient.SqlParameter("@login", System.Data.SqlDbType.VarChar)});
            // 
            // FormAdministrationPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 153);
            this.Controls.Add(this.DenyUserRightButton);
            this.Controls.Add(this.GrantUserRightButton);
            this.Controls.Add(this.SelectedOperationComboBox);
            this.Controls.Add(this.SelectOperationLabel);
            this.Controls.Add(this.SelectedTableComboBox);
            this.Controls.Add(this.SelectTableLabel);
            this.Controls.Add(this.DropTheNewUserButton);
            this.Controls.Add(this.AddTheNewUserButton);
            this.Controls.Add(this.EnteredThePasswordTextBox);
            this.Controls.Add(this.EnteredLoginOfTheUserTextBox);
            this.Controls.Add(this.EnterThePassword);
            this.Controls.Add(this.EnterLoginOfTheUser);
            this.Name = "FormAdministrationPanel";
            this.Text = "Administration Panel";
            ((System.ComponentModel.ISupportInitialize)(this.gifts_for_children_of_employeesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giftsforchildrenofemployeesDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EnterLoginOfTheUser;
        private System.Windows.Forms.Label EnterThePassword;
        private System.Windows.Forms.TextBox EnteredLoginOfTheUserTextBox;
        private System.Windows.Forms.TextBox EnteredThePasswordTextBox;
        private System.Windows.Forms.Button AddTheNewUserButton;
        private System.Windows.Forms.Button DropTheNewUserButton;
        private System.Windows.Forms.Label SelectTableLabel;
        private System.Windows.Forms.ComboBox SelectedTableComboBox;
        private System.Windows.Forms.BindingSource giftsforchildrenofemployeesDataSetBindingSource;
        private Gifts_for_children_of_employeesDataSet gifts_for_children_of_employeesDataSet;
        private System.Windows.Forms.ComboBox SelectedOperationComboBox;
        private System.Windows.Forms.Label SelectOperationLabel;
        private System.Windows.Forms.Button GrantUserRightButton;
        private System.Windows.Forms.Button DenyUserRightButton;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand addTheNewUserSqlCommand;
        private System.Data.SqlClient.SqlCommand dropTheNewUserSqlCommand;
        private System.Data.SqlClient.SqlCommand grantUserRightSqlCommand;
        private System.Data.SqlClient.SqlCommand denyUserRightSqlCommand;
    }
}