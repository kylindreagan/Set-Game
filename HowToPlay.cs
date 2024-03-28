using System.Drawing;
using System.Windows.Forms;

namespace setJunior
{
    public partial class HowToPlay : Form
    {
        public HowToPlay()
        {
            InitializeComponent();
            string avatarName = Properties.Settings.Default.avatarStr;
            AvatarPB.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(avatarName);
        }

        private void RulesButton_Click(object sender, System.EventArgs e)
        {
            if (rules.Visible)
            {
                rules.Visible = false;
            }
            else
            {
                tipsBox.Visible = false;
                rules.Visible=true;
            }
        }

        private void TipsButton_Click(object sender, System.EventArgs e)
        {
            if (tipsBox.Visible) 
            { 
                tipsBox.Visible = false;
            }
            else
            {
                tipsBox.Visible = true;
                rules.Visible = false;
            }
        }
    }
}
