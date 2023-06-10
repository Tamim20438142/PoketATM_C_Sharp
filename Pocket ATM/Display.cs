using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Pocket_ATM
{
    public partial class Display : Form
    {
        public Display()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DEPRESHAWNISON\\SQLEXPRESS;Initial Catalog=ATMdb;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from AccountTable", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            da.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }
    }
}
