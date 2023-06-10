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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }
        public static string AccNumber;

        private void button6_Click(object sender, EventArgs e)
        {
            Balance b1 = new Balance();
            b1.Show();
            this.Hide();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            AccNumber = Login.AccNumber;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Deposit d1=new Deposit();
            d1.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ChangePin C1=new ChangePin();
            C1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Withdraw w1 = new Withdraw();
            w1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CashOut c1 = new CashOut();
            c1.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Statement s = new Statement();
            s.Show();
            this.Hide();

        }
    }
}
