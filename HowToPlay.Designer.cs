namespace setJunior
{
    partial class HowToPlay
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
            this.RulesButton = new System.Windows.Forms.Button();
            this.TipsButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TutorialButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // RulesButton
            // 
            this.RulesButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.RulesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RulesButton.Location = new System.Drawing.Point(64, 12);
            this.RulesButton.Name = "RulesButton";
            this.RulesButton.Size = new System.Drawing.Size(167, 103);
            this.RulesButton.TabIndex = 0;
            this.RulesButton.Text = "Rules";
            this.RulesButton.UseVisualStyleBackColor = false;
            // 
            // TipsButton
            // 
            this.TipsButton.BackColor = System.Drawing.Color.SkyBlue;
            this.TipsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TipsButton.Location = new System.Drawing.Point(675, 22);
            this.TipsButton.Name = "TipsButton";
            this.TipsButton.Size = new System.Drawing.Size(167, 103);
            this.TipsButton.TabIndex = 1;
            this.TipsButton.Text = "Tips";
            this.TipsButton.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(262, 22);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(390, 523);
            this.textBox1.TabIndex = 2;
            // 
            // TutorialButton
            // 
            this.TutorialButton.BackColor = System.Drawing.Color.Gold;
            this.TutorialButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TutorialButton.Location = new System.Drawing.Point(697, 464);
            this.TutorialButton.Name = "TutorialButton";
            this.TutorialButton.Size = new System.Drawing.Size(145, 115);
            this.TutorialButton.TabIndex = 3;
            this.TutorialButton.Text = "Click Here For A Tutorial!";
            this.TutorialButton.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::setJunior.Properties.Resources.smallspacesam1;
            this.pictureBox1.Location = new System.Drawing.Point(17, 301);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 267);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Location = new System.Drawing.Point(679, 159);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(195, 292);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // HowToPlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::setJunior.Properties.Resources.clouds;
            this.ClientSize = new System.Drawing.Size(911, 618);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TutorialButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.TipsButton);
            this.Controls.Add(this.RulesButton);
            this.Name = "HowToPlay";
            this.Text = "How To Play";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RulesButton;
        private System.Windows.Forms.Button TipsButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button TutorialButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}