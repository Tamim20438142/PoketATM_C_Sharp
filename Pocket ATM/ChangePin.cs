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
    public partial class ChangePin : Form
    {
        public ChangePin()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
        SqlConnection conn = new SqlConnection("Data Source=DEPRESHAWNISON\\SQLEXPRESS;Initial Catalog=ATMdb;Integrated Security=True");
        string Acc = Login.AccNumber;


        private void button1_Click(object sender, EventArgs e)
        {
            if (Pin1tb.Text == "" || Pin2tb.Text == "")
            {
                MessageBox.Show("Please, Enter Pin !!");
            }
            else if (Pin2tb.Text!=Pin1tb.Text)
            {
                MessageBox.Show("Pin Numbers do not Match");
            }
            else
            {
                try
                {
                    conn.Open();
                    string query = "update AccountTable set Pin =" + Pin1tb.Text + "where AccNum=" + Acc + "";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Pin Updated!!");

                    conn.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
