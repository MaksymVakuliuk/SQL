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
    public partial class Form_Gifts_for_children_of_employeers_DB : Form
    {
        public Form_Gifts_for_children_of_employeers_DB()
        {
            InitializeComponent();
        }

        private void FormGifts_for_children_of_employeers_Load(object sender, EventArgs e)
        {
           
            // TODO: This line of code loads data into the 'gifts_for_children_of_employeesDataSet.Gifts' table. You can move, or remove it, as needed.
            this.giftsTableAdapter.Fill(this.gifts_for_children_of_employeesDataSet.Gifts);
            // TODO: This line of code loads data into the 'gifts_for_children_of_employeesDataSet.ChildrenOfEmployeers' table. You can move, or remove it, as needed.
            this.childrenOfEmployeersTableAdapter.Fill(this.gifts_for_children_of_employeesDataSet.ChildrenOfEmployeers);
            // TODO: This line of code loads data into the 'gifts_for_children_of_employeesDataSet.Employeers' table. You can move, or remove it, as needed.
            this.employeersTableAdapter.Fill(this.gifts_for_children_of_employeesDataSet.Employeers);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Open_Form_Employeers_Click(object sender, EventArgs e)
        {
            FormEmployeers formEmployeers = new FormEmployeers();
            formEmployeers.Show();
        }

        private void Open_Form_ChildrenOfEmployeers_Click(object sender, EventArgs e)
        {
            FormChildrenOfEmployers formChildrenOfEmployers = new FormChildrenOfEmployers();
            formChildrenOfEmployers.Show();
        }

        private void Open_Form_Gifts_Click(object sender, EventArgs e)
        {
            FormGifts formGifts = new FormGifts();
            formGifts.Show();
        }

        private void employeers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void childrenOfEmployeers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
