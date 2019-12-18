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
    public partial class Form_procedure_employeers_with_edult_children : Form
    {
        public Form_procedure_employeers_with_edult_children()
        {
            InitializeComponent();
        }

        private void Form_procedure_employeers_with_edult_children_Load(object sender, EventArgs e)
        {

        }

        private void Fulfill_the_request_button_Click(object sender, EventArgs e)
        {
            sqlConnection1.Open();
            sqlCommand1.ExecuteNonQuery();
            DataTable data = new DataTable();
            sqlDataAdapter1.Fill(data);
            dataGridView1.DataSource = data;
            sqlConnection1.Close();
        }

    }
}
