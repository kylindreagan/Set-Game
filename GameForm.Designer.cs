namespace setJunior
{
    partial class GameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.EasyButton = new System.Windows.Forms.Button();
            this.NormieButton = new System.Windows.Forms.Button();
            this.HardButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timerLabel = new System.Windows.Forms.Label();
            this.SFXButton = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buxLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Quit = new System.Windows.Forms.PictureBox();
            this.RestartButton = new System.Windows.Forms.PictureBox();
            this.easylabel1 = new System.Windows.Forms.Label();
            this.easylabel2 = new System.Windows.Forms.Label();
            this.easylabel3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.difficulties = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.totalBuxLabel = new System.Windows.Forms.Label();
            this.HTPButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SFXButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Quit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RestartButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.difficulties)).BeginInit();
            this.SuspendLayout();
            // 
            // EasyButton
            // 
            this.EasyButton.BackColor = System.Drawing.Color.YellowGreen;
            this.EasyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EasyButton.Font = new System.Drawing.Font("Sylfaen", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EasyButton.ForeColor = System.Drawing.Color.Black;
            this.EasyButton.Location = new System.Drawing.Point(324, 264);
            this.EasyButton.Name = "EasyButton";
            this.EasyButton.Size = new System.Drawing.Size(320, 210);
            this.EasyButton.TabIndex = 0;
            this.EasyButton.Text = "Easy";
            this.EasyButton.UseVisualStyleBackColor = false;
            this.EasyButton.Click += new System.EventHandler(this.EasyButton_Click);
            // 
            // NormieButton
            // 
            this.NormieButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.NormieButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NormieButton.Font = new System.Drawing.Font("Sylfaen", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NormieButton.ForeColor = System.Drawing.Color.Black;
            this.NormieButton.Location = new System.Drawing.Point(819, 70);
            this.NormieButton.Name = "NormieButton";
            this.NormieButton.Size = new System.Drawing.Size(328, 213);
            this.NormieButton.TabIndex = 1;
            this.NormieButton.Text = "Normal";
            this.NormieButton.UseVisualStyleBackColor = false;
            this.NormieButton.Click += new System.EventHandler(this.NormieButton_Click);
            // 
            // HardButton
            // 
            this.HardButton.BackColor = System.Drawing.Color.Red;
            this.HardButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HardButton.Font = new System.Drawing.Font("Sylfaen", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HardButton.ForeColor = System.Drawing.Color.Black;
            this.HardButton.Location = new System.Drawing.Point(1280, 289);
            this.HardButton.Name = "HardButton";
            this.HardButton.Size = new System.Drawing.Size(322, 210);
            this.HardButton.TabIndex = 2;
            this.HardButton.Text = "Hard";
            this.HardButton.UseVisualStyleBackColor = false;
            this.HardButton.Click += new System.EventHandler(this.HardButton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Font = new System.Drawing.Font("Yu Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerLabel.Location = new System.Drawing.Point(22, 19);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(141, 52);
            this.timerLabel.TabIndex = 3;
            this.timerLabel.Text = "label1";
            this.timerLabel.Visible = false;
            // 
            // SFXButton
            // 
            this.SFXButton.BackColor = System.Drawing.Color.Transparent;
            this.SFXButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SFXButton.Image = global::setJunior.Properties.Resources.MuteSFX;
            this.SFXButton.Location = new System.Drawing.Point(1749, 12);
            this.SFXButton.Name = "SFXButton";
            this.SFXButton.Size = new System.Drawing.Size(80, 73);
            this.SFXButton.TabIndex = 16;
            this.SFXButton.TabStop = false;
            this.SFXButton.Click += new System.EventHandler(this.SFXButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::setJunior.Properties.Resources.Music_Mute;
            this.pictureBox1.Location = new System.Drawing.Point(1845, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(91, 73);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // buxLabel
            // 
            this.buxLabel.AutoSize = true;
            this.buxLabel.BackColor = System.Drawing.Color.YellowGreen;
            this.buxLabel.Font = new System.Drawing.Font("Yu Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buxLabel.Location = new System.Drawing.Point(616, 19);
            this.buxLabel.Name = "buxLabel";
            this.buxLabel.Size = new System.Drawing.Size(45, 52);
            this.buxLabel.TabIndex = 18;
            this.buxLabel.Text = "0";
            this.buxLabel.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBox1.Location = new System.Drawing.Point(819, 450);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(323, 24);
            this.comboBox1.TabIndex = 19;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(703, 376);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(517, 52);
            this.label1.TabIndex = 20;
            this.label1.Text = "Enter amount of minutes:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(206, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(373, 52);
            this.label2.TabIndex = 21;
            this.label2.Text = "Spacebux earned:";
            this.label2.Visible = false;
            // 
            // Quit
            // 
            this.Quit.BackColor = System.Drawing.Color.Transparent;
            this.Quit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Quit.Image = global::setJunior.Properties.Resources.QuitButton;
            this.Quit.Location = new System.Drawing.Point(2, 851);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(148, 121);
            this.Quit.TabIndex = 22;
            this.Quit.TabStop = false;
            this.Quit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // RestartButton
            // 
            this.RestartButton.BackColor = System.Drawing.Color.Transparent;
            this.RestartButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RestartButton.Enabled = false;
            this.RestartButton.Image = global::setJunior.Properties.Resources.Restart;
            this.RestartButton.Location = new System.Drawing.Point(156, 851);
            this.RestartButton.Name = "RestartButton";
            this.RestartButton.Size = new System.Drawing.Size(189, 121);
            this.RestartButton.TabIndex = 23;
            this.RestartButton.TabStop = false;
            this.RestartButton.Visible = false;
            this.RestartButton.Click += new System.EventHandler(this.RestartButton_Click);
            // 
            // easylabel1
            // 
            this.easylabel1.AutoSize = true;
            this.easylabel1.BackColor = System.Drawing.Color.Black;
            this.easylabel1.Font = new System.Drawing.Font("Yu Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.easylabel1.ForeColor = System.Drawing.Color.Yellow;
            this.easylabel1.Location = new System.Drawing.Point(351, 866);
            this.easylabel1.Name = "easylabel1";
            this.easylabel1.Size = new System.Drawing.Size(139, 52);
            this.easylabel1.TabIndex = 24;
            this.easylabel1.Text = "Color:";
            this.easylabel1.Visible = false;
            // 
            // easylabel2
            // 
            this.easylabel2.AutoSize = true;
            this.easylabel2.BackColor = System.Drawing.Color.Black;
            this.easylabel2.Font = new System.Drawing.Font("Yu Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.easylabel2.ForeColor = System.Drawing.Color.Yellow;
            this.easylabel2.Location = new System.Drawing.Point(1135, 869);
            this.easylabel2.Name = "easylabel2";
            this.easylabel2.Size = new System.Drawing.Size(286, 52);
            this.easylabel2.TabIndex = 25;
            this.easylabel2.Text = "Type of Alien:";
            this.easylabel2.Visible = false;
            // 
            // easylabel3
            // 
            this.easylabel3.AutoSize = true;
            this.easylabel3.BackColor = System.Drawing.Color.Black;
            this.easylabel3.Font = new System.Drawing.Font("Yu Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.easylabel3.ForeColor = System.Drawing.Color.Yellow;
            this.easylabel3.Location = new System.Drawing.Point(680, 866);
            this.easylabel3.Name = "easylabel3";
            this.easylabel3.Size = new System.Drawing.Size(344, 52);
            this.easylabel3.TabIndex = 26;
            this.easylabel3.Text = "Number of Eyes:";
            this.easylabel3.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Location = new System.Drawing.Point(552, 851);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(122, 101);
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Location = new System.Drawing.Point(1427, 857);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(90, 95);
            this.pictureBox3.TabIndex = 28;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Location = new System.Drawing.Point(1020, 851);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(102, 101);
            this.pictureBox4.TabIndex = 29;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Visible = false;
            // 
            // difficulties
            // 
            this.difficulties.BackColor = System.Drawing.Color.Transparent;
            this.difficulties.Image = global::setJunior.Properties.Resources.difficulties;
            this.difficulties.Location = new System.Drawing.Point(762, 519);
            this.difficulties.Name = "difficulties";
            this.difficulties.Size = new System.Drawing.Size(565, 319);
            this.difficulties.TabIndex = 30;
            this.difficulties.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Yu Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(206, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(332, 52);
            this.label3.TabIndex = 32;
            this.label3.Text = "Total Spacebux:";
            // 
            // totalBuxLabel
            // 
            this.totalBuxLabel.AutoSize = true;
            this.totalBuxLabel.BackColor = System.Drawing.Color.YellowGreen;
            this.totalBuxLabel.Font = new System.Drawing.Font("Yu Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalBuxLabel.Location = new System.Drawing.Point(616, 19);
            this.totalBuxLabel.Name = "totalBuxLabel";
            this.totalBuxLabel.Size = new System.Drawing.Size(45, 52);
            this.totalBuxLabel.TabIndex = 31;
            this.totalBuxLabel.Text = "0";
            // 
            // HTPButton
            // 
            this.HTPButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.HTPButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HTPButton.ForeColor = System.Drawing.Color.Yellow;
            this.HTPButton.Location = new System.Drawing.Point(62, 776);
            this.HTPButton.Name = "HTPButton";
            this.HTPButton.Size = new System.Drawing.Size(131, 62);
            this.HTPButton.TabIndex = 33;
            this.HTPButton.Text = "HOW TO PLAY";
            this.HTPButton.UseVisualStyleBackColor = false;
            this.HTPButton.Click += new System.EventHandler(this.HTPButton_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::setJunior.Properties.Resources.spaceset;
            this.ClientSize = new System.Drawing.Size(1924, 950);
            this.ControlBox = false;
            this.Controls.Add(this.HTPButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.totalBuxLabel);
            this.Controls.Add(this.difficulties);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.easylabel3);
            this.Controls.Add(this.easylabel2);
            this.Controls.Add(this.easylabel1);
            this.Controls.Add(this.RestartButton);
            this.Controls.Add(this.Quit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buxLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SFXButton);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.HardButton);
            this.Controls.Add(this.NormieButton);
            this.Controls.Add(this.EasyButton);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GameForm";
            this.Text = "GameForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GameForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SFXButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Quit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RestartButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.difficulties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EasyButton;
        private System.Windows.Forms.Button NormieButton;
        private System.Windows.Forms.Button HardButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.PictureBox SFXButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label buxLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox Quit;
        private System.Windows.Forms.PictureBox RestartButton;
        private System.Windows.Forms.Label easylabel1;
        private System.Windows.Forms.Label easylabel2;
        private System.Windows.Forms.Label easylabel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox difficulties;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label totalBuxLabel;
        private System.Windows.Forms.Button HTPButton;
    }
}