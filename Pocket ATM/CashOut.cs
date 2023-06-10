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
    public partial class CashOut : Form
    {
        public CashOut()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Home h1 = new Home();
            h1.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

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
            balancelbl.Text = "$ " + dt.Rows[0][0].ToString();
            bal = Convert.ToInt32(dt.Rows[0][0].ToString());
            conn.Close();
        }

        private void CashOut_Load(object sender, EventArgs e)
        {
            getbalance();

        }
        int amount1=500, amount2 = 1000, amount3 = 5000, amount4 = 10000, amount5 = 15000, amount6 = 20000;
        private void addTransaction1()
        {
            string transType = "WITHDRAW";

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into TransactionTable values (@AccNum,@Type,@Amount,@UDate)", conn);
                cmd.Parameters.AddWithValue("@AccNum", Acc);
                cmd.Parameters.AddWithValue("@Type", transType);
                cmd.Parameters.AddWithValue("@Amount", amount1);
                cmd.Parameters.AddWithValue("@UDate", DateTime.Today.Date.ToString());

                cmd.ExecuteNonQuery();
                conn.Close();


            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void addTransaction2()
        {
            string transType = "WITHDRAW";

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into TransactionTable values (@AccNum,@Type,@Amount,@UDate)", conn);
                cmd.Parameters.AddWithValue("@AccNum", Acc);
                cmd.Parameters.AddWithValue("@Type", transType);
                cmd.Parameters.AddWithValue("@Amount", amount2);
                cmd.Parameters.AddWithValue("@UDate", DateTime.Today.Date.ToString());

                cmd.ExecuteNonQuery();
                conn.Close();


            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void addTransaction3()
        {
            string transType = "WITHDRAW";

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into TransactionTable values (@AccNum,@Type,@Amount,@UDate)", conn);
                cmd.Parameters.AddWithValue("@AccNum", Acc);
                cmd.Parameters.AddWithValue("@Type", transType);
                cmd.Parameters.AddWithValue("@Amount", amount3);
                cmd.Parameters.AddWithValue("@UDate", DateTime.Today.Date.ToString());

                cmd.ExecuteNonQuery();
                conn.Close();


            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void addTransaction4()
        {
            string transType = "WITHDRAW";

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into TransactionTable values (@AccNum,@Type,@Amount,@UDate)", conn);
                cmd.Parameters.AddWithValue("@AccNum", Acc);
                cmd.Parameters.AddWithValue("@Type", transType);
                cmd.Parameters.AddWithValue("@Amount", amount4);
                cmd.Parameters.AddWithValue("@UDate", DateTime.Today.Date.ToString());

                cmd.ExecuteNonQuery();
                conn.Close();


            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void addTransaction5()
        {
            string transType = "WITHDRAW";

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into TransactionTable values (@AccNum,@Type,@Amount,@UDate)", conn);
                cmd.Parameters.AddWithValue("@AccNum", Acc);
                cmd.Parameters.AddWithValue("@Type", transType);
                cmd.Parameters.AddWithValue("@Amount", amount5);
                cmd.Parameters.AddWithValue("@UDate", DateTime.Today.Date.ToString());

                cmd.ExecuteNonQuery();
                conn.Close();


            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void addTransaction6()
        {
            string transType = "WITHDRAW";

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into TransactionTable values (@AccNum,@Type,@Amount,@UDate)", conn);
                cmd.Parameters.AddWithValue("@AccNum", Acc);
                cmd.Parameters.AddWithValue("@Type", transType);
                cmd.Parameters.AddWithValue("@Amount", amount6);
                cmd.Parameters.AddWithValue("@UDate", DateTime.Today.Date.ToString());

                cmd.ExecuteNonQuery();
                conn.Close();


            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (bal < 1000)
            {
                MessageBox.Show(" Balance Can not be Negative!! ");
            }
            else
            {
                newBalance = bal - 1000;
                try
                {
                    conn.Open();
                    string query = "update AccountTable set Balance =" + newBalance + "where AccNum=" + Acc + "";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(" Withdrawal Successfull !!");
                    conn.Close();

                    addTransaction2();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (bal < 5000)
            {
                MessageBox.Show(" Balance Can not be Negative!! ");
            }
            else
            {
                newBalance = bal - 5000;
                try
                {
                    conn.Open();
                    string query = "update AccountTable set Balance =" + newBalance + "where AccNum=" + Acc + "";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(" Withdrawal Successfull !!");
                    conn.Close();

                    addTransaction3();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (bal < 10000)
            {
                MessageBox.Show(" Balance Can not be Negative!! ");
            }
            else
            {
                newBalance = bal - 10000;
                try
                {
                    conn.Open();
                    string query = "update AccountTable set Balance =" + newBalance + "where AccNum=" + Acc + "";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(" Withdrawal Successfull !!");
                    conn.Close();

                    addTransaction4();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (bal < 15000)
            {
                MessageBox.Show(" Balance Can not be Negative!! ");
            }
            else
            {
                newBalance = bal - 15000;
                try
                {
                    conn.Open();
                    string query = "update AccountTable set Balance =" + newBalance + "where AccNum=" + Acc + "";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(" Withdrawal Successfull !!");
                    conn.Close();

                    addTransaction5();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (bal < 20000)
            {
                MessageBox.Show(" Balance Can not be Negative!! ");
            }
            else
            {
                newBalance = bal - 20000;
                try
                {
                    conn.Open();
                    string query = "update AccountTable set Balance =" + newBalance + "where AccNum=" + Acc + "";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(" Withdrawal Successfull !!");
                    conn.Close();

                    addTransaction6();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bal < 500)
            {
                MessageBox.Show(" Balance Can not be Negative!! ");
            }
            else
            {
                newBalance = bal - 500;
                try
                {
                    conn.Open();
                    string query = "update AccountTable set Balance =" + newBalance + "where AccNum=" + Acc + "";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(" Withdrawal Successfull !!");
                    conn.Close();

                    addTransaction1();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        
    }
}
