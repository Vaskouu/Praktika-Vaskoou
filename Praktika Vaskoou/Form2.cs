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
        private object soundTrack;
        private object musicTrack;

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

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void mater_volume_Click(object sender, EventArgs e)
        {
            // Master Volume Slider
            TrackBar masterTrack = new TrackBar();
            masterTrack.Name = "master_track";
            masterTrack.Location = new Point(master_volume.Right + 20, master_volume.Top - 3);
            masterTrack.Size = new Size(200, 45);
            masterTrack.Minimum = 0;
            masterTrack.Maximum = 100;
            masterTrack.Value = 100;
            masterTrack.TickFrequency = 10;
            masterTrack.ValueChanged += VolumeTrack_ValueChanged;
            this.Controls.Add(masterTrack);

            // Music Volume Slider
            TrackBar musicTrack = new TrackBar();
            musicTrack.Name = "music_track";
            musicTrack.Location = new Point(music_volume.Right + 20, music_volume.Top - 3);
            musicTrack.Size = new Size(200, 45);
            musicTrack.Minimum = 0;
            musicTrack.Maximum = 100;
            musicTrack.Value = 80;
            musicTrack.TickFrequency = 10;
            musicTrack.ValueChanged += VolumeTrack_ValueChanged;
            this.Controls.Add(musicTrack);

            // Sound Volume Slider
            TrackBar soundTrack = new TrackBar();
            soundTrack.Name = "sound_track";
            soundTrack.Location = new Point(sound_volume.Right + 20, sound_volume.Top - 3);
            soundTrack.Size = new Size(200, 45);
            soundTrack.Minimum = 0;
            soundTrack.Maximum = 100;
            soundTrack.Value = 80;
            soundTrack.TickFrequency = 10;
            soundTrack.ValueChanged += VolumeTrack_ValueChanged;
            this.Controls.Add(soundTrack);
        }

        private void VolumeTrack_ValueChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();

        }

        private void UpdateAudioVolumes()
        {

        }

        private void music_volume_Click(object sender, EventArgs e)
        {

        }

        private void sound_volume_Click(object sender, EventArgs e)
        {

        }
    }
}
