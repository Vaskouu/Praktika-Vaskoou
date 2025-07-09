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
    public partial class Fight_Dimoff : Form
    {
        public Fight_Dimoff()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dark_Path_2 darkPath = new Dark_Path_2();
            darkPath.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dimoff_End ending4 = new Dimoff_End();
            ending4.Show();
            this.Close();
        }
    }
}
