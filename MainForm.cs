using MySql.Data.MySqlClient;
using SharpDX.Multimedia;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Media;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace setJunior
{
    public partial class MainForm : Form
    {
        MySqlConnection connection;
        string server;
        string database;
        string user;
        string password;
        string port;
        string connectionString;
        string sslM;
        SoundPlayer menuMusic;
        SoundPlayer takeoff = new SoundPlayer(setJunior.Properties.Resources.takeoff);
        bool isPlaying = true;
        bool SFX = true;
        struct Card
        {
            public int color;
            public int shape;
            public int eyes;
            public string imgname;
        }
        public MainForm()
        {


            server = "localhost";
            database = "set";
            user = "root";
            password = "root";
            port = "8889";
            sslM = "none";

            connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "user=" + user + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                connection.Close();

            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message + connectionString);
            }
            PictureBox[] pictures = new PictureBox[10];
            void createPictures()
            // you can dynamically create controls
            {
                int x = 10;
                int y = 10;
                for (int i = 0; i < 10; i++)
                {
                    pictures[i] = new PictureBox();
                    pictures[i].Width = 60;
                    pictures[i].Height = 60; // these are the dimensions of the pink elephant image
                                             // in the following line, change SetJunior to the name of your project
                    pictures[i].Image = setJunior.Properties.Resources.pinkElephant;
                    pictures[i].Location = new Point(x, y);
                    x += 80;
                    if (i == 4)
                    {
                        x = 10;
                        y += 90;
                    }
                    this.Controls.Add(pictures[i]);
                }
            }
            
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            //createPictures();
            string avatarName = Properties.Settings.Default.avatarStr;
            AvatarPB.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(avatarName);
            string musicName = Properties.Settings.Default.musicStr;
            menuMusic = new SoundPlayer((System.IO.Stream)Properties.Resources.ResourceManager.GetObject(musicName));
            menuMusic.PlayLooping();


        }

        //Quit button
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to leave?", "But you just got here!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
               this.Close();
                Console.WriteLine("I'm sorry");
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private Bitmap GetImageResource(string filename)
        {
            string resourcename = filename.Substring(0, filename.IndexOf("."));
            return (Bitmap)Properties.Resources.ResourceManager.GetObject(resourcename);
        }

        //play button
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (SFX)
            {
                takeoff.Play();
            }
        }

        //leaderboard or "hall of fame" (too long for naming stuff) button
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            
            Leaderboard form = new Leaderboard();
            form.Refresh();
            form.ShowDialog();
            takeoff.Play();
            form.Dispose();
            menuMusic.PlayLooping();
        }

        private void CreditsButton_Click(object sender, EventArgs e)
        {
            Acknoledgements form = new Acknoledgements();
            form.Refresh();
            form.ShowDialog();
            form.Dispose();
        }

        private void StoryButton_Click(object sender, EventArgs e)
        {
            Story form = new Story();
            form.Refresh();
            form.ShowDialog();
            form.Dispose();
        }

        //mute or unmute music
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (isPlaying)
            {
                pictureBox1.Image = setJunior.Properties.Resources.Mute_Unmute;
                menuMusic.Stop();
                isPlaying = false;
            }
            else
            {
                pictureBox1.Image = setJunior.Properties.Resources.Music_Mute;
                menuMusic.PlayLooping();
                isPlaying = true;
            }
        }

        private void SFXButton_Click(object sender, EventArgs e)
        {
            if (SFX)
            {
                SFXButton.Image = setJunior.Properties.Resources.UnmuteSFX;
                SFX = false;
            }
            else
            {
                SFXButton.Image = setJunior.Properties.Resources.MuteSFX;
                SFX = true;
            }
        }

        //Customization button
        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            Customization form = new Customization();
            form.Refresh();
            form.ShowDialog();
            form.Dispose();
            string avatarName = Properties.Settings.Default.avatarStr;
            AvatarPB.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(avatarName);
            string musicName = Properties.Settings.Default.musicStr;
            menuMusic = new SoundPlayer((System.IO.Stream)Properties.Resources.ResourceManager.GetObject(musicName));
            menuMusic.PlayLooping();
        }

        private void speechbubble_Click(object sender, EventArgs e)
        {
            HowToPlay form = new HowToPlay();
            form.Refresh();
            form.ShowDialog();
            form.Dispose();
        }

        private void spacemansam_Click(object sender, EventArgs e)
        {
            HowToPlay form = new HowToPlay();
            form.Refresh();
            form.ShowDialog();
            takeoff.Play();
            form.Dispose();
            menuMusic.PlayLooping();
        }

        private void spaceship_Click(object sender, EventArgs e)
        {
            if (SFX)
            {
                takeoff.Play();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Astronimo form = new Astronimo();
            form.Refresh();
            form.ShowDialog();
            takeoff.Play();
            form.Dispose();
            menuMusic.PlayLooping();
        }
    }
}