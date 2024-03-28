using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace setJunior
{
    public partial class Story : Form
    {
        SoundPlayer storyMusic;
        public Story()
        {
            InitializeComponent();
            string avatarName = Properties.Settings.Default.avatarStr;
            pictureBox2.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(avatarName);
            string musicName = Properties.Settings.Default.musicStr;
            storyMusic = new SoundPlayer((System.IO.Stream)Properties.Resources.ResourceManager.GetObject(musicName));
            storyMusic.PlayLooping();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Quit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("If you're in the middle of a game, you will lose all SpaceBux you have gained so far!", "Are you sure you want to leave?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
                storyMusic.Stop();
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }
    }
}
