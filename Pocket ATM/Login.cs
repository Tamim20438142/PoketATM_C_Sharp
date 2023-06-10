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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Account acc= new Account();
            acc.Show();
            this.Hide();
        }
        public static string AccNumber;
        SqlConnection conn = new SqlConnection("Data Source=DEPRESHAWNISON\\SQLEXPRESS;Initial Catalog=ATMdb;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select count(*) from AccountTable where AccNum="+AccNumTb.Text+"and Pin="+PinTb.Text+"",conn);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            AccNumber = AccNumTb.Text;

            if (dataTable.Rows[0][0].ToString() == "1")
            {
                Home home = new Home(); 
                home.Show();
                this.Hide();
                conn.Close();
            }
            else
            {
                MessageBox.Show("Please, Input Valid Account Number OR Pin!! ");
                AccNumTb.Focus();
            }
            conn.Close();
        }

        private void PinTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
