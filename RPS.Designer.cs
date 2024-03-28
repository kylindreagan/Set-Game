namespace setJunior
{
    partial class RPS
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.PlayButton = new System.Windows.Forms.Button();
            this.ROCKbutton = new System.Windows.Forms.Button();
            this.PAPERbutton = new System.Windows.Forms.Button();
            this.SCISSORSbutton = new System.Windows.Forms.Button();
            this.astronimoPic = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.earnLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.astronimoPic)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS PGothic", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(473, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "ROCK PAPER SCISSORS";
            // 
            // PlayButton
            // 
            this.PlayButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlayButton.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayButton.Location = new System.Drawing.Point(168, 161);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(334, 177);
            this.PlayButton.TabIndex = 1;
            this.PlayButton.Text = "PLAY \r\n(5 Spacebux)\r\n";
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // ROCKbutton
            // 
            this.ROCKbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ROCKbutton.Enabled = false;
            this.ROCKbutton.Image = global::setJunior.Properties.Resources.ROCK;
            this.ROCKbutton.Location = new System.Drawing.Point(35, 385);
            this.ROCKbutton.Name = "ROCKbutton";
            this.ROCKbutton.Size = new System.Drawing.Size(147, 134);
            this.ROCKbutton.TabIndex = 2;
            this.ROCKbutton.UseVisualStyleBackColor = true;
            this.ROCKbutton.Visible = false;
            this.ROCKbutton.Click += new System.EventHandler(this.ROCKbutton_Click);
            // 
            // PAPERbutton
            // 
            this.PAPERbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PAPERbutton.Enabled = false;
            this.PAPERbutton.Image = global::setJunior.Properties.Resources.PAPER;
            this.PAPERbutton.Location = new System.Drawing.Point(246, 385);
            this.PAPERbutton.Name = "PAPERbutton";
            this.PAPERbutton.Size = new System.Drawing.Size(147, 134);
            this.PAPERbutton.TabIndex = 3;
            this.PAPERbutton.UseVisualStyleBackColor = true;
            this.PAPERbutton.Visible = false;
            this.PAPERbutton.Click += new System.EventHandler(this.PAPERbutton_Click);
            // 
            // SCISSORSbutton
            // 
            this.SCISSORSbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SCISSORSbutton.Enabled = false;
            this.SCISSORSbutton.Image = global::setJunior.Properties.Resources.SCISSORS;
            this.SCISSORSbutton.Location = new System.Drawing.Point(446, 385);
            this.SCISSORSbutton.Name = "SCISSORSbutton";
            this.SCISSORSbutton.Size = new System.Drawing.Size(147, 134);
            this.SCISSORSbutton.TabIndex = 4;
            this.SCISSORSbutton.UseVisualStyleBackColor = true;
            this.SCISSORSbutton.Visible = false;
            this.SCISSORSbutton.Click += new System.EventHandler(this.SCISSORSbutton_Click);
            // 
            // astronimoPic
            // 
            this.astronimoPic.Image = global::setJunior.Properties.Resources.AstronimoKitten;
            this.astronimoPic.Location = new System.Drawing.Point(215, 125);
            this.astronimoPic.Name = "astronimoPic";
            this.astronimoPic.Size = new System.Drawing.Size(255, 232);
            this.astronimoPic.TabIndex = 5;
            this.astronimoPic.TabStop = false;
            this.astronimoPic.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "Spacebux earned:";
            this.label2.Visible = false;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // earnLabel
            // 
            this.earnLabel.AutoSize = true;
            this.earnLabel.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.earnLabel.Location = new System.Drawing.Point(75, 192);
            this.earnLabel.Name = "earnLabel";
            this.earnLabel.Size = new System.Drawing.Size(27, 36);
            this.earnLabel.TabIndex = 7;
            this.earnLabel.Text = "0";
            this.earnLabel.Visible = false;
            this.earnLabel.Click += new System.EventHandler(this.earnLabel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS PGothic", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(601, 74);
            this.label3.TabIndex = 8;
            this.label3.Text = "For each win, your earnings double.\r\nBut, if you lose, you lose it all!\r\n";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(75, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 36);
            this.label4.TabIndex = 9;
            this.label4.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 30);
            this.label5.TabIndex = 10;
            this.label5.Text = "Total SpaceBux:";
            // 
            // RPS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(168)))), ((int)(((byte)(209)))));
            this.ClientSize = new System.Drawing.Size(619, 602);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.earnLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.astronimoPic);
            this.Controls.Add(this.SCISSORSbutton);
            this.Controls.Add(this.PAPERbutton);
            this.Controls.Add(this.ROCKbutton);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Crimson;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RPS";
            this.Text = "RPS";
            this.Load += new System.EventHandler(this.RPS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.astronimoPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Button ROCKbutton;
        private System.Windows.Forms.Button PAPERbutton;
        private System.Windows.Forms.Button SCISSORSbutton;
        private System.Windows.Forms.PictureBox astronimoPic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label earnLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}