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
    public partial class Follow_Gogi : Form
    {
        public Follow_Gogi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EndingTracker.Endings[3] = true;
            //EndingTracker.UnlockEnding(3);
            Form1 mainMenu = new Form1();
            mainMenu.Show();
            this.Close();
        }
    }
}
