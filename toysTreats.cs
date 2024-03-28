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
    public partial class toysTreats : Form
    {
        List<string> prices = new List<string>();
        List<string> names = new List<string>();
        public toysTreats()
        {
            names.Add("fish treat");
            names.Add("alien treat");
            names.Add("wind up mouse");
            names.Add("alien squeaky toy");
            prices.Add("25");
            prices.Add("25");
            prices.Add("50");
            InitializeComponent();
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

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listView1.SelectedItems.ToString())
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
                    break;
            }
        }
    }
}
