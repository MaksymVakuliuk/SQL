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
    public partial class Form_procedure_gifts_value_more : Form
    {
        public Form_procedure_gifts_value_more()
        {
            InitializeComponent();
        }

        private void Fulfill_the_request_button_Click(object sender, EventArgs e)
        {
            DataTable data = new DataTable();
            sqlDataAdapter1.SelectCommand.Parameters["@Value"].Value = Convert.ToInt32(textBox1.Text);
            sqlDataAdapter1.Fill(data);
            dataGridView1.DataSource = data;
        }
    }
}
