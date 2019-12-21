using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class FormAdministrationPanel : Form
    {
        public FormAdministrationPanel()
        {
            InitializeComponent();
        }

        private void AddTheNewUserButton_Click(object sender, EventArgs e)
        {
            bool error = false;
            try
            { 
                addTheNewUserSqlCommand.Parameters["@login"].Value = EnteredLoginOfTheUserTextBox.Text;
                addTheNewUserSqlCommand.Parameters["@password"].Value = EnteredThePasswordTextBox.Text;
                sqlConnection1.Open();
                addTheNewUserSqlCommand.ExecuteNonQuery();
                sqlConnection1.Close();
            }
            catch (SqlException) 
            {
                MessageBox.Show("Unable to add user");
                error = true;
            }
            if (!error)
            {
                MessageBox.Show("User \"" + EnteredLoginOfTheUserTextBox.Text + "\" added");
                EnteredLoginOfTheUserTextBox.Text = "";
                EnteredThePasswordTextBox.Text = "";
            }
        }

        private void DropTheNewUserButton_Click(object sender, EventArgs e)
        {
            bool error = false;
            try
            {
                dropTheNewUserSqlCommand.Parameters["@login"].Value = EnteredLoginOfTheUserTextBox.Text;
                sqlConnection1.Open();
                dropTheNewUserSqlCommand.ExecuteNonQuery();
                sqlConnection1.Close();
            }
            catch (SqlException)
            {
                MessageBox.Show("Unable to drop user");
                error = true;
            }
            if (!error)
            {
                MessageBox.Show("User \"" + EnteredLoginOfTheUserTextBox.Text + "\" droped");
                EnteredLoginOfTheUserTextBox.Text = "";
            }
        }

        private void GrantUserRightButton_Click(object sender, EventArgs e)
        {
            bool error = false;
            try
            {
                grantUserRightSqlCommand.Parameters["@login"].Value = EnteredLoginOfTheUserTextBox.Text;
                grantUserRightSqlCommand.Parameters["@right"].Value = SelectedOperationComboBox.Text;  
                grantUserRightSqlCommand.Parameters["@table"].Value = SelectedTableComboBox.Text;
                sqlConnection1.Open();
                grantUserRightSqlCommand.ExecuteNonQuery();
                sqlConnection1.Close();
            }
            catch (SqlException)
            {
                MessageBox.Show("Unable to grant right");
                error = true;
            }
            if (!error)
            {
                MessageBox.Show("Granted \"" + SelectedOperationComboBox.Text + "\" on table \""+ SelectedTableComboBox.Text + "\" to \"" + EnteredLoginOfTheUserTextBox.Text);
                EnteredLoginOfTheUserTextBox.Text = "";
                SelectedOperationComboBox.Text = "";
                SelectedTableComboBox.Text = "";
            }
        }

        private void DenyUserRightButton_Click(object sender, EventArgs e)
        {
            bool error = false;
            try
            {
                denyUserRightSqlCommand.Parameters["@login"].Value = EnteredLoginOfTheUserTextBox.Text;
                denyUserRightSqlCommand.Parameters["@right"].Value = SelectedOperationComboBox.Text;  
                denyUserRightSqlCommand.Parameters["@table"].Value = SelectedTableComboBox.Text;
                sqlConnection1.Open();
                denyUserRightSqlCommand.ExecuteNonQuery();
                sqlConnection1.Close();
            }
            catch (SqlException)
            {
                MessageBox.Show("Unable to deny right");
                error = true;
            }
            if (!error)
            {
                MessageBox.Show("Denhy \"" + SelectedOperationComboBox.Text + "\" on table \""+ SelectedTableComboBox.Text + "\" to \"" + EnteredLoginOfTheUserTextBox.Text);
                EnteredLoginOfTheUserTextBox.Text = "";
                SelectedOperationComboBox.Text = "";
                SelectedTableComboBox.Text = "";
            }
        }
    }
}
