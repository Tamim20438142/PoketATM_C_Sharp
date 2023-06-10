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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            BOTHlogin b=new BOTHlogin();
            b.Show();
            this.Hide();
        }
        int start = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            start += 1;
            Myprogress.Value = start;
            percent.Text = "" + start +"%";
            if (Myprogress.Value == 100)
            {
                Myprogress.Value = 0;
                timer1.Stop();
                BOTHlogin bb = new BOTHlogin();
                bb.Show();
                this.Hide();
            }
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
