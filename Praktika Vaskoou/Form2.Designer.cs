using System;

namespace Praktika_Vaskoou
{
    partial class Settings_frm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_opt = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.vlm_up = new System.Windows.Forms.Button();
            this.label_master_vlm = new System.Windows.Forms.Label();
            this.vlm_down = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_opt
            // 
            this.label_opt.AutoSize = true;
            this.label_opt.BackColor = System.Drawing.Color.Transparent;
            this.label_opt.Font = new System.Drawing.Font("Rockwell Extra Bold", 39.92727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_opt.Location = new System.Drawing.Point(424, 9);
            this.label_opt.Name = "label_opt";
            this.label_opt.Size = new System.Drawing.Size(350, 72);
            this.label_opt.TabIndex = 0;
            this.label_opt.Text = "OPTIONS";
            this.label_opt.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.vlm_down);
            this.panel1.Controls.Add(this.vlm_up);
            this.panel1.Controls.Add(this.label_master_vlm);
            this.panel1.Location = new System.Drawing.Point(267, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(671, 656);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // vlm_up
            // 
            this.vlm_up.BackColor = System.Drawing.Color.DimGray;
            this.vlm_up.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vlm_up.Location = new System.Drawing.Point(193, 98);
            this.vlm_up.Name = "vlm_up";
            this.vlm_up.Size = new System.Drawing.Size(113, 67);
            this.vlm_up.TabIndex = 1;
            this.vlm_up.Text = "🔊+";
            this.vlm_up.UseVisualStyleBackColor = false;
            this.vlm_up.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // label_master_vlm
            // 
            this.label_master_vlm.AutoSize = true;
            this.label_master_vlm.BackColor = System.Drawing.Color.Transparent;
            this.label_master_vlm.Font = new System.Drawing.Font("Rockwell Extra Bold", 30F);
            this.label_master_vlm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_master_vlm.Location = new System.Drawing.Point(116, 25);
            this.label_master_vlm.Name = "label_master_vlm";
            this.label_master_vlm.Size = new System.Drawing.Size(440, 55);
            this.label_master_vlm.TabIndex = 0;
            this.label_master_vlm.Text = "Master Volume";
            this.label_master_vlm.Click += new System.EventHandler(this.master_volume_Click);
            // 
            // vlm_down
            // 
            this.vlm_down.BackColor = System.Drawing.Color.DimGray;
            this.vlm_down.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vlm_down.Location = new System.Drawing.Point(347, 98);
            this.vlm_down.Name = "vlm_down";
            this.vlm_down.Size = new System.Drawing.Size(113, 67);
            this.vlm_down.TabIndex = 2;
            this.vlm_down.Text = "🔊-";
            this.vlm_down.UseVisualStyleBackColor = false;
            this.vlm_down.Click += new System.EventHandler(this.vlm_down_Click);
            // 
            // Settings_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Praktika_Vaskoou.Properties.Resources.Slaveikov;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1182, 756);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_opt);
            this.DoubleBuffered = true;
            this.Name = "Settings_frm";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Music_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void master_volume_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label label_opt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_master_vlm;
        private System.Windows.Forms.Button vlm_up;
        private System.Windows.Forms.Button vlm_down;
    }
}