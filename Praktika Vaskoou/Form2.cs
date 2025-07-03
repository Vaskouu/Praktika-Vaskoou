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
    public partial class Settings_frm : Form
    {
        public Settings_frm()
        {
            InitializeComponent();
        }


        private void Music_Load(object sender, EventArgs e)
        {
                
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        ControlPaint.DrawBorder(e.Graphics, panel1.ClientRectangle,
        Color.Black, 5, ButtonBorderStyle.Solid, // Left
        Color.Black, 5, ButtonBorderStyle.Solid, // Top
        Color.Black, 5, ButtonBorderStyle.Solid, // Right
        Color.Black, 5, ButtonBorderStyle.Solid); // Bottom
        }
        private void Settings_frm_Resize(object sender, EventArgs e)
        {
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;
        }
    }
}
