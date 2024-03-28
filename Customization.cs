using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using setJunior.Properties;
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
        MySqlConnection connection;
        string server;
        string database;
        string user;
        string password;
        string port;
        string connectionString;
        string sslM;

        bool isPlaying = true;
        bool isAvatar = false;
        bool isMusic = false;
        bool isDecks = false;
        bool isShop = false;
        bool isTesting = false;
        bool empty;

        SoundPlayer shopMusic;
        string musicName = Properties.Settings.Default.musicStr + "1";
        string lines;
        public Customization()
        {
            InitializeComponent();
            spacebuxlbl.Text = Properties.Settings.Default.SpaceBux.ToString();
            shopMusic = new SoundPlayer((System.IO.Stream)Properties.Resources.ResourceManager.GetObject(musicName));
            shopMusic.PlayLooping();

        }

        //shop button. I am bad at remembering to name things
        private void button4_Click(object sender, EventArgs e)
        {
            loadShop();
        }
        private void loadShop()
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
            server = "localhost";
            database = "set";
            user = "root";
            password = "root";
            port = "8889";
            sslM = "none";
            connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "user=" + user + ";" + "PASSWORD=" + password + ";";
            try
            {

                listView1.View = View.Details;
                connection = new MySqlConnection(connectionString);
                String shopitem, cost;
                String sql = "SELECT ItemName, ItemPrice from shop order by ItemPrice DESC;";
                MySqlCommand command = new MySqlCommand(sql, connection);
                connection.Open();
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        shopitem = reader["ItemName"].ToString();
                        cost = reader["ItemPrice"].ToString();
                        ListViewItem item = new ListViewItem(cost);
                        item.SubItems.Add(shopitem);
                        listView1.Items.Add(item);
                    }
                }
                connection.Close();
                listView1.Columns.Add("Cost", -1, HorizontalAlignment.Left);
                listView1.Columns.Add("Name", -2, HorizontalAlignment.Right);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured! " + ex.ToString());
            }
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
                ListViewItem item = new ListViewItem(lines);
                listView1.Items.Add(item);
            }
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (isMusic)
            {
                tryItButton.Enabled = true;
                tryItButton.Visible = true;
            }
            else
            {
                tryItButton.Enabled = false;
                tryItButton.Visible = false;
            }
        }

        private void EquipButton_Click(object sender, EventArgs e)
        {
            string custotemp = listView1.SelectedItems[0].Text;
            custotemp = custotemp.Replace(" ", string.Empty);
            Console.WriteLine(custotemp);
            if (isAvatar == true)
            {
                Properties.Settings.Default.avatarStr = custotemp;
                Properties.Settings.Default.Save();
            }
            else if (isMusic == true)
            {
                if (isPlaying == false)
                {
                    DialogResult dialogResult = MessageBox.Show("Please unmute music before attempting to change tunes!", "Error: Music Muted", MessageBoxButtons.OK);
                }
                else
                {
                    string musicName = Properties.Settings.Default.musicStr + "1";
                    shopMusic = new SoundPlayer((System.IO.Stream)Properties.Resources.ResourceManager.GetObject(musicName));
                    shopMusic.PlayLooping();
                    Properties.Settings.Default.musicStr = custotemp;
                    Properties.Settings.Default.Save();
                }
            }
            else if (isDecks == true)
            {
                if (1 == 0)
                {
                    Properties.Settings.Default.deckStr = custotemp;
                    Properties.Settings.Default.Save();
                }
            }
        }

        private void tryItButton_Click(object sender, EventArgs e)
        {
            if (isTesting == false && isPlaying == true)
            {
                SoundPlayer temp = new SoundPlayer();
                string musicTemp = listView1.SelectedItems[0].Text;
                musicTemp = musicTemp.Replace(" ", string.Empty);
                temp = new SoundPlayer((System.IO.Stream)Properties.Resources.ResourceManager.GetObject(musicTemp));
                temp.PlayLooping();
                isTesting = true;
            }
            else if (isPlaying == false)
            {
                DialogResult dialogResult = MessageBox.Show("Please unmute music before attempting to play!", "Error: Music Muted", MessageBoxButtons.OK);
            }
            else
            {
                string musicName = Properties.Settings.Default.musicStr + "1";
                shopMusic = new SoundPlayer((System.IO.Stream)Properties.Resources.ResourceManager.GetObject(musicName));
                shopMusic.PlayLooping();
                isTesting = false;
            }
        }

        private void BuyButton_Click(object sender, EventArgs e)
        {

            if (int.Parse(listView1.SelectedItems[0].Text) <= Properties.Settings.Default.SpaceBux)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to purchase thus item?", "You cannot undo this action!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    server = "localhost";
                    database = "set";
                    user = "root";
                    password = "root";
                    port = "8889";
                    sslM = "none";
                    connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "user=" + user + ";" + "PASSWORD=" + password + ";";
                    Properties.Settings.Default.SpaceBux -= int.Parse(listView1.SelectedItems[0].Text);
                    string itemnamecap = listView1.SelectedItems[0].SubItems[1].Text;
                    string itemname = itemnamecap.ToLower();
                    if (itemname.Contains("music"))
                    {
                        try
                        {
                            connection = new MySqlConnection(connectionString);
                            connection.Open();
                            String sql = "DELETE FROM shop WHERE ItemName = '" + itemnamecap + "';";
                            Console.WriteLine(sql);
                            Console.WriteLine(itemnamecap);
                            MySqlCommand command = new MySqlCommand(sql, connection);
                            command.ExecuteNonQuery();
                            connection.Close();
                            using (StreamWriter sw = File.AppendText("musicTxt.txt"))
                            {
                                sw.WriteLine("" + itemnamecap);
                            }
                            spacebuxlbl.Text = Properties.Settings.Default.SpaceBux.ToString();
                            loadShop();

                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.ToString());
                            MessageBox.Show("Error occured! " + ex.ToString());
                        }
                    }
                    else if (itemname.Contains("avatar"))
                    {
                        try
                        {
                            connection = new MySqlConnection(connectionString);
                            connection.Open();
                            String sql = "DELETE FROM shop WHERE ItemName = '" + itemnamecap + "';";
                            Console.WriteLine(sql);
                            Console.WriteLine(itemnamecap);
                            MySqlCommand command = new MySqlCommand(sql, connection);
                            command.ExecuteNonQuery();
                            connection.Close();
                            using (StreamWriter sw = File.AppendText("avatarsTxt.txt"))
                            {
                                sw.WriteLine("" + itemnamecap);
                            }
                            spacebuxlbl.Text = Properties.Settings.Default.SpaceBux.ToString();
                            loadShop();

                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.ToString());
                            MessageBox.Show("Error occured! " + ex.ToString());
                        }
                    }
                    else
                    {
                        DialogResult diares = MessageBox.Show("Something went wrong!", "Don't worry, this is on us!", MessageBoxButtons.OK);
                        Properties.Settings.Default.SpaceBux += int.Parse(listView1.SelectedItems[0].Text) * 2;
                    }

                }


                else if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }
            else
            {
                DialogResult diares = MessageBox.Show("Sorry, you don't have enough spacebux!", "Come back later!", MessageBoxButtons.OK);
            }
        }

        private void Customization_Load(object sender, EventArgs e)
        {

        }
    }
}
