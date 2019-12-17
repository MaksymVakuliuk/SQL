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
            // TODO: This line of code loads data into the 'gifts_for_children_of_employeesDataSet.Employeers' table. You can move, or remove it, as needed.
            this.employeersTableAdapter.Fill(this.gifts_for_children_of_employeesDataSet.Employeers);
            // TODO: This line of code loads data into the 'gifts_for_children_of_employeesDataSet.ChildrenOfEmployeers' table. You can move, or remove it, as needed.
            this.childrenOfEmployeersTableAdapter.Fill(this.gifts_for_children_of_employeesDataSet.ChildrenOfEmployeers);
            // TODO: This line of code loads data into the 'gifts_for_children_of_employeesDataSet.ChildrenOfEmployeers' table. You can move, or remove it, as needed.
            this.childrenOfEmployeersTableAdapter.Fill(this.gifts_for_children_of_employeesDataSet.ChildrenOfEmployeers);

        }

    }
}
