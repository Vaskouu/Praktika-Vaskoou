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
    public partial class secret_ending : Form
    {
        public secret_ending()
        {
            InitializeComponent();
        }

        private void secret_ending_Load(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Interval = 3000; // 3 seconds
            timer.Tick += Timer_Tick; // Attach event handler
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            var timer = (Timer)sender;
            timer.Stop();
            Application.Exit(); 
        }
    }
}
