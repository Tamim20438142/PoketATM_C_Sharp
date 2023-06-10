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
    public partial class Statement : Form
    {
        public Statement()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=DEPRESHAWNISON\\SQLEXPRESS;Initial Catalog=ATMdb;Integrated Security=True");
        string Acc = Login.AccNumber;

        private void State() 
        {
            conn.Open();
            string query = "select * from TransactionTable where AccNum=" + Acc;
            SqlDataAdapter sd=new SqlDataAdapter(query,conn);
            SqlCommandBuilder ss=new SqlCommandBuilder(sd);
            var dd = new DataSet();
            sd.Fill(dd);
            dataGridView1.DataSource=dd.Tables[0];


            conn.Close();
        }
        private void Statement_Load(object sender, EventArgs e)
        {
            State();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Home kk = new Home();
            kk.Show();
            this.Hide();
        }
    }
}
