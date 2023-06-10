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
    public partial class adLogin : Form
    {
        public adLogin()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        SqlConnection conn = new SqlConnection("Data Source=DEPRESHAWNISON\\SQLEXPRESS;Initial Catalog=ATMdb;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            /* conn.Open();
             SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select count(*) from AdministrationTable where AdminId=" + AdminTb.Text + "and AdminPin=" + PinTb.Text + "", conn);
             DataTable dataTable = new DataTable();
             sqlDataAdapter.Fill(dataTable);

             if (dataTable.Rows[0][0].ToString() == "1")
             {
                 Admin ad1 = new Admin();
                 ad1.Show();
                 this.Hide();
                 conn.Close();
             }
             else
             {
                 MessageBox.Show("Please, Input Valid ID OR Pin!! ");
                 AdminTb.Focus();
             }
             conn.Close();*/




            string query = "Select * from AdministrationTable Where AdminId = '" + AdminTb.Text.Trim() + "' and AdminPin = '" + PinTb.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                MessageBox.Show("Admin Login");
                Admin ad1 = new Admin();
                ad1.Show();
                this.Hide();
                conn.Close();
            }
            else
            {
                MessageBox.Show("Check your username and password");
            }


        }

        private void PinTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void AccNumTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
