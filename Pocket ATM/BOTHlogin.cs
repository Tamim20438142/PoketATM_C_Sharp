using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pocket_ATM
{
    public partial class BOTHlogin : Form
    {
        public BOTHlogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login login=new Login();
            login.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            adLogin ad = new adLogin();
            ad.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Menu m1=new Menu();
            m1.Show();
            this.Hide();
        }
    }
}
