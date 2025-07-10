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
    public partial class ignore_gigi : Form
    {
        public ignore_gigi()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Lit_Path litPathForm = new Lit_Path();
            litPathForm.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dark_Path_After_Gigi nextForm = new Dark_Path_After_Gigi();
            nextForm.Show();
            this.Close();
        }
    }
}
