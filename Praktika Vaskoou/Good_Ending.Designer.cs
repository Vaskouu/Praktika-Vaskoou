namespace Praktika_Vaskoou
{
    partial class Good_Ending
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.good_ending_label = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Praktika_Vaskoou.Properties.Resources.IMG_20250620_223402_430_removebg_preview__1_;
            this.pictureBox1.Location = new System.Drawing.Point(-3, 208);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(499, 549);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // good_ending_label
            // 
            this.good_ending_label.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.good_ending_label.Font = new System.Drawing.Font("Chiller", 23.81818F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.good_ending_label.ForeColor = System.Drawing.Color.DarkRed;
            this.good_ending_label.Location = new System.Drawing.Point(192, 47);
            this.good_ending_label.Name = "good_ending_label";
            this.good_ending_label.Size = new System.Drawing.Size(723, 138);
            this.good_ending_label.TabIndex = 1;
            this.good_ending_label.Text = "He shows you his friends help you reach the nearest hotel.\r\n They get you a room " +
    "for the night, as they are in the same hotel too.                               " +
    "[good ending]\r\n";
            this.good_ending_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.Font = new System.Drawing.Font("Chiller", 35.87273F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(719, 681);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(378, 63);
            this.button1.TabIndex = 2;
            this.button1.Text = "Back to main menu.";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Good_Ending
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Praktika_Vaskoou.Properties.Resources.hotel1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1182, 756);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.good_ending_label);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Name = "Good_Ending";
            this.Text = "Good_Ending";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label good_ending_label;
        private System.Windows.Forms.Button button1;
    }
}