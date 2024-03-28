using Org.BouncyCastle.Asn1.Pkcs;
using setJunior.Properties;
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
    public partial class GameForm : Form
    {
        //number == EYES
        struct Card
        {
            public int color;
            public int shape;
            public int number;
            public string imgname;
        }
        int minute = 5;
        int secondsleft;
        int numSets, numCardsSelected;
        SoundPlayer buzzer =  new SoundPlayer(setJunior.Properties.Resources.BUZZ2);
        Card[] cards = new Card[27];
        Random random = new Random();
        PictureBox[] pictures = new PictureBox[10];
        PictureBox[] checkboxes = new PictureBox[10];
        int[] selectedCardIndices = new int[27];
        List<int> numbers = new List<int>();
        List<int> shapes = new List<int>();
        List<int> colors = new List<int>();
        bool SFX = Properties.Settings.Default.SFX;
        string difficulty;
        bool colorsRight = false;
        bool numbersRight = false;
        bool shapesRight = false;
        bool restarted = false;
        int tired;
        float happy;
        string musicName = Properties.Settings.Default.musicStr + "2";
        SoundPlayer normalbg;
        public GameForm()
        {
            InitializeComponent();
            normalbg = new SoundPlayer((System.IO.Stream)Properties.Resources.ResourceManager.GetObject(musicName));
            totalBuxLabel.Text = Properties.Settings.Default.SpaceBux.ToString();
            tired = Properties.Settings.Default.globalTired;
            happy = Properties.Settings.Default.globalHappy;
            for (int i = 0; i < 27; i++) selectedCardIndices[i] = i;
            createCards();
            createPictures();
            
        }
        private Bitmap GetImageResource(string filename)
        {
            string resourcename = filename.Substring(0, filename.IndexOf("."));
            return (Bitmap)Properties.Resources.ResourceManager.GetObject(resourcename);
        }

        private void NormieButton_Click(object sender, EventArgs e)
        {
            normalbg.PlayLooping();
            difficulty = "N";
            EasyButton.Enabled = false;
            EasyButton.Visible = false;
            NormieButton.Enabled = false;
            NormieButton.Visible = false;
            HardButton.Enabled = false;
            HardButton.Visible = false;
            comboBox1.Visible = false;
            label1.Visible = false;
            newGame();
            
        }

        private void HardButton_Click(object sender, EventArgs e)
        {
            normalbg.PlayLooping();
            difficulty = "H";
            EasyButton.Enabled = false;
            EasyButton.Visible = false;
            NormieButton.Enabled = false;
            NormieButton.Visible = false;
            HardButton.Enabled = false;
            HardButton.Visible = false;
            comboBox1.Visible = false;
            label1.Visible = false;
            newGame();
        }
        private void createCards()
        {
            int cardnum = 0;
            for (int b = 1; b < 4; b++)
            {
                for (int j = 1; j < 4; j++)
                {
                    for (int k = 1; k < 4; k++)
                    {
                        cards[cardnum].number = b;
                        cards[cardnum].shape = j;
                        cards[cardnum].color = k;
                        cards[cardnum].imgname = "_" + b + j + k + ".jpg";
                        cardnum++;
                    }
                }
            }
        }

        private void createPictures()
        {
            for (int i = 0; i < 10; i++)
            {
                pictures[i] = new PictureBox();
                pictures[i].Width = 240;
                pictures[i].Height = 240;
                pictures[i].Image = setJunior.Properties.Resources._311; // temporary
                checkboxes[i] = new PictureBox();
                checkboxes[i].Width = 50;
                checkboxes[i].Height = 50;
                checkboxes[i].Image = setJunior.Properties.Resources.check2;
                checkboxes[i].Visible = false;
                pictures[i].Visible = false;
                this.Controls.Add(pictures[i]);
                this.Controls.Add(checkboxes[i]);
            }
            pictures[0].Location = new Point(0, 60);
            pictures[1].Location = new Point(300, 60);
            pictures[2].Location = new Point(600, 60);
            pictures[3].Location = new Point(900, 60);
            pictures[4].Location = new Point(1200, 60);
            pictures[5].Location = new Point(0, 400);
            pictures[6].Location = new Point(300, 400);
            pictures[7].Location = new Point(600, 400);
            pictures[8].Location = new Point(900, 400);
            pictures[9].Location = new Point(1200, 400);

            checkboxes[0].Location = new Point(0, 60);
            checkboxes[1].Location = new Point(300, 60);
            checkboxes[2].Location = new Point(600, 60);
            checkboxes[3].Location = new Point(900, 60);
            checkboxes[4].Location = new Point(1200, 60);
            checkboxes[5].Location = new Point(0, 400);
            checkboxes[6].Location = new Point(300, 400);
            checkboxes[7].Location = new Point(600, 400);
            checkboxes[8].Location = new Point(900, 400);
            checkboxes[9].Location = new Point(1200, 400);

            pictures[0].Click += picture_Click0;
            pictures[1].Click += picture_Click1;
            pictures[2].Click += picture_Click2;
            pictures[3].Click += picture_Click3;
            pictures[4].Click += picture_Click4;
            pictures[5].Click += picture_Click5;
            pictures[6].Click += picture_Click6;
            pictures[7].Click += picture_Click7;
            pictures[8].Click += picture_Click8;
            pictures[9].Click += picture_Click9;
        }
        private void manageClick(int i)
        {
            checkboxes[i].BringToFront();
            if (checkboxes[i].Visible)
            {
                checkboxes[i].Visible = false;
                numCardsSelected--;
                colors.Remove(cards[selectedCardIndices[i]].color);
                numbers.Remove(cards[selectedCardIndices[i]].number);
                shapes.Remove(cards[selectedCardIndices[i]].shape);

            }
            else
            {
                checkboxes[i].Visible = true;
                numCardsSelected++;
                colors.Add(cards[selectedCardIndices[i]].color);
                numbers.Add(cards[selectedCardIndices[i]].number);
                shapes.Add(cards[selectedCardIndices[i]].shape);

            }
            if (numCardsSelected == 3)
            {
                //Did they find set?
                //Y- Let know & reward
                if (difficulty == "H")
                {
                    if (((colors[0] == colors[1]) && (colors[1] == colors[2])) && (colors[0] == colors[2]) || ((colors[0] != colors[1]) && (colors[1] != colors[2]) && (colors[0] != colors[2])))
                    {
                        colorsRight = true;
                    }
                    if (((numbers[0] == numbers[1]) && (numbers[1] == numbers[2])) && (numbers[0] == numbers[2]) || ((numbers[0] != numbers[1]) && (numbers[1] != numbers[2]) && (numbers[0] != numbers[2])))
                    {
                        numbersRight = true;
                    }
                    if (((shapes[0] == shapes[1]) && (shapes[1] == shapes[2])) && (shapes[0] == shapes[2]) || ((shapes[0] != shapes[1]) && (shapes[1] != shapes[2]) && (shapes[0] != shapes[2])))
                    {
                        shapesRight = true;
                    }
                    if (colorsRight && numbersRight && shapesRight)
                    {
                        for (int b = 0; b < 10; b++)
                        {
                            checkboxes[b].Visible = false;
                        }
                        numCardsSelected = 0;
                        colors.Clear();
                        numbers.Clear();
                        shapes.Clear();
                        numSets += 3;
                        shuffleAndDeal();
                        colorsRight = false;
                        shapesRight = false;
                        numbersRight = false;
                    }
                    //N- Let know
                    else
                    {
                        for (int b = 0; b < 10; b++)
                        {
                            checkboxes[b].Visible = false;
                        }
                        numCardsSelected = 0;
                        colors.Clear();
                        numbers.Clear();
                        shapes.Clear();
                        numSets--;
                        colorsRight = false;
                        shapesRight = false;
                        numbersRight = false;
                        shuffleAndDeal();
                    }
                }
                else if (difficulty == "N")
                {
                    if (((colors[0] == colors[1]) && (colors[1] == colors[2])) && (colors[0] == colors[2]) || ((colors[0] != colors[1]) && (colors[1] != colors[2]) && (colors[0] != colors[2])))
                    {
                        colorsRight = true;
                    }
                    if (((numbers[0] == numbers[1]) && (numbers[1] == numbers[2])) && (numbers[0] == numbers[2]) || ((numbers[0] != numbers[1]) && (numbers[1] != numbers[2]) && (numbers[0] != numbers[2])))
                    {
                        numbersRight = true;
                    }
                    if (((shapes[0] == shapes[1]) && (shapes[1] == shapes[2])) && (shapes[0] == shapes[2]) || ((shapes[0] != shapes[1]) && (shapes[1] != shapes[2]) && (shapes[0] != shapes[2])))
                    {
                        shapesRight = true;
                    }
                    if (colorsRight && numbersRight && shapesRight)
                    {
                        numSets += 2;
                        for (int b = 0; b < 10; b++)
                        {
                            checkboxes[b].Visible = false;
                        }
                        numCardsSelected = 0;
                        colorsRight = false;
                        shapesRight = false;
                        numbersRight = false;
                        shapes.Clear();
                        colors.Clear();
                        numbers.Clear();
                        shuffleAndDeal();
                    }
                    else
                    {
                        DialogResult dialogResult = MessageBox.Show("Please look through the cards and try again!", "Not quite!", MessageBoxButtons.OK);
                        for (int b = 0; b < 10; b++)
                        {
                            checkboxes[b].Visible = false;
                        }
                        colorsRight = false;
                        shapesRight = false;
                        numbersRight = false;
                        shapes.Clear();
                        colors.Clear();
                        numbers.Clear();
                        numCardsSelected = 0;

                    }
                }
                else if (difficulty == "E")
                {
                    if (((colors[0] == colors[1]) && (colors[1] == colors[2]) && (colors[0] == colors[2])) || ((colors[0] != colors[1]) && (colors[1] != colors[2]) && (colors[0] != colors[2])))
                    {
                        colorsRight = true;
                    }
                    if ((((numbers[0] == numbers[1]) && (numbers[1] == numbers[2]) && (numbers[0] == numbers[2])) && (numbers[0] == numbers[2])|| ((numbers[0] != numbers[1]) && (numbers[1] != numbers[2]) && (numbers[0] != numbers[2]))))
                    {
                        numbersRight = true;
                    }
                    if (((shapes[0] == shapes[1]) && (shapes[1] == shapes[2]) && (shapes[0] == shapes[2])) || ((shapes[0] != shapes[1]) && (shapes[1] != shapes[2]) && (shapes[0] != shapes[2])))
                    {
                        shapesRight = true;
                    }
                    if (colorsRight && numbersRight && shapesRight)
                    {
                        numSets += 1;
                        for (int b = 0; b < 10; b++)
                        {
                            checkboxes[b].Visible = false;
                        }
                        colorsRight = false;
                        shapesRight = false;
                        numbersRight = false;
                        pictureBox2.Image = Properties.Resources.check2;
                        pictureBox3.Image = Properties.Resources.check2;
                        pictureBox4.Image = Properties.Resources.check2;
                        shapes.Clear();
                        colors.Clear();
                        numbers.Clear();
                        numCardsSelected = 0;
                        shuffleAndDeal();
                    }
                    else
                    {
                        if (!colorsRight)
                        {
                            pictureBox2.Image = Properties.Resources.wrong;
                        }
                        else
                        {
                            pictureBox2.Image = Properties.Resources.check2;
                        }
                        if (!numbersRight)
                        {
                            pictureBox4.Image = Properties.Resources.wrong;
                        }
                        else
                        {
                            pictureBox4.Image = Properties.Resources.check2;
                        }
                        if (!shapesRight)
                        {
                            pictureBox3.Image = Properties.Resources.wrong;
                        }
                        else
                        {
                            pictureBox3.Image = Properties.Resources.check2;
                        }
                        colorsRight = false;
                        shapesRight = false;
                        numbersRight = false;
                    }
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Something went wrong! But, don't worry, it's not your fault! Try again or get some help!", "Oopsies!", MessageBoxButtons.OK);
                    this.Close();
                }
            }
            else if (numCardsSelected > 3)
            {
                DialogResult dialogResult = MessageBox.Show("Too many cards selected! You only need 3 to make a set!", "Let's go back", MessageBoxButtons.OK);
                checkboxes[i].Visible = false;
                numCardsSelected--;
                colors.Remove(cards[selectedCardIndices[i]].color);
                numbers.Remove(cards[selectedCardIndices[i]].number);
                shapes.Remove(cards[selectedCardIndices[i]].shape);
            }
        }
        private void picture_Click0(object sender, EventArgs e)
        {
            Console.WriteLine(0);
            manageClick(0);
        }
        private void picture_Click1(object sender, EventArgs e)
        {
            Console.WriteLine(1);
            manageClick(1);
        }
        private void picture_Click2(object sender, EventArgs e)
        {
            Console.WriteLine(2);
            manageClick(2);
        }
        private void picture_Click3(object sender, EventArgs e)
        {
            Console.WriteLine(3);
            manageClick(3);
        }
        private void picture_Click4(object sender, EventArgs e)
        {
            Console.WriteLine(4);
            manageClick(4);
        }
        private void picture_Click5(object sender, EventArgs e)
        {
            Console.WriteLine(5);
            manageClick(5);
        }
        private void picture_Click6(object sender, EventArgs e)
        {
            Console.WriteLine(6);
            manageClick(6);
        }
        private void picture_Click7(object sender, EventArgs e)
        {
            Console.WriteLine(7);
            manageClick(7);
        }
        private void picture_Click8(object sender, EventArgs e)
        {
            Console.WriteLine(8);
            manageClick(8);
        }
        private void picture_Click9(object sender, EventArgs e)
        {
            Console.WriteLine(9);
            manageClick(9);
        }
        private void shuffleAndDeal()
        {
            colorsRight = false;
            shapesRight = false;
            numbersRight = false;
            buxLabel.Text = numSets.ToString();
            if (numSets < 0) buxLabel.BackColor = Color.Red;
            else buxLabel.BackColor = Color.Green;
            for (int i = 0; i < 27; i++)
            {
                int r = random.Next(27);
                int temp = selectedCardIndices[i];
                selectedCardIndices[i] = selectedCardIndices[r];
                selectedCardIndices[r] = temp;
               
            }
            for (int i = 0; i < 10; i++)
            {
                string imagename = cards[selectedCardIndices[i]].imgname;
                Console.WriteLine(imagename);
                pictures[i].Image = GetImageResource(imagename);
                //pictures[i].Image = GetImageResource("_311.jpg");
                pictures[i].Refresh();
            }
        }
        private void resetTimerLabel()
        {
            secondsleft = minute * 60;
            string labelTxt = minute.ToString();
            if (labelTxt.Length < 2) labelTxt = "0" + labelTxt;
            timerLabel.Text = labelTxt + ":00";
            timerLabel.BackColor = System.Drawing.Color.Pink;
            timerLabel.Visible = true;
            timer1.Start();
        }
        private void newGame()
        {
            numSets = numCardsSelected = 0;
            buxLabel.Visible = true;
            label2.Visible = true;
            RestartButton.Visible = true;
            RestartButton.Enabled = true;
            difficulties.Visible = false;
            totalBuxLabel.Visible = false;
            label3.Visible = false;
            for (int i = 0; i < 10; i++)
            {
                pictures[i].Visible = true;
                pictures[i].Enabled = true;
            }
            //setup
            shuffleAndDeal();
            resetTimerLabel();
        }

        private void SFXButton_Click(object sender, EventArgs e)
        {
            if (SFX)
            {
                SFXButton.Image = setJunior.Properties.Resources.UnmuteSFX;
                SFX = false;
                Properties.Settings.Default.SFX = SFX;
                Properties.Settings.Default.Save();
            }
            else
            {
                SFXButton.Image = setJunior.Properties.Resources.MuteSFX;
                SFX = true;
                Properties.Settings.Default.SFX = SFX;
                Properties.Settings.Default.Save();
            }
        }

        private void EasyButton_Click(object sender, EventArgs e)
        {
            normalbg.PlayLooping();
            difficulty = "E";
            EasyButton.Enabled = false;
            EasyButton.Visible = false;
            NormieButton.Enabled = false;
            NormieButton.Visible = false;
            HardButton.Enabled = false;
            HardButton.Visible = false;
            comboBox1.Visible = false;
            label1.Visible = false;
            easylabel1.Visible = true;
            easylabel2.Visible = true;
            easylabel3.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            newGame();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            minute = comboBox1.SelectedIndex + 1;
        }

        private void RestartButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to start over? You will lose all space bux gained in this game", "Restart?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                restarted = true;
                secondsleft = 0;
                Console.WriteLine("I'm sorry");
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("If you're in the middle of a game, you will lose all SpaceBux you have gained so far!", "Are you sure you want to leave?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                timer1.Stop();
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void GameForm_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string m, s;
            if (secondsleft > 0)
            {
                if (secondsleft == 10)
                {
                    timerLabel.BackColor = System.Drawing.Color.Red;
                }
                secondsleft -= 1;
                m = (secondsleft / 60).ToString();
                if (m.Length < 2) m = "0" + m;
                s = (secondsleft % 60).ToString();
                if (s.Length < 2) s = "0" + s;
                timerLabel.Text = m + ":" + s;
            }
            else
            {
                if (restarted)
                {
                    restarted = false;
                    timer1.Stop();
                    buzzer.Play();

                }
                else
                {
                    timer1.Stop();
                    buzzer.Play();
                    if (numSets > 0)
                    {
                        if (tired <= 20)
                        {
                            tired = 0;
                        }
                        else
                        {
                            tired -= 20;
                        }
                        if (happy <= .10)
                        {
                            happy = 0;
                        }
                        else
                        {
                            happy -= .1f;
                        }
                        Properties.Settings.Default.globalTired = tired;
                        Properties.Settings.Default.SpaceBux += numSets;
                        Properties.Settings.Default.tempScore = numSets;
                        Properties.Settings.Default.Save();
                        DialogResult dialogResult = MessageBox.Show("Would you like to save your score to the leaderboard?", "Leaderboard", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            addToLeaderboard form = new addToLeaderboard();
                            form.Refresh();
                            form.ShowDialog();
                            form.Dispose();
                        }
                        totalBuxLabel.Text = Properties.Settings.Default.SpaceBux.ToString();
                    }
                }
                totalBuxLabel.Visible = true;
                label3.Visible = true;
                timerLabel.Visible = false;
                buxLabel.Visible = false;
                label2.Visible = false;
                for (int i = 0; i < 10; i++)
                {
                    pictures[i].Visible = false;
                    pictures[i].Enabled = false;
                    checkboxes[i].Visible = false;
                }
                EasyButton.Enabled = true;
                EasyButton.Visible = true;
                NormieButton.Enabled = true;
                NormieButton.Visible = true;
                HardButton.Enabled = true;
                HardButton.Visible = true;
                comboBox1.Visible = true;
                label1.Visible = true;
                easylabel1.Visible = false;
                easylabel2.Visible = false;
                easylabel3.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                RestartButton.Visible = false;
                RestartButton.Enabled = false;
                difficulties.Visible = true;
                difficulty = "";
                comboBox1.Text = "";
                minute = 5;
                
                //What else to do????????
                //add to leaderboard?!?!?!?
                //clear screen?!?!?!?
                //use creativity
            }
        }
    }
}
