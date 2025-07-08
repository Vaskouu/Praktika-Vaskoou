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
    public partial class Run_Away : Form
    {
        public Run_Away()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Continue_After_RunAway nextForm = new Continue_After_RunAway();
            nextForm.Show();
            this.Close();
        }
    }
}
