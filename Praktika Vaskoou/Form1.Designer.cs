namespace Praktika_Vaskoou
{
    partial class Form1
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
            this.play_button = new System.Windows.Forms.Button();
            this.options_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Quit_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // play_button
            // 
            this.play_button.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.play_button.Font = new System.Drawing.Font("Chiller", 40.29091F, System.Drawing.FontStyle.Bold);
            this.play_button.Location = new System.Drawing.Point(509, 282);
            this.play_button.Name = "play_button";
            this.play_button.Size = new System.Drawing.Size(221, 104);
            this.play_button.TabIndex = 0;
            this.play_button.Text = "PLAY";
            this.play_button.UseVisualStyleBackColor = false;
            this.play_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // options_button
            // 
            this.options_button.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.options_button.Font = new System.Drawing.Font("Chiller", 39.92727F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.options_button.Location = new System.Drawing.Point(509, 393);
            this.options_button.Name = "options_button";
            this.options_button.Size = new System.Drawing.Size(221, 104);
            this.options_button.TabIndex = 1;
            this.options_button.Text = "OPTIONS";
            this.options_button.UseVisualStyleBackColor = false;
            this.options_button.Click += new System.EventHandler(this.options_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Chiller", 60.92727F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(162, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(871, 109);
            this.label1.TabIndex = 3;
            this.label1.Text = "SLAVEIKOV AT 03:00 AM";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Praktika_Vaskoou.Properties.Resources.Picture2;
            this.pictureBox1.Location = new System.Drawing.Point(1012, 443);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(273, 337);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Quit_button
            // 
            this.Quit_button.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Quit_button.Font = new System.Drawing.Font("Chiller", 39.92727F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quit_button.Location = new System.Drawing.Point(509, 504);
            this.Quit_button.Name = "Quit_button";
            this.Quit_button.Size = new System.Drawing.Size(221, 104);
            this.Quit_button.TabIndex = 5;
            this.Quit_button.Text = "QUIT";
            this.Quit_button.UseVisualStyleBackColor = false;
            this.Quit_button.Click += new System.EventHandler(this.Quit_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Praktika_Vaskoou.Properties.Resources.Slaveikov;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1182, 756);
            this.Controls.Add(this.Quit_button);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.options_button);
            this.Controls.Add(this.play_button);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Chiller", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button play_button;
        private System.Windows.Forms.Button options_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Quit_button;
    }
}

