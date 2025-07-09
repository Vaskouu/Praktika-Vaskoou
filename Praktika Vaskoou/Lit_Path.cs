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
    public partial class Lit_Path : Form
    {
        public Lit_Path()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Playground playgroundForm = new Playground();
            playgroundForm.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dark_Path_2 darkPath = new Dark_Path_2();
            darkPath.Show();
            this.Close();
        }
    }
}
