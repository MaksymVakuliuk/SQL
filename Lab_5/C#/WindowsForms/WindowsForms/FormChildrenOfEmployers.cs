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
    public partial class FormChildrenOfEmployers : Form
    {
        public FormChildrenOfEmployers()
        {
            InitializeComponent();
        }

        private void FormChildrenOfEmployers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gifts_for_children_of_employeesDataSet.ChildrenOfEmployeers' table. You can move, or remove it, as needed.
            this.childrenOfEmployeersTableAdapter.Fill(this.gifts_for_children_of_employeesDataSet.ChildrenOfEmployeers);

        }

        private void Update_Button_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.childrenOfEmployeersBindingSource.EndEdit();
            this.childrenOfEmployeersTableAdapter.Update(this.gifts_for_children_of_employeesDataSet.ChildrenOfEmployeers);
        }

        private void Filter_by_First_Name_button_Click(object sender, EventArgs e)
        {
            int dd = dataGridView1.CurrentCell.RowIndex;
            childrenOfEmployeersBindingSource.Filter = " FirstName = '" + dataGridView1[1, dd].Value + "'";
        }

        private void Filter_by_Date_of_birth_button_Click(object sender, EventArgs e)
        {
            int dd = dataGridView1.CurrentCell.RowIndex;
            childrenOfEmployeersBindingSource.Filter = " Date_of_birth = '" + dataGridView1[2, dd].Value + "'";
        }

        private void Drop_filter_button_Click(object sender, EventArgs e)
        {
            childrenOfEmployeersBindingSource.Filter = "";
        }
    }
}
