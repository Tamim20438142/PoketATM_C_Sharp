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
    public partial class Delete : Form
    {


        public Delete()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Hide();
        }

        SqlConnection conn = new SqlConnection("Data Source=DEPRESHAWNISON\\SQLEXPRESS;Initial Catalog=ATMdb;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {

            conn.Open();
            SqlCommand cmd = new SqlCommand("Delete AccountTable where AccNum  =@AccNum", conn);
            cmd.Parameters.AddWithValue("@AccNum", AccNumTb.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Delated successfully");

            conn.Close();




        }
    }
}
