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
    public partial class Dark_Path_2 : Form
    {
        public Dark_Path_2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dark_Path_Cont darkPathCont = new Dark_Path_Cont();
            darkPathCont.Show();
            this.Close();
        }
    }
}
