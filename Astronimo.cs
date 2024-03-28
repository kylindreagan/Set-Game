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
