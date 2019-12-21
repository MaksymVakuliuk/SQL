using System;
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

        private void employeersWithChildrenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_procedure_employeers_with_children form_procedure_employeers_with_children = new Form_procedure_employeers_with_children();
            form_procedure_employeers_with_children.Show();
        }

        private void childsWithGiftsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_procedure_children_with_gift form_Procedure_Children_With_Gift = new Form_procedure_children_with_gift();
            form_Procedure_Children_With_Gift.Show();
        }

        private void employeersWithAdultChildrenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_procedure_employeers_with_edult_children form_Procedure_Employeers_With_Edult_Children = new Form_procedure_employeers_with_edult_children();
            form_Procedure_Employeers_With_Edult_Children.Show();
        }

        private void giftvaluemoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_procedure_gifts_value_more form_Procedure_Gifts_Value_More = new Form_procedure_gifts_value_more();
            form_Procedure_Gifts_Value_More.Show();
        }

        private void администрированиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdministrationPanel formAdministrationPanel = new FormAdministrationPanel();
            formAdministrationPanel.Show();
        }
    }
}
