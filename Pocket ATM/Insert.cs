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
    public partial class Insert : Form
    {
        public Insert()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Hide();
        }

        private void Occupationtb_TextChanged(object sender, EventArgs e)
        {

        }

        private void pinTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int balance = 0;
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
            cmd.Parameters.AddWithValue("@Balance", balance);
            cmd.Parameters.AddWithValue("@Mail", Mailtb.Text);
            cmd.Parameters.AddWithValue("@Pin", pinTb.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show(" Account Registered!! Success !!");
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dobdate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Mailtb_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void PhoneTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void Addresstb_TextChanged(object sender, EventArgs e)
        {

        }

        private void Acclnametb_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AccFnametb_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
