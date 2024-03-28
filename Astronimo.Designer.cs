namespace setJunior
{
    partial class Astronimo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Astronimo));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AstronimoSpeech = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tiredMeter = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.Happiness = new System.Windows.Forms.Label();
            this.happyMeter = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(12, 294);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(219, 155);
            this.button1.TabIndex = 0;
            this.button1.Text = "Toys and Treats";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(580, 276);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(219, 155);
            this.button2.TabIndex = 1;
            this.button2.Text = "Play with Astronimo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(293, 513);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(219, 69);
            this.button3.TabIndex = 2;
            this.button3.Text = "Talk to Astronimo";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::setJunior.Properties.Resources.Astronimo;
            this.pictureBox1.Location = new System.Drawing.Point(246, 190);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(317, 353);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // AstronimoSpeech
            // 
            this.AstronimoSpeech.AutoSize = true;
            this.AstronimoSpeech.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AstronimoSpeech.Location = new System.Drawing.Point(143, 101);
            this.AstronimoSpeech.Name = "AstronimoSpeech";
            this.AstronimoSpeech.Size = new System.Drawing.Size(548, 58);
            this.AstronimoSpeech.TabIndex = 5;
            this.AstronimoSpeech.Text = "Mewllo! I\'m Astronimo, your furry virtual companion! \r\nYou can play with me in be" +
    "tween games of Set Wars! ";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(264, 612);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(265, 22);
            this.textBox1.TabIndex = 7;
            this.textBox1.Visible = false;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // tiredMeter
            // 
            this.tiredMeter.ForeColor = System.Drawing.Color.Red;
            this.tiredMeter.Location = new System.Drawing.Point(186, 12);
            this.tiredMeter.Name = "tiredMeter";
            this.tiredMeter.Size = new System.Drawing.Size(477, 34);
            this.tiredMeter.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.tiredMeter.TabIndex = 8;
            this.tiredMeter.Click += new System.EventHandler(this.tiredMeter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(56, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 26);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tiredness:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Enabled = false;
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(544, 594);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(76, 58);
            this.button4.TabIndex = 10;
            this.button4.Text = "Speak!";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // Happiness
            // 
            this.Happiness.AutoSize = true;
            this.Happiness.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Happiness.ForeColor = System.Drawing.Color.Yellow;
            this.Happiness.Location = new System.Drawing.Point(49, 60);
            this.Happiness.Name = "Happiness";
            this.Happiness.Size = new System.Drawing.Size(122, 26);
            this.Happiness.TabIndex = 12;
            this.Happiness.Text = "Happiness:";
            // 
            // happyMeter
            // 
            this.happyMeter.ForeColor = System.Drawing.Color.Yellow;
            this.happyMeter.Location = new System.Drawing.Point(186, 52);
            this.happyMeter.Name = "happyMeter";
            this.happyMeter.Size = new System.Drawing.Size(477, 34);
            this.happyMeter.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.happyMeter.TabIndex = 11;
            // 
            // Astronimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 675);
            this.Controls.Add(this.Happiness);
            this.Controls.Add(this.happyMeter);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tiredMeter);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.AstronimoSpeech);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Astronimo";
            this.Text = "Astronimo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label AstronimoSpeech;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ProgressBar tiredMeter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label Happiness;
        private System.Windows.Forms.ProgressBar happyMeter;
    }
}