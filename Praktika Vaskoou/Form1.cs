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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            level1 level1Form = new level1();
            level1Form.Show();
            this.Hide(); 

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Quit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void options_button_Click(object sender, EventArgs e)
        {
            Settings_frm settingsForm = new Settings_frm();
            settingsForm.Show();
            this.Hide();
        }
    }
}
