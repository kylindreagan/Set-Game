using System;
using System.Collections.Generic;
using System.Media;
using System.Windows.Forms;

namespace setJunior
{

    public partial class Customization : Form
    {
        bool isPlaying = true;
        SoundPlayer shopMusic = new SoundPlayer(setJunior.Properties.Resources.ChillandSet);
        List<string> avatars = new List<string>();
        List<string> musics = new List<string>();
        List<string> decks = new List<string>();
        public Customization()
        {
            InitializeComponent();
            shopMusic.PlayLooping();

        }

        //shop button. I am bad at remembering to name things as will be seen
        private void button4_Click(object sender, EventArgs e)
        {
            EquipButton.Visible = false;
            EquipButton.Enabled = false;
            BuyButton.Enabled = true;
            BuyButton.Visible = true;
        }

        //exit picture
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.OpenForms["Customization"].Close();
        }

        //mute or unmute
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (isPlaying)
            {
                pictureBox3.Image = setJunior.Properties.Resources.Mute_Unmute;
                shopMusic.Stop();
                isPlaying = false;
            }
            else
            {
                pictureBox3.Image = setJunior.Properties.Resources.Music_Mute;
                shopMusic.PlayLooping();
                isPlaying = true;
            }
        }

        private void musicbutton_Click(object sender, EventArgs e)
        {
            EquipButton.Visible = true;
            EquipButton.Enabled = true;
            BuyButton.Enabled = false;
            BuyButton.Visible = false;
        }

        //"aliens" are the same as deck, but that terminology might be confusing for kids
        private void deckbutton_Click(object sender, EventArgs e)
        {
            EquipButton.Visible = true;
            EquipButton.Enabled = true;
            BuyButton.Enabled = false;
            BuyButton.Visible = false;
        }

        private void avatarbutton_Click(object sender, EventArgs e)
        {
            EquipButton.Visible = true;
            EquipButton.Enabled = true;
            BuyButton.Enabled = false;
            BuyButton.Visible = false;
        }
    }
}
