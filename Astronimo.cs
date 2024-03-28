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
        int tired;
        public Astronimo()
        {
            tired = Properties.Settings.Default.globalTired;
            InitializeComponent();
            tiredMeter.Value = tired;
        }

        private void button1_Click(object sender, EventArgs e)
        {

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
                    button3.Text = "Stop Talking to Astronimo";

                }
                else
                {
                    textBox1.Visible = false;
                    button3.Text = "Talk to Astronimo";
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
            Properties.Settings.Default.globalTired += 1;
            tiredMeter.Value += 1;
        }
    }
}
