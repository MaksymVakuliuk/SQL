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
            // TODO: This line of code loads data into the 'gifts_for_children_of_employeesDataSet.Gifts' table. You can move, or remove it, as needed.
            this.giftsTableAdapter.Fill(this.gifts_for_children_of_employeesDataSet.Gifts);
        }

        private void Update_Button_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.giftsBindingSource.EndEdit();
            this.giftsTableAdapter.Update(this.gifts_for_children_of_employeesDataSet.Gifts);
        }

        private void Filter_by_Gift_value_button_Click(object sender, EventArgs e)
        {
            int dd = dataGridView1.CurrentCell.RowIndex;
            giftsBindingSource.Filter = " Gift_value = '" + dataGridView1[1, dd].Value + "'";
        }

        private void Filter_by_Date_of_issue_button_Click(object sender, EventArgs e)
        {
            int dd = dataGridView1.CurrentCell.RowIndex;
            giftsBindingSource.Filter = " Date_of_issue = '" + dataGridView1[2, dd].Value + "'";
        }

        private void Drop_filter_button_Click(object sender, EventArgs e)
        {
            giftsBindingSource.Filter = "";
        }
    }
}
