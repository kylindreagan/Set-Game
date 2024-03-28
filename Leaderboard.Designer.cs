namespace setJunior
{
    partial class Leaderboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Leaderboard));
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.globalCrown = new System.Windows.Forms.PictureBox();
            this.localCrown = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.globalCrown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localCrown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Font = new System.Drawing.Font("Courier New", 12F);
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(129, 161);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(408, 345);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(91, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 59);
            this.label1.TabIndex = 1;
            this.label1.Text = "HALL OF FAME";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(159, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 59);
            this.label2.TabIndex = 2;
            this.label2.Text = "ALL TIME";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // listView2
            // 
            this.listView2.Font = new System.Drawing.Font("Courier New", 12F);
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(819, 145);
            this.listView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(304, 345);
            this.listView2.TabIndex = 3;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(762, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(404, 59);
            this.label3.TabIndex = 4;
            this.label3.Text = "HALL OF FAME";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(874, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 59);
            this.label4.TabIndex = 5;
            this.label4.Text = "LOCAL";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Yellow;
            this.label5.Location = new System.Drawing.Point(181, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(223, 56);
            this.label5.TabIndex = 6;
            this.label5.Text = "GLOBAL";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // globalCrown
            // 
            this.globalCrown.BackColor = System.Drawing.Color.Transparent;
            this.globalCrown.Image = global::setJunior.Properties.Resources.crown;
            this.globalCrown.Location = new System.Drawing.Point(74, 172);
            this.globalCrown.Margin = new System.Windows.Forms.Padding(4);
            this.globalCrown.Name = "globalCrown";
            this.globalCrown.Size = new System.Drawing.Size(48, 62);
            this.globalCrown.TabIndex = 7;
            this.globalCrown.TabStop = false;
            // 
            // localCrown
            // 
            this.localCrown.BackColor = System.Drawing.Color.Transparent;
            this.localCrown.Image = global::setJunior.Properties.Resources.crown;
            this.localCrown.Location = new System.Drawing.Point(762, 172);
            this.localCrown.Margin = new System.Windows.Forms.Padding(4);
            this.localCrown.Name = "localCrown";
            this.localCrown.Size = new System.Drawing.Size(50, 62);
            this.localCrown.TabIndex = 8;
            this.localCrown.TabStop = false;
            this.localCrown.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::setJunior.Properties.Resources.exit;
            this.pictureBox1.Location = new System.Drawing.Point(149, 511);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(317, 194);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::setJunior.Properties.Resources.Music_Mute;
            this.pictureBox3.Location = new System.Drawing.Point(499, 22);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(77, 63);
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // Leaderboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::setJunior.Properties.Resources.bg3;
            this.ClientSize = new System.Drawing.Size(614, 618);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.localCrown);
            this.Controls.Add(this.globalCrown);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Leaderboard";
            this.Text = "Hall of Fame";
            ((System.ComponentModel.ISupportInitialize)(this.globalCrown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localCrown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox globalCrown;
        private System.Windows.Forms.PictureBox localCrown;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}