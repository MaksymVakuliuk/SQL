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
    public partial class FormGifts : Form
    {
        public FormGifts()
        {
            InitializeComponent();
        }

        private void FormGifts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gifts_for_children_of_employeesDataSet.ChildrenOfEmployeers' table. You can move, or remove it, as needed.
            this.childrenOfEmployeersTableAdapter.Fill(this.gifts_for_children_of_employeesDataSet.ChildrenOfEmployeers);
            // TODO: This line of code loads data into the 'gifts_for_children_of_employeesDataSet.Gifts' table. You can move, or remove it, as needed.
            this.giftsTableAdapter.Fill(this.gifts_for_children_of_employeesDataSet.Gifts);

        }

    }
}
