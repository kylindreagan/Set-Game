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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HowToPlay));
            this.RulesButton = new System.Windows.Forms.Button();
            this.TipsButton = new System.Windows.Forms.Button();
            this.tipsBox = new System.Windows.Forms.TextBox();
            this.TutorialButton = new System.Windows.Forms.Button();
            this.AvatarPB = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.rules = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.AvatarPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rules)).BeginInit();
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
            this.RulesButton.Click += new System.EventHandler(this.RulesButton_Click);
            // 
            // TipsButton
            // 
            this.TipsButton.BackColor = System.Drawing.Color.SkyBlue;
            this.TipsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TipsButton.Location = new System.Drawing.Point(1050, 23);
            this.TipsButton.Name = "TipsButton";
            this.TipsButton.Size = new System.Drawing.Size(145, 103);
            this.TipsButton.TabIndex = 1;
            this.TipsButton.Text = "Tips";
            this.TipsButton.UseVisualStyleBackColor = false;
            this.TipsButton.Click += new System.EventHandler(this.TipsButton_Click);
            // 
            // tipsBox
            // 
            this.tipsBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.tipsBox.Enabled = false;
            this.tipsBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipsBox.Location = new System.Drawing.Point(554, 20);
            this.tipsBox.Multiline = true;
            this.tipsBox.Name = "tipsBox";
            this.tipsBox.ReadOnly = true;
            this.tipsBox.Size = new System.Drawing.Size(390, 523);
            this.tipsBox.TabIndex = 2;
            this.tipsBox.Text = resources.GetString("tipsBox.Text");
            this.tipsBox.Visible = false;
            // 
            // TutorialButton
            // 
            this.TutorialButton.BackColor = System.Drawing.Color.Gold;
            this.TutorialButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TutorialButton.Location = new System.Drawing.Point(1050, 465);
            this.TutorialButton.Name = "TutorialButton";
            this.TutorialButton.Size = new System.Drawing.Size(145, 115);
            this.TutorialButton.TabIndex = 3;
            this.TutorialButton.Text = "Click Here For A Tutorial!";
            this.TutorialButton.UseVisualStyleBackColor = false;
            // 
            // AvatarPB
            // 
            this.AvatarPB.BackColor = System.Drawing.Color.Transparent;
            this.AvatarPB.Location = new System.Drawing.Point(22, 121);
            this.AvatarPB.Name = "AvatarPB";
            this.AvatarPB.Size = new System.Drawing.Size(430, 554);
            this.AvatarPB.TabIndex = 4;
            this.AvatarPB.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Location = new System.Drawing.Point(1032, 160);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(195, 292);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // rules
            // 
            this.rules.BackColor = System.Drawing.Color.Transparent;
            this.rules.Image = global::setJunior.Properties.Resources.RULES;
            this.rules.Location = new System.Drawing.Point(518, 23);
            this.rules.Name = "rules";
            this.rules.Size = new System.Drawing.Size(495, 628);
            this.rules.TabIndex = 6;
            this.rules.TabStop = false;
            // 
            // HowToPlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::setJunior.Properties.Resources.clouds;
            this.ClientSize = new System.Drawing.Size(1281, 687);
            this.Controls.Add(this.rules);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.AvatarPB);
            this.Controls.Add(this.TutorialButton);
            this.Controls.Add(this.tipsBox);
            this.Controls.Add(this.TipsButton);
            this.Controls.Add(this.RulesButton);
            this.Name = "HowToPlay";
            this.Text = "How To Play";
            ((System.ComponentModel.ISupportInitialize)(this.AvatarPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rules)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RulesButton;
        private System.Windows.Forms.Button TipsButton;
        private System.Windows.Forms.TextBox tipsBox;
        private System.Windows.Forms.Button TutorialButton;
        private System.Windows.Forms.PictureBox AvatarPB;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox rules;
    }
}