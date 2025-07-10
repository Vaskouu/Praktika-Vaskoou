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
    public partial class Dark_Path_After_Gigi : Form
    {
        public Dark_Path_After_Gigi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Gogi1 gogi = new Gogi1();
            gogi.Show();
            this.Close();
        }
    }
}
