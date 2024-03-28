using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace setJunior
{
    public partial class Astronimo : Form
    {
        
        int tired;
        float happy;
        SoundPlayer meow = new SoundPlayer(Properties.Resources.MEOW);
        public Astronimo()
        {
            Properties.Settings.Default.globalHappy = .5f;
            tired = Properties.Settings.Default.globalTired;
            happy = Properties.Settings.Default.globalHappy;
            InitializeComponent();
            tiredMeter.Value = tired;
            happyMeter.Value = ((int)(happy*100));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            toysTreats form = new toysTreats();
            form.Refresh();
            form.ShowDialog();
            form.Dispose();
            tired = Properties.Settings.Default.globalTired;
            tiredMeter.Value = tired;
            happy = Properties.Settings.Default.globalHappy;
            happyMeter.Value = ((int)(happy * 100));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.globalTired == 100)
            {
                MessageBox.Show("Please play a few games of set and come back later!", "Astronimo is too tired to talk right now.", MessageBoxButtons.OK);
            }
            else
            {
                if (textBox1.Visible == false)
                {
                    textBox1.Visible = true;
                    textBox1.Enabled = true;
                    button4.Visible = true;
                    button4.Enabled = true;
                    button3.Text = "Stop Talking to Astronimo";

                }
                else
                {
                    textBox1.Visible = false;
                    textBox1.Enabled = false;
                    button4.Visible = false;
                    button4.Enabled = false;
                    button3.Text = "Talk to Astronimo";
                    AstronimoSpeech.Text = "Mewllo! I'm Astronimo, your furry virtual companion! \r\nYou can play with me in between games of Set Wars!";
                }
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (Properties.Settings.Default.globalTired == 100)
            {
                MessageBox.Show("Please play a few games of set and come back later!", "Astronimo is too tired to play right now.", MessageBoxButtons.OK);
            }
            else
            {
                RPS form = new RPS();
                form.Refresh();
                form.ShowDialog();
                form.Dispose();
                tired = Properties.Settings.Default.globalTired;
                tiredMeter.Value = tired;
                happy = Properties.Settings.Default.globalHappy;
                happyMeter.Value = ((int)(happy * 100));
            }

        }

        private void tiredMeter_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.globalTired < 100 && Properties.Settings.Default.globalTired < 97)
            {
                Properties.Settings.Default.globalTired += 1;
                tiredMeter.Value += 1;
                Properties.Settings.Default.globalHappy += .03f;
                happyMeter.Value += 3;
                Properties.Settings.Default.Save();
            }
            meow.Play();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (textBox1.Visible == true)
            { 
                if (e.KeyCode == Keys.Enter)
                {
                    string dialog = textBox1.Text.ToLower();
                    chattyCatty(dialog);
                }
            }
        }

        private void chattyCatty(string dialog)
        {
            if (Properties.Settings.Default.globalHappy == 0 || Properties.Settings.Default.globalTired == 100)
            {
                AstronimoSpeech.Text = "Sorry.. I don't feel like talking right now.. Meow..";
            }
            else 
            {
                if (dialog == "")
                {
                    AstronimoSpeech.Text = "Sorry! I couldn't hear you!";
                }
                else if (dialog.Contains("i am good") || dialog.Contains("im good") || dialog.Contains("i'm good"))
                {
                    AstronimoSpeech.Text = "Great to hear!";
                }
                else if (dialog.Contains("hello") || dialog.Contains("hi") || dialog.Contains("hey"))
                {
                    AstronimoSpeech.Text = "Mewllo! How are you?";
                }
                else if (dialog.Contains("meow"))
                {
                    AstronimoSpeech.Text = "Meow!";
                }
                else
                {

                }
                Properties.Settings.Default.globalHappy += .01f;
                happyMeter.Value += 1;
                Properties.Settings.Default.Save();
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            string dialog = textBox1.Text.ToLower();
            chattyCatty(dialog);
        }

        private void Quit_Click(object sender, EventArgs e)
        {
        this.Close();
        }
    }
}
