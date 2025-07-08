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
    public partial class Continue_After_RunAway : Form
    {
        public Continue_After_RunAway()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stay_Hidden_After_Nedi nextForm = new Stay_Hidden_After_Nedi();
            nextForm.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Talk_To_Nedi talkForm = new Talk_To_Nedi();
            talkForm.Show();
            this.Close();
        }
    }
}
