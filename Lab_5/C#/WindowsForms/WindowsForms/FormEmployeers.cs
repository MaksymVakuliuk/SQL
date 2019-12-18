using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class FormEmployeers : Form
    {
        public FormEmployeers()
        {
            InitializeComponent();
        }

        private void FormEmployeers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gifts_for_children_of_employeesDataSet.Employeers' table. You can move, or remove it, as needed.
            this.employeersTableAdapter.Fill(this.gifts_for_children_of_employeesDataSet.Employeers);

        }

       
        private void Update_Button_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeersBindingSource.EndEdit();
            this.employeersTableAdapter.Update(this.gifts_for_children_of_employeesDataSet.Employeers);
        }

        private void Filter_by_Last_Name_button_Click(object sender, EventArgs e)
        {
            int dd = dataGridView1.CurrentCell.RowIndex;
            employeersBindingSource.Filter = " LastName = '" + dataGridView1[1, dd].Value + "'";
        }

        private void Filter_by_First_Name_button_Click(object sender, EventArgs e)
        {
            int dd = dataGridView1.CurrentCell.RowIndex;
            employeersBindingSource.Filter = " FirstName = '" + dataGridView1[2,dd].Value +"'";
        }

        private void Filter_by_Patronymic_button_Click(object sender, EventArgs e)
        {
            int dd = dataGridView1.CurrentCell.RowIndex;
            employeersBindingSource.Filter = " Patronymic = '" + dataGridView1[3, dd].Value + "'";
        }

        private void Filter_by_Position_button_Click(object sender, EventArgs e)
        {
            int dd = dataGridView1.CurrentCell.RowIndex;
            employeersBindingSource.Filter = " Position  = '" + dataGridView1[4,dd].Value + "'";
        }

        private void Filter_by_Department_button_Click(object sender, EventArgs e)
        {
            int dd = dataGridView1.CurrentCell.RowIndex;
            employeersBindingSource.Filter = " Department = '" + dataGridView1[5, dd].Value + "'";
        }

        private void Filter_by_Hiring_date_button_Click(object sender, EventArgs e)
        {
            int dd = dataGridView1.CurrentCell.RowIndex;
            employeersBindingSource.Filter = " Hiring_date = '" + dataGridView1[6, dd].Value + "'";
        }

        private void Drop_filter_button_Click(object sender, EventArgs e)
        {
            employeersBindingSource.Filter = "";
        }
    }
}
