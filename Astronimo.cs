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
    public partial class Astronimo : Form
    {
        public Astronimo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.Visible == false)
            {
                comboBox1.Visible = true;
                button3.Text = "Stop Talking to Astronimo";

            }
            else
            { comboBox1.Visible = false; }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    AstronimoSpeech.Text = "Nyallo! I hope you enjoy Set Wars :)";
                    break;
                default:
                    AstronimoSpeech.Text = "Nyallo! I'm Astronimo, your furry AI companion! \r\nYou can play with me in between games of Set Wars!";
                    break;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            RPS form = new RPS();
            form.Refresh();
            form.ShowDialog();
            form.Dispose();
        }
    }
}
