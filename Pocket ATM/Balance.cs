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
    public partial class Balance : Form
    {
        public Balance()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        SqlConnection conn = new SqlConnection("Data Source=DEPRESHAWNISON\\SQLEXPRESS;Initial Catalog=ATMdb;Integrated Security=True");

        private void getbalance() 
        {
            conn.Open();
            SqlDataAdapter b1 = new SqlDataAdapter(" select Balance from AccountTable where AccNum="+ Accnumtb.Text+"",conn);
            DataTable dt = new DataTable();
            b1.Fill(dt);
            Balancetb.Text="$ "+dt.Rows[0][0].ToString();
            conn.Close();
        }
        private void Balance_Load(object sender, EventArgs e)
        {
            Accnumtb.Text = Home.AccNumber;
            getbalance();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void AccNumbertb_Click(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Home h1 = new Home();
            h1.Show();
            this.Hide();
        }

        private void Accnumtb_Click(object sender, EventArgs e)
        {
        }
    }
}
