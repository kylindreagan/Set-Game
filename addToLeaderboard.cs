using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProfanityFilter;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System.IO;

namespace setJunior
{
    public partial class addToLeaderboard : Form
    {
        string name;
        int score;
        string nameTest;
        MySqlConnection connection;
        string server;
        string database;
        string user;
        string password;
        string port;
        string connectionString;
        string sslM;
        public addToLeaderboard()
        {
            InitializeComponent();

        }

        private bool testNames(string str)
        {
            int numsTotal = 0;
            int len = str.Length;
            foreach (char c in str)
            {
                if (char.IsDigit(c))
                {
                    numsTotal++;
                }
            }
            if (numsTotal >= 8)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private string DupeKiller(string str)
        {
            var strResult = new StringBuilder();

            foreach (var element in str.ToCharArray())
            {
                if (strResult.Length == 0 || strResult[strResult.Length - 1] != element)
                    strResult.Append(element);
            }
            var result = strResult.ToString();
            return result;
        }
        private void leaderboard()
        {
            server = "localhost";
            database = "set";
            user = "root";
            password = "root";
            port = "8889";
            sslM = "none";
            connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "user=" + user + ";" + "PASSWORD=" + password + ";";
            try
            {
                connection = new MySqlConnection(connectionString);
                
                String sql = "INSERT INTO leaderboard (player_name, score) VALUES ('" + name + "', " + score + ");";
                MySqlCommand command = new MySqlCommand(sql, connection);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (MySqlException)
            {
                MessageBox.Show("Error connecting to the servers");
            }
            StreamWriter logFile1 = new StreamWriter("localNames.txt", true);
            StreamWriter logFile2 = new StreamWriter("localScores.txt", true);
            logFile1.WriteLine(name);
            logFile2.WriteLine(score);
            logFile1.Close();
            logFile2.Close();
            Console.WriteLine(name, score);
        }
        private async void nameEntry()
        {
            var filter = new ProfanityFilter.ProfanityFilter();
            filter.RemoveProfanity("butt");
            filter.RemoveProfanity("poo");
            filter.RemoveProfanity("poop");
            filter.RemoveProfanity("fart");
            name = nameTB.Text;
            score = Properties.Settings.Default.tempScore;
            string tempName = DupeKiller(name);
            nameTest = name.Replace(" ", string.Empty).Replace("1", "i").Replace("0", "o").Replace("3", "e").Replace("4", "a").Replace("5", "s").Replace("$","s").Replace("@", "a").Replace("9", "g");
            if (name.Replace(" ", string.Empty).Length == 0)
            {
                DialogResult dialogResult = MessageBox.Show("Please enter a name", "Namespace Blank", MessageBoxButtons.OK);
            }
            else if (filter.ContainsProfanity(name.ToLower()) || filter.ContainsProfanity(nameTest) || filter.ContainsProfanity(tempName))
            {
                DialogResult dialogResult = MessageBox.Show("Banned word detected. Please try again.", "Profanity detected", MessageBoxButtons.OK);
            }
            else if (name.Length > 15)
            {
                DialogResult dialogResult = MessageBox.Show("Name too long. Please try again.", "Length Error", MessageBoxButtons.OK);
            }
            else
            {
                if (name.Length >= 8 && name.Any(char.IsDigit) || name.Contains("@"))
                {
                    if (testNames(name) || name.Contains("@"))
                    {
                        DialogResult dialogResult = MessageBox.Show("Name might contain identifying information. Are you still ok with uploading this?", "Please be careful", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.No) 
                        {
                            return;
                        }
                    }
                    
                }
                leaderboard();
                await Task.Delay(1000);
                this.Close();
            }

        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                nameEntry();
            }
        }

        private void entryButton_Click(object sender, EventArgs e)
        {
            nameEntry();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("You will NOT be saved to the leaderboard if you hit yes!", "Are you sure you want to leave?", MessageBoxButtons.YesNo);
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
    }
}
