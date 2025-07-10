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
    public partial class trust_gigi : Form
    {
        public trust_gigi()
        {
            InitializeComponent();
        }

        private void trust_gigi_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Good_Ending goodEndingForm = new Good_Ending();
            goodEndingForm.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Run_Away nextForm = new Run_Away();
            nextForm.Show();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
