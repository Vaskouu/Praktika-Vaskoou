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
    public partial class Stay_Hidden_After_Nedi : Form
    {
        public Stay_Hidden_After_Nedi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EndingTracker.Endings[6] = true;
            //EndingTracker.UnlockEnding(5);
            Form1 mainMenu = new Form1();
            mainMenu.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
