using MySql.Data.MySqlClient;
using setJunior.Properties;
using System;
using System.IO;
using System.Collections.Generic;
using System.Media;
using System.Windows.Forms;
using SharpDX.X3DAudio;

namespace setJunior
{
    public partial class Leaderboard : Form
    {
        MySqlConnection connection;
        string server;
        string database;
        string user;
        string password;
        string port;
        string connectionString;
        string sslM;
        SoundPlayer HOFMusic = new SoundPlayer(setJunior.Properties.Resources.Leaderboard);
        bool isPlaying = true;
        public Leaderboard()
        {
            InitializeComponent();
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
                String person, score;
                listView1.View = View.Details;
                listView1.Columns.Add("Name", -2, HorizontalAlignment.Left);
                listView1.Columns.Add("SpaceBux", -2, HorizontalAlignment.Right);
                listView2.View = View.Details;
                listView2.Columns.Add("Name", -2, HorizontalAlignment.Left);
                listView2.Columns.Add("SpaceBux", -2, HorizontalAlignment.Right);
                int count = 1;
                String sql = "SELECT player_name, score from leaderboard order by score desc";
                MySqlCommand command = new MySqlCommand(sql, connection);
                connection.Open();
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read() && count <= 10)
                    {
                        person = reader["player_name"].ToString();
                        score = reader["score"].ToString();
                        ListViewItem item = new ListViewItem(person);
                        item.SubItems.Add(score);
                        listView1.Items.Add(item);
                        count += 1;
                    }
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured! " + ex.ToString());
            }
            HOFMusic.PlayLooping();
            try
            {
                StreamReader logFile1 = new StreamReader("localNames.txt");
                StreamReader logFile2 = new StreamReader("localScores.txt");
                int count = 0;
                string line1;
                string line2;
                bool empty = false;
                while (!empty && count <= 10)
                {

                    line1 = logFile1.ReadLine();
                    if (line1 == null)
                    {
                        empty = true;
                        break;
                    }
                    line2 = logFile2.ReadLine();
                    ListViewItem item = new ListViewItem(line1);
                    item.SubItems.Add(line2);
                    listView2.Items.Add(item);
                    count += 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured! " + ex.ToString());
            }
        }

        

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (isPlaying)
            {
                pictureBox3.Image = setJunior.Properties.Resources.Mute_Unmute;
                HOFMusic.Stop();
                isPlaying = false;
            }
            else
            {
                pictureBox3.Image = setJunior.Properties.Resources.Music_Mute;
                HOFMusic.PlayLooping();
                isPlaying = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
