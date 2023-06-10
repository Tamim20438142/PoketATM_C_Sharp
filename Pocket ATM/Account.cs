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
    public partial class Account : Form
    {
        public Account()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        SqlConnection s1 = new SqlConnection("Data Source=DEPRESHAWNISON\\SQLEXPRESS;Initial Catalog=ATMdb;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            int balance= 0;
            if (AccNumTb.Text == "" || AccFnametb.Text == "" || Acclnametb.Text == "" || PhoneTb.Text == "" || Addresstb.Text == "" || Occupationtb.Text == "" || Mailtb.Text == "" || pinTb.Text=="")
            {
                MessageBox.Show("Please, Input All the Informations.");
            }
            else
            {
                try
                {
                        /*s1.Open();
                        string query = " insert into AccountTable values("+AccNumTb.Text+","+AccFnametb.Text+","+Acclnametb.Text+","+dobdate.Value.Date+","+PhoneTb.Text+","+Addresstb.Text+","+Occupationtb.Text+","+balance+","+ Mailtb.Text + ")";

                    SqlCommand cmd = new SqlCommand(query, s1);
                    cmd.ExecuteNonQuery();
                    s1.Close();
                    MessageBox.Show(" Account Registered!! Success !!");

                        */

                    SqlConnection conn = new SqlConnection("Data Source=DEPRESHAWNISON\\SQLEXPRESS;Initial Catalog=ATMdb;Integrated Security=True");
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("insert into AccountTable values (@AccNum,@FirstName,@LastName,@Dob, @Phone, @Address, @Occupation,@Balance ,@Mail,@Pin)", conn);
                    cmd.Parameters.AddWithValue("@AccNum", AccNumTb.Text);
                    cmd.Parameters.AddWithValue("@FirstName", AccFnametb.Text);
                    cmd.Parameters.AddWithValue("@LastName", Acclnametb.Text);
                    cmd.Parameters.AddWithValue("@Dob", dobdate.Value.Date);
                    cmd.Parameters.AddWithValue("@Phone", PhoneTb.Text);
                    cmd.Parameters.AddWithValue("@Address", Addresstb.Text);
                    cmd.Parameters.AddWithValue("@Occupation", Occupationtb.Text);
                    cmd.Parameters.AddWithValue("@Balance",balance);
                    cmd.Parameters.AddWithValue("@Mail", Mailtb.Text);
                    cmd.Parameters.AddWithValue("@Pin", pinTb.Text);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show(" Account Registered!! Success !!");

                    Login log=new Login();
                    log.Show();
                    this.Hide();
                    
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }

        }

        private void label11_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }
    }
}
