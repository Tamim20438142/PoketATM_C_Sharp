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
    public partial class Deposit : Form
    {
        public Deposit()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        SqlConnection conn = new SqlConnection("Data Source=DEPRESHAWNISON\\SQLEXPRESS;Initial Catalog=ATMdb;Integrated Security=True");
        string Acc = Login.AccNumber;

        private void button1_Click(object sender, EventArgs e)
        {
            if(DepoAmtb.Text == "" || Convert.ToInt32(DepoAmtb.Text) <= 0)
            {
                MessageBox.Show("Please, Enter Amount !!");
            }
            else
            {
                newBalance=oldBlanace+Convert.ToInt32(DepoAmtb.Text);
                try
                {
                    conn.Open();
                    string query = "update AccountTable set Balance ="+newBalance+"where AccNum="+Acc+"";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Deposit Successfull!!");
                    conn.Close();
                    addTransaction();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
        int oldBlanace,newBalance;
        private void addTransaction() 
        {
            string transType = "DEPOSIT";

            try
            {
                SqlConnection conn = new SqlConnection("Data Source=DEPRESHAWNISON\\SQLEXPRESS;Initial Catalog=ATMdb;Integrated Security=True");
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into TransactionTable values (@AccNum,@Type,@Amount,@UDate)", conn);
                cmd.Parameters.AddWithValue("@AccNum", Acc);
                cmd.Parameters.AddWithValue("@Type", transType);
                cmd.Parameters.AddWithValue("@Amount", DepoAmtb.Text);
                cmd.Parameters.AddWithValue("@UDate", DateTime.Today.Date.ToString());
               
                cmd.ExecuteNonQuery();
                conn.Close();


            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

        }
        private void getbalance()
        {
            conn.Open();
            SqlDataAdapter b1 = new SqlDataAdapter(" select Balance from AccountTable where AccNum=" + Acc+ "", conn);
            DataTable dt = new DataTable();
            b1.Fill(dt);
            oldBlanace = Convert.ToInt32(dt.Rows[0][0].ToString());
            conn.Close();
        }

        private void Deposit_Load(object sender, EventArgs e)
        {
            getbalance();
        }
    }
}
