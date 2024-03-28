using MySql.Data.MySqlClient;
using SharpDX.Multimedia;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Media;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
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
        bool isPlaying = Properties.Settings.Default.isPlaying;
        bool SFX = Properties.Settings.Default.SFX;

        
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
            catch (MySqlException)
            {
                MessageBox.Show("Error connecting to the servers");
            }
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
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
                menuMusic.Stop();
                Properties.Settings.Default.isPlaying = true;
                Properties.Settings.Default.SFX = true;
                Properties.Settings.Default.Save();
                Console.WriteLine("I'm sorry");
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }


        //play button
        private async void pictureBox2_Click(object sender, EventArgs e)
        {
            if (SFX)
            {
                takeoff.Play();
                await Task.Delay(1500);
            }
            GameForm form = new GameForm();
            form.Refresh();
            form.ShowDialog();
            form.Dispose();
            menuMusic.PlayLooping();
        }

        //leaderboard or "hall of fame" (too long for naming stuff) button
        private async void pictureBox4_Click(object sender, EventArgs e)
        {

            if (SFX)
            {
                takeoff.Play();
                await Task.Delay(1500);
            }
            Leaderboard form = new Leaderboard();
            form.Refresh();
            form.ShowDialog();
            takeoff.Play();
            form.Dispose();
            if (isPlaying)
            {
                menuMusic.PlayLooping();
            }
        }

        private void CreditsButton_Click(object sender, EventArgs e)
        {
            Acknoledgements form = new Acknoledgements();
            form.Refresh();
            form.ShowDialog();
            form.Dispose();
        }

        private async void StoryButton_Click(object sender, EventArgs e)
        {
            if (SFX)
            {
                takeoff.Play();
                await Task.Delay(1500);
            }
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
                Properties.Settings.Default.SFX = SFX;
                Properties.Settings.Default.Save();
            }
            else
            {
                SFXButton.Image = setJunior.Properties.Resources.MuteSFX;
                SFX = true;
                Properties.Settings.Default.SFX = SFX;
                Properties.Settings.Default.Save();
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
            if (isPlaying)
            {
                menuMusic.PlayLooping();
            }
        }

        private void speechbubble_Click(object sender, EventArgs e)
        {
            HowToPlay form = new HowToPlay();
            form.Refresh();
            form.ShowDialog();
            form.Dispose();
            if (isPlaying)
            {
                menuMusic.PlayLooping();
            }
        }

        private void spacemansam_Click(object sender, EventArgs e)
        {
            HowToPlay form = new HowToPlay();
            form.Refresh();
            form.ShowDialog();
            takeoff.Play();
            form.Dispose();
            if (isPlaying)
            {
                menuMusic.PlayLooping();
            }
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
            if (isPlaying)
            {
                menuMusic.PlayLooping();
            }
        }
    }
}