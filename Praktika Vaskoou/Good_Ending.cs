﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktika_Vaskoou
{
    public partial class Good_Ending : Form
    {
        public Good_Ending()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 mainMenu = new Form1();
            mainMenu.Show();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            EndingTracker.Endings[1] = true;
            //EndingTracker.UnlockEnding(1);
            Form1 mainMenu = new Form1();
            mainMenu.Show();
            this.Close();
        }
    }
}
