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
    public partial class Dead_End : Form
    {
        public Dead_End()
        {
            InitializeComponent();
        }

        private void Dead_End_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EndingTracker.Endings[5] = true;
            //EndingTracker.UnlockEnding(3);
            Form1 mainMenu = new Form1();
            mainMenu.Show();
            this.Close();
        }
    }
}
