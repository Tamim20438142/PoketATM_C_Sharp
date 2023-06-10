﻿using System;
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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Insert insert = new Insert();
            insert.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Update update=new Update();
            update.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Delete delete = new Delete();
            delete.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Search search=new Search();
            search.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Display display = new Display();
            display.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
