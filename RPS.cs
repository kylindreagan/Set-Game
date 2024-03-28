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
using System.Threading;

namespace setJunior
{
    public partial class RPS : Form
    {
        int earnings = 0;
        float temp;
        Random astronimosChoice = new Random();
        SoundPlayer drumRoll = new SoundPlayer(Properties.Resources.DrumRoll);
        SoundPlayer RPSbg = new SoundPlayer(Properties.Resources.minigame);
        public RPS()
        {
            InitializeComponent();
            label4.Text = Properties.Settings.Default.SpaceBux.ToString();
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine(Properties.Settings.Default.SpaceBux);
            if (Properties.Settings.Default.SpaceBux >= 5)
            {
                if (Properties.Settings.Default.globalTired == 100)
                {
                    MessageBox.Show("Please play a few games of set and come back later!", "Astronimo is too tired to play right now.", MessageBoxButtons.OK);
                    this.Close();
                }
                else
                {
                    Properties.Settings.Default.SpaceBux -= 5;
                    Properties.Settings.Default.Save();
                    ROCKbutton.Visible = true;
                    ROCKbutton.Enabled = true;
                    PAPERbutton.Visible = true;
                    PAPERbutton.Enabled = true;
                    SCISSORSbutton.Visible = true;
                    SCISSORSbutton.Enabled = true;
                    PlayButton.Enabled = false;
                    PlayButton.Visible = false;
                    astronimoPic.Visible = true;
                    label1.Text = "Meow! Let's Play!";
                    RPSbg.PlayLooping();
                    label2.Visible = true;
                    earnLabel.Visible = true;
                    label5.Visible = false;
                    label4.Visible = false;
                }

            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Not enough SpaceBux!", "Uh oh!", MessageBoxButtons.OK);
            }
        }
        private async void ROCKbutton_Click(object sender, EventArgs e)
        {
            label1.Text = "Astronimo has chosen...";
            drumRoll.Play();
            int tempChoice = astronimosChoice.Next(0,4);
            await Task.Delay(4000);
            if (tempChoice > 1) 
            {
                label3.Text = "SCISSORS!";
                await Task.Delay(1000);
                label1.Text = "YOU WIN";
                label3.Text = "That was fun! Meow!";
                if (earnings == 0)
                {
                    earnings++;
                }
                else
                {
                    earnings *= 2;
                }
                earnLabel.Text = earnings.ToString();
                DialogResult dialogResult = MessageBox.Show("GO AGAIN?", "If you lose, you will lose all SpaceBux gained up to this point", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    label1.Text = "Meow! Let's Play!";
                    RPSbg.PlayLooping();
                }
                else if (dialogResult == DialogResult.No)
                {
                    label1.Text = "Meow! Thanks for playing! Let's go again sometime!";

                    temp = earnings * (Properties.Settings.Default.globalHappy + 1);
                    temp = (float)Math.Round(temp, 0);
                    Properties.Settings.Default.SpaceBux += ((int)temp);
                    earnings = 0;
                    if (Properties.Settings.Default.globalTired < 95)
                    { 
                        Properties.Settings.Default.globalTired += 5;
                        
                    }
                    else Properties.Settings.Default.globalTired = 100;
                    if (Properties.Settings.Default.globalHappy < .80)
                    {
                        Properties.Settings.Default.globalHappy += .20f;
                    }
                    else Properties.Settings.Default.globalHappy = 100;
                    ROCKbutton.Visible = false;
                    ROCKbutton.Enabled = false;
                    PAPERbutton.Visible = false;
                    PAPERbutton.Enabled = false;
                    SCISSORSbutton.Visible = false;
                    SCISSORSbutton.Enabled = false;
                    astronimoPic.Visible = false;
                    PlayButton.Enabled = true;
                    PlayButton.Visible = true;
                    label2.Visible = false;
                    earnLabel.Visible = false;
                    label3.Visible = true;
                    label4.Visible = true;
                    earnLabel.Text = "0";
                    await Task.Delay(500);
                    label1.Text = "ROCK PAPER SCISSORS";
                    label3.Text = "For each win, your earnings double.\r\nBut, if you lose, you lose it all!\r\n";
                    Properties.Settings.Default.Save();
                }
                

            }
            else if (tempChoice == 1)
            {
                label3.Text = "ROCK!";
                await Task.Delay(1000);
                label1.Text = "TIE. GO AGAIN!";
                RPSbg.PlayLooping();
            }
            else
            {
                label3.Text = "PAPER!";
                await Task.Delay(1000);
                label1.Text = "SORRY. YOU LOSE";
                Properties.Settings.Default.globalTired += 10;
                earnings = 0;
                ROCKbutton.Visible = false;
                ROCKbutton.Enabled = false;
                PAPERbutton.Visible = false;
                PAPERbutton.Enabled = false;
                SCISSORSbutton.Visible = false;
                SCISSORSbutton.Enabled = false;
                astronimoPic.Visible = false;
                PlayButton.Enabled = true;
                PlayButton.Visible = true;
                label2.Visible = false;
                earnLabel.Visible = false;
                label5.Visible = true;
                label4.Visible = true;
                earnLabel.Text = "0";
                await Task.Delay(500);
                label1.Text = "ROCK PAPER SCISSORS";
                label3.Text = "For each win, your earnings double.\r\nBut, if you lose, you lose it all!\r\n";
                Properties.Settings.Default.Save();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private async void PAPERbutton_Click(object sender, EventArgs e)
        {
            label1.Text = "Astronimo has chosen...";
            drumRoll.Play();
            int tempChoice = astronimosChoice.Next(0, 4);
            await Task.Delay(4000);
            if (tempChoice > 1)
            {
                label3.Text = "ROCK";
                await Task.Delay(1000);
                label1.Text = "YOU WIN";
                label3.Text = "That was fun! Meow!";
                if (earnings == 0)
                {
                    earnings++;
                }
                else
                {
                    earnings *= 2;
                }
                earnLabel.Text = earnings.ToString();
                DialogResult dialogResult = MessageBox.Show("GO AGAIN?", "If you lose, you will lose all SpaceBux gained up to this point", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    label1.Text = "Meow! Let's Play!";
                    RPSbg.PlayLooping();
                }
                else if (dialogResult == DialogResult.No)
                {
                    label1.Text = "Meow! Thanks for playing! Let's go again sometime!";
                    temp = earnings * (Properties.Settings.Default.globalHappy + 1);
                    temp = (float)Math.Round(temp, 0);
                    Properties.Settings.Default.SpaceBux += ((int)temp);
                    if (Properties.Settings.Default.globalTired < 95)
                    {
                        Properties.Settings.Default.globalTired += 5;

                    }
                    else Properties.Settings.Default.globalTired = 100;
                    if (Properties.Settings.Default.globalHappy < .80)
                    {
                        Properties.Settings.Default.globalHappy += .20f;
                    }
                    else Properties.Settings.Default.globalHappy = 100;
                    earnings = 0;
                    ROCKbutton.Visible = false;
                    ROCKbutton.Enabled = false;
                    PAPERbutton.Visible = false;
                    PAPERbutton.Enabled = false;
                    SCISSORSbutton.Visible = false;
                    SCISSORSbutton.Enabled = false;
                    astronimoPic.Visible = false;
                    PlayButton.Enabled = true;
                    PlayButton.Visible = true;
                    label2.Visible = false;
                    earnLabel.Visible = false;
                    label5.Visible = true;
                    label4.Visible = true;
                    earnLabel.Text = "0";
                    await Task.Delay(500);
                    label1.Text = "ROCK PAPER SCISSORS";
                    label3.Text = "For each win, your earnings double.\r\nBut, if you lose, you lose it all!\r\n";
                    Properties.Settings.Default.Save();
                }


            }
            else if (tempChoice == 1)
            {
                label3.Text = "PAPER!";
                await Task.Delay(1000);
                label1.Text = "TIE. GO AGAIN!";
                RPSbg.PlayLooping();
            }
            else
            {
                label3.Text = "SCISSORS!";
                await Task.Delay(1000);
                label1.Text = "SORRY. YOU LOSE";
                Properties.Settings.Default.globalTired += 10;
                earnings = 0;
                ROCKbutton.Visible = false;
                ROCKbutton.Enabled = false;
                PAPERbutton.Visible = false;
                PAPERbutton.Enabled = false;
                SCISSORSbutton.Visible = false;
                SCISSORSbutton.Enabled = false;
                astronimoPic.Visible = false;
                PlayButton.Enabled = true;
                PlayButton.Visible = true;
                label2.Visible = false;
                earnLabel.Visible = false;
                label5.Visible = true;
                label4.Visible = true;
                earnLabel.Text = "0";
                await Task.Delay(500);
                label1.Text = "ROCK PAPER SCISSORS";
                Properties.Settings.Default.Save();
            }
        }

        private async void SCISSORSbutton_Click(object sender, EventArgs e)
        {
            label1.Text = "Astronimo has chosen...";
            drumRoll.Play();
            int tempChoice = astronimosChoice.Next(0, 4);
            await Task.Delay(4000);
            if (tempChoice > 1)
            {
                label3.Text = "PAPER!";
                await Task.Delay(1000);
                label1.Text = "YOU WIN";
                label3.Text = "That was fun! Meow!";
                if (earnings == 0)
                {
                    earnings++;
                }
                else
                {
                    earnings *= 2;
                }
                earnLabel.Text = earnings.ToString();
                DialogResult dialogResult = MessageBox.Show("GO AGAIN?", "If you lose, you will lose all SpaceBux gained up to this point", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    label1.Text = "Meow! Let's Play!";
                    RPSbg.PlayLooping();
                    label3.Text = "";
                }
                else if (dialogResult == DialogResult.No)
                {
                    label1.Text = "Meow! Thanks for playing! Let's go again sometime!";
                    label3.Text = "";
                    temp = earnings * (Properties.Settings.Default.globalHappy + 1);
                    temp = (float)Math.Round(temp, 0);
                    Properties.Settings.Default.SpaceBux += ((int)temp);
                    earnings = 0;
                    if (Properties.Settings.Default.globalTired < 95)
                    {
                        Properties.Settings.Default.globalTired += 5;

                    }
                    else Properties.Settings.Default.globalTired = 100;
                    if (Properties.Settings.Default.globalHappy < .80)
                    {
                        Properties.Settings.Default.globalHappy += .20f;
                    }
                    else Properties.Settings.Default.globalHappy = 100;
                    ROCKbutton.Visible = false;
                    ROCKbutton.Enabled = false;
                    PAPERbutton.Visible = false;
                    PAPERbutton.Enabled = false;
                    SCISSORSbutton.Visible = false;
                    SCISSORSbutton.Enabled = false;
                    astronimoPic.Visible = false;
                    PlayButton.Enabled = true;
                    PlayButton.Visible = true;
                    label2.Visible = false;
                    earnLabel.Visible = false;
                    label5.Visible = true;
                    label4.Visible = true;
                    earnLabel.Text = "0";
                    await Task.Delay(500);
                    label1.Text = "ROCK PAPER SCISSORS";
                    label3.Text = "For each win, your earnings double.\r\nBut, if you lose, you lose it all!\r\n";
                }


            }
            else if (tempChoice == 1)
            {
                label3.Text = "SCISSORS!";
                await Task.Delay(1000);
                label3.Text = "";
                label1.Text = "TIE. GO AGAIN!";
                RPSbg.PlayLooping();
            }
            else
            {
                label3.Text = "ROCK!";
                await Task.Delay(1000);
                label1.Text = "SORRY. YOU LOSE";
                label3.Text = "Meow! Thanks for playing! Let's go again sometime!";
                Properties.Settings.Default.globalTired += 10;
                earnings = 0;
                ROCKbutton.Visible = false;
                ROCKbutton.Enabled = false;
                PAPERbutton.Visible = false;
                PAPERbutton.Enabled = false;
                SCISSORSbutton.Visible = false;
                SCISSORSbutton.Enabled = false;
                astronimoPic.Visible = false;
                PlayButton.Enabled = true;
                PlayButton.Visible = true;
                label2.Visible = false;
                earnLabel.Visible = false;
                label5.Visible = true;
                label4.Visible = true;
                earnLabel.Text = "0";
                await Task.Delay(500);
                label1.Text = "ROCK PAPER SCISSORS";
                label3.Text = "For each win, your earnings double.\r\nBut, if you lose, you lose it all!\r\n";
                Properties.Settings.Default.Save();
            }
        }

        private void earnLabel_Click(object sender, EventArgs e)
        {

        }

        private void RPS_Load(object sender, EventArgs e)
        {

        }
    } 
}
