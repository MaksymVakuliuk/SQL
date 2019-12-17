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

        private void Filter_by_last_name_button_Click(object sender, EventArgs e)
        {
           
        }

        private void Filter_by_First_Name_button_Click(object sender, EventArgs e)
        {

        }

        private void Filter_by_Petronymic_button_Click(object sender, EventArgs e)
        {

        }

        private void Filter_by_Position_button_Click(object sender, EventArgs e)
        {

        }

        private void Filter_by_Department_button_Click(object sender, EventArgs e)
        {

        }

        private void Filter_by_Hirring_date_button_Click(object sender, EventArgs e)
        {

        }

        private void Drop_filter_button_Click(object sender, EventArgs e)
        {

        }
    }
}
