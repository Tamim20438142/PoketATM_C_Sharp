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
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }

        private void AccNumTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int balance = 0;
            SqlConnection conn = new SqlConnection("Data Source=DEPRESHAWNISON\\SQLEXPRESS;Initial Catalog=ATMdb;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("Update AccountTable set FirstName= @FirstName,LastName=@LastName,Dob=@Dob,Address=@Address,Occupation=@Occupation,Mail=@Mail,Pin=@Pin where AccNum=@AccNum", conn);
            cmd.Parameters.AddWithValue("@AccNum", AccNumTb.Text);
            cmd.Parameters.AddWithValue("@FirstName", AccFnametb.Text);
            cmd.Parameters.AddWithValue("@LastName", Acclnametb.Text);
            cmd.Parameters.AddWithValue("@Dob", dobdate.Value.Date);
            cmd.Parameters.AddWithValue("@Phone", PhoneTb.Text);
            cmd.Parameters.AddWithValue("@Address", Addresstb.Text);
            cmd.Parameters.AddWithValue("@Occupation", Occupationtb.Text);
           // cmd.Parameters.AddWithValue("@Balance", balance);
            cmd.Parameters.AddWithValue("@Mail", Mailtb.Text);
            cmd.Parameters.AddWithValue("@Pin", pinTb.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show(" Account Updated!! Success !!");
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Hide();
        }
    }
}
