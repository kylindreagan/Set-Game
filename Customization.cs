using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Media;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace setJunior
{

    public partial class Customization : Form
    {
        bool isPlaying = true;
        bool isAvatar = false;
        bool isMusic = false;
        bool isDecks = false;
        bool isShop = false;
        bool empty;

        SoundPlayer shopMusic = new SoundPlayer(setJunior.Properties.Resources.ChillandSet);
        string lines;
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
            listView1.Clear();
            isAvatar = false;
            isMusic = false;
            isDecks = false;
            isShop = true;
            listView1.View = View.Details;
            listView1.Columns.Add("Name", -1, HorizontalAlignment.Left);
            listView1.Columns.Add("Cost", -1, HorizontalAlignment.Right);
        }

        //exit picture
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
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
            isAvatar = false;
            isMusic = true;
            isDecks = false;
            isShop = false;
            listView1.Clear();
            listView1.View = View.Details;
            listView1.Columns.Add("Music Name", -2, HorizontalAlignment.Left);
            empty = false;
            StreamReader musicFile = new StreamReader("musicTxt.txt");
            while (!empty)
            {
                lines = musicFile.ReadLine();
                if (lines == null)
                {
                    empty = true;
                    break;
                }
                Console.WriteLine(lines);
                ListViewItem item = new ListViewItem(lines);
                listView1.Items.Add(item);
            }

        }

        //"aliens" are the same as deck, but that terminology might be confusing for kids
        private void deckbutton_Click(object sender, EventArgs e)
        {
            EquipButton.Visible = true;
            EquipButton.Enabled = true;
            BuyButton.Enabled = false;
            BuyButton.Visible = false;
            isAvatar = false;
            isMusic = false;
            isDecks = true;
            isShop = false;
            listView1.Clear();
            listView1.View = View.Details;
            listView1.Columns.Add("Alien Crew Name", -2, HorizontalAlignment.Left);
        }

        private void avatarbutton_Click(object sender, EventArgs e)
        {
            EquipButton.Visible = true;
            EquipButton.Enabled = true;
            BuyButton.Enabled = false;
            BuyButton.Visible = false;
            listView1.Clear();
            isAvatar = true;
            isMusic = false;
            isDecks = false;
            isShop = false;
            listView1.View = View.Details;
            listView1.Columns.Add("Avatar Name", -2, HorizontalAlignment.Left);
            empty = false;
            StreamReader avatarFile = new StreamReader("avatarsTxt.txt");
            while (!empty)
            {
                lines = avatarFile.ReadLine();
                if (lines == null)
                {
                    empty = true;
                    break;
                }
                Console.WriteLine(lines);
                ListViewItem item = new ListViewItem(lines);
                listView1.Items.Add(item);
            }
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (isMusic | isShop) 
            {
                tryItButton.Enabled = true;
                tryItButton.Visible = true;
            }
            else
            {
                return;
            }
        }

        private void EquipButton_Click(object sender, EventArgs e)
        {
            string avatemp = listView1.SelectedItems[0].Text;
            avatemp = avatemp.Replace(" ", string.Empty);
            Console.WriteLine(avatemp);

        }
    }
}
