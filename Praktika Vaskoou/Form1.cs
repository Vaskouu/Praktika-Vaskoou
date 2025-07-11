using System;
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
        private int clickCount;
        private int clicksNeeded;
        private Label endingsLabel;


        public Form1()
        {
            InitializeComponent();
            InitializeEndingsLabel();
        }

        private void InitializeEndingsLabel()
        {
            Label lblEndings = new Label
            {
                Text = EndingTracker.GetDisplayText(),
                Font = new Font("Arial", 12),
                Location = new Point(20, 20),
                AutoSize = true
            };
            this.Controls.Add(lblEndings);
            var endingsCount = EndingTracker.Endings.Count(x => x);
            lblEndings.Text = $"Endings Unlocked: {endingsCount}/7";
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            clickCount++;   
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.BackColor = Color.FromArgb(20, 20, 20);

            if (clickCount >= clicksNeeded)
            {
                secret_ending secretForm = new secret_ending();
                secretForm.Show();
                this.Hide();
                clickCount = 0;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
          
        }



    }
}
