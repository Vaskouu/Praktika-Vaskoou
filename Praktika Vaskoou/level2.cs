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
    public partial class level2 : Form
    {
        public level2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            trust_gigi trustGigiForm = new trust_gigi();
            trustGigiForm.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ignore_gigi ignoreEnding = new ignore_gigi();
            ignoreEnding.Show();
            this.Close();
        }
    }
}
