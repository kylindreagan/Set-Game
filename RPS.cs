using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace setJunior
{
    public partial class RPS : Form
    {
        int playerChoice;
        int earnings = 0;
        Random astronimosChoice = new Random();
        public RPS()
        {
            InitializeComponent();
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
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
            label2.Visible = true;
            earnLabel.Visible = true;

        }

        private void ROCKbutton_Click(object sender, EventArgs e)
        {
            int tempChoice = astronimosChoice.Next(0,4);
            if (tempChoice == 0) 
            {
                label1.Text = "YOU WIN";
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
                }
                else if (dialogResult == DialogResult.No)
                {
                    label1.Text = "Meow! Thanks for playing! Let's go again sometime!";
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
                    earnLabel.Text = "0";
                }
                

            }
            else if (tempChoice == 1)
            {
                label1.Text = "TIE. GO AGAIN!";
            }
            else
            {
                label1.Text = "SORRY. YOU LOSE";
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
                earnLabel.Text = "0";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void PAPERbutton_Click(object sender, EventArgs e)
        {
            //Rigged for the kids
            int tempChoice = astronimosChoice.Next(0, 4);
            if (tempChoice == 0)
            {
                label1.Text = "YOU WIN";
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
                }
                else if (dialogResult == DialogResult.No)
                {
                    label1.Text = "Meow! Thanks for playing! Let's go again sometime!";
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
                    earnLabel.Text = "0";
                }


            }
            else if (tempChoice == 1)
            {
                label1.Text = "TIE. GO AGAIN!";
            }
            else
            {
                label1.Text = "SORRY. YOU LOSE";
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
                earnLabel.Text = "0";
            }
        }

        private void SCISSORSbutton_Click(object sender, EventArgs e)
        {
            int tempChoice = astronimosChoice.Next(0, 4);
            if (tempChoice == 0)
            {
                label1.Text = "YOU WIN";
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
                }
                else if (dialogResult == DialogResult.No)
                {
                    label1.Text = "Meow! Thanks for playing! Let's go again sometime!";
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
                    earnLabel.Text = "0";
                }


            }
            else if (tempChoice == 1)
            {
                label1.Text = "TIE. GO AGAIN!";
            }
            else
            {
                label1.Text = "SORRY. YOU LOSE";
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
                earnLabel.Text = "0";
            }
        }
    } 
}
