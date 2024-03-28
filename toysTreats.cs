using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace setJunior
{
    public partial class toysTreats : Form
    {
        List<string> prices = new List<string>();
        List<string> names = new List<string>();
        string name;
        public toysTreats()
        {
            names.Add("fish treat");
            names.Add("alien treat");
            names.Add("wind up mouse");
            names.Add("alien squeaky toy");
            prices.Add("25");
            prices.Add("50");
            prices.Add("25");
            prices.Add("50");
            InitializeComponent();
            spacebuxlbl.Text = Properties.Settings.Default.SpaceBux.ToString();
            listView1.View = View.Details;
            for (int i = 0; i < names.Count; i++)
            {
                ListViewItem item = new ListViewItem(names[i]);
                item.SubItems.Add(prices[i]);
                listView1.Items.Add(item);
            }
            listView1.Columns.Add("Name", -1, HorizontalAlignment.Left);
            listView1.Columns.Add("Cost", -2, HorizontalAlignment.Right);
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            if (int.Parse(listView1.SelectedItems[0].SubItems[1].Text) <= Properties.Settings.Default.SpaceBux)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to purchase thus item?", "You cannot undo this action!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    name = listView1.SelectedItems[0].Text;
                    Properties.Settings.Default.SpaceBux -= int.Parse(listView1.SelectedItems[0].SubItems[1].Text);
                    switch (name)
                    {
                        case "fish treat":
                            if (Properties.Settings.Default.globalTired >= 20) Properties.Settings.Default.globalTired -= 20;
                            else Properties.Settings.Default.globalTired = 0;
                            break;
                        case "wind up mouse":
                            if (Properties.Settings.Default.globalHappy <= .8f) Properties.Settings.Default.globalHappy += .20f;
                            else Properties.Settings.Default.globalHappy = 1;
                            break;
                        case "alien squeaky toy":
                            if (Properties.Settings.Default.globalHappy <= .50f) Properties.Settings.Default.globalHappy *= 2;
                            else Properties.Settings.Default.globalHappy = 1;
                            break;
                        case "alien treat":
                            Properties.Settings.Default.globalTired /= 2;
                            break;
                        default:
                            label1.Text = "";
                            DialogResult diares = MessageBox.Show("Something went wrong!", "Don't worry, this is on us!", MessageBoxButtons.OK);
                            Properties.Settings.Default.SpaceBux += int.Parse(listView1.SelectedItems[0].SubItems[1].Text);
                            break;
                    }
                    Properties.Settings.Default.Save();
                }
            }
            else
            {
                DialogResult diares = MessageBox.Show("Sorry, you don't have enough spacebux!", "Come back later!", MessageBoxButtons.OK);
            }
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                name = listView1.SelectedItems[0].Text;
                switch (name)
                {
                    case "fish treat":
                        label1.Text = "Decrease tiredness by 20 points";
                        break;
                    case "wind up mouse":
                        label1.Text = "Increase happiness by 20 points";
                        break;
                    case "alien squeaky toy":
                        label1.Text = "Doubles happiness";
                        break;
                    case "alien treat":
                        label1.Text = "Halves tiredness";
                        break;
                    default:
                        label1.Text = "";
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
          }

        private void Quit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("If you're in the middle of a game, you will lose all SpaceBux you have gained so far!", "Are you sure you want to leave?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
                

            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }
    }
    }