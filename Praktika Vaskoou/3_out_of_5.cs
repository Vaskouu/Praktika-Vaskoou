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
    public partial class _3_out_of_5 : Form
    {
        public _3_out_of_5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            EndingTracker.Endings[4] = true;
            //EndingTracker.UnlockEnding(4);
            Form1 mainMenu = new Form1();
            mainMenu.Show();
            this.Close();
        }
    }
}
