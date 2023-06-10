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
    public partial class Withdraw : Form
    {
        public Withdraw()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=DEPRESHAWNISON\\SQLEXPRESS;Initial Catalog=ATMdb;Integrated Security=True");
        string Acc = Login.AccNumber;
        int bal, newBalance;
        private void getbalance()
        {
            conn.Open();
            SqlDataAdapter b1 = new SqlDataAdapter(" select Balance from AccountTable where AccNum=" + Acc + "", conn);
            DataTable dt = new DataTable();
            b1.Fill(dt);
            Balancelbl.Text = "$ " + dt.Rows[0][0].ToString();
            bal= Convert.ToInt32(dt.Rows[0][0]);
            conn.Close();
        }
        private void addTransaction()
        {
            string transType = "WITHDRAW";

            try
            {
                SqlConnection conn = new SqlConnection("Data Source=DEPRESHAWNISON\\SQLEXPRESS;Initial Catalog=ATMdb;Integrated Security=True");
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into TransactionTable values (@AccNum,@Type,@Amount,@UDate)", conn);
                cmd.Parameters.AddWithValue("@AccNum", Acc);
                cmd.Parameters.AddWithValue("@Type", transType);
                cmd.Parameters.AddWithValue("@Amount", withdrawamt.Text);
                cmd.Parameters.AddWithValue("@UDate", DateTime.Today.Date.ToString());

                cmd.ExecuteNonQuery();
                conn.Close();


            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
            private void Withdraw_Load(object sender, EventArgs e)
        {
            getbalance();

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Home h1 = new Home();
            h1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (withdrawamt.Text=="")
            {
                MessageBox.Show(" Enter Amount ");
            }else if(Convert.ToInt32(withdrawamt.Text)<= 0)
            {
                MessageBox.Show("Enter a valid Amount ");
            }else if (Convert.ToInt32(withdrawamt.Text) > bal)
            {
                MessageBox.Show(" Balance is Negative !!");
            }
            else
            {
                try 
                {
                    newBalance = bal - Convert.ToInt32(withdrawamt.Text);
                    try
                    {
                        conn.Open();
                        string query = "update AccountTable set Balance =" + newBalance + "where AccNum=" + Acc + "";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show(" Withdrawal Successfull !!");
                        addTransaction();
                        conn.Close();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
