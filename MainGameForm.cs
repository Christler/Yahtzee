using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yahtzee
{
    public partial class MainGameForm : Form
    {
        private List<Die> dice = new List<Die>
        {
            //create 5 dice objects
            new Die(),
            new Die(),
            new Die(),
            new Die(),
            new Die(),
        };
        private List<Button> holdButtons = new List<Button>();
        private List<PictureBox> pictureBoxes = new List<PictureBox>();
        private List<Label> firstSectionScores = new List<Label>();
        private List<Label> secondSectionScores = new List<Label>();
        private int numRolls;
        private Random random = new Random();
        private bool firstSectionComplete, secondSectionComplete;
        private int yatzeeBonus = 0;

        public MainGameForm()
        {
            InitializeComponent();
            InitializeGame();
            Global.ReadFile();
        }

        private void rollBtn_Click(object sender, EventArgs e)
        {
            RollDice();

            numRolls++; //increment numRolls on every click

            //if first roll enable hold buttons
            if(numRolls == 1)
            {
                foreach (Button b in holdButtons)
                {
                    b.Enabled = true;
                }
            }

            //if third roll turn roll button off
            if(numRolls == 3)
            {
                rollBtn.BackColor = Color.LightGray;
                rollBtn.Enabled = false;
            }
        }

        private void RollDice()
        {
            for (int i = 0; i < dice.Count; i++)
            {
                if (!dice[i].Hold)
                {
                    dice[i].Value = random.Next(6) + 1;
                    setImage(dice[i].Value, pictureBoxes[i]);
                }
            }

        }

        private void InitializeGame()
        {

            //populate list of picture boxes
            pictureBoxes.Add(die1);
            pictureBoxes.Add(die2);
            pictureBoxes.Add(die3);
            pictureBoxes.Add(die4);
            pictureBoxes.Add(die5);

            //populate list of hold buttons
            holdButtons.Add(holdBtn1);
            holdButtons.Add(holdBtn2);
            holdButtons.Add(holdBtn3);
            holdButtons.Add(holdBtn4);
            holdButtons.Add(holdBtn5);

            //onload turn buttons off since no dice have been rolled yet
            //there are no dice to hold
            foreach(Button b in holdButtons)
            {
                b.Enabled = false;
            }

            //populate list of first section labels
            firstSectionScores.Add(onesLbl);
            firstSectionScores.Add(twosLbl);
            firstSectionScores.Add(threesLbl);
            firstSectionScores.Add(foursLbl);
            firstSectionScores.Add(fivesLbl);
            firstSectionScores.Add(sixesLbl);

            //populate list of second section labels
            secondSectionScores.Add(threeOfKindLbl);
            secondSectionScores.Add(fourOfKindLbl);
            secondSectionScores.Add(fullHouseLbl);
            secondSectionScores.Add(smStraightLbl);
            secondSectionScores.Add(lgStraightLbl);
            secondSectionScores.Add(yatzeeLbl);
            secondSectionScores.Add(chanceLbl);
        }

        private void reset()
        {
            for (int i = 0; i < dice.Count; i++)
            {
                dice[i] = new Die();
                pictureBoxes[i].Image = null;
                holdButtons[i].Enabled = false;
                holdButtons[i].BackColor = Color.White;
            }

            rollBtn.BackColor = Color.Blue;
            rollBtn.Enabled = true;
            numRolls = 0;
        }

        private void setImage(int v, PictureBox pictureBox)
        {
            switch (v)
            {
                case 1:
                    pictureBox.Image = Properties.Resources._1;
                    break;
                case 2:
                    pictureBox.Image = Properties.Resources._2;
                    break;
                case 3:
                    pictureBox.Image = Properties.Resources._3;
                    break;
                case 4:
                    pictureBox.Image = Properties.Resources._4;
                    break;
                case 5:
                    pictureBox.Image = Properties.Resources._5;
                    break;
                case 6:
                    pictureBox.Image = Properties.Resources._6;
                    break;
            }
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void onesBtn_Click(object sender, EventArgs e)
        {   
            int score = 0;

            foreach(Die die in dice)
            {
                if(die.Value == 1)
                {
                    score += die.Value;
                }
            }

            onesLbl.Text = score.ToString();
            onesBtn.BackColor = Color.White;
            onesBtn.Enabled = false;
            checkFirstSection();
            reset();
        }

        private void twosBtn_Click(object sender, EventArgs e)
        {
            int score = 0;

            foreach (Die die in dice)
            {
                if (die.Value == 2)
                {
                    score += die.Value;
                }
            }

            twosLbl.Text = score.ToString();
            twosBtn.BackColor = Color.White;
            twosBtn.Enabled = false;
            checkFirstSection();
            reset();
        }

        private void threesBtn_Click(object sender, EventArgs e)
        {
            int score = 0;

            foreach (Die die in dice)
            {
                if (die.Value == 3)
                {
                    score += die.Value;
                }
            }

            threesLbl.Text = score.ToString();
            threesBtn.BackColor = Color.White;
            threesBtn.Enabled = false;
            checkFirstSection();
            reset();
        }

        private void foursBtn_Click(object sender, EventArgs e)
        {
            int score = 0;

            foreach (Die die in dice)
            {
                if (die.Value == 4)
                {
                    score += die.Value;
                }
            }

            foursLbl.Text = score.ToString();
            foursBtn.BackColor = Color.White;
            foursBtn.Enabled = false;
            checkFirstSection();
            reset();
        }

        private void fivesBtn_Click(object sender, EventArgs e)
        {
            int score = 0;

            foreach (Die die in dice)
            {
                if (die.Value == 5)
                {
                    score += die.Value;
                }
            }

            fivesLbl.Text = score.ToString();
            fivesBtn.BackColor = Color.White;
            fivesBtn.Enabled = false;
            checkFirstSection();
            reset();
        }

        private void sixesBtn_Click(object sender, EventArgs e)
        {
            int score = 0;

            foreach (Die die in dice)
            {
                if (die.Value == 6)
                {
                    score += die.Value;
                }
            }

            sixesLbl.Text = score.ToString();
            sixesBtn.BackColor = Color.White;
            sixesBtn.Enabled = false;
            checkFirstSection();
            reset();
        }

        private void checkFirstSection()
        {
            int count = 0;
            int bonus = 35;
            int total = 0;

            //count first section labels that are not blank
            foreach(Label l in firstSectionScores)
            {
                if(l.Text != "")
                {
                    count++;
                }
            }

            //if count is 6 first section is complete
            if(count == 6)
            {
                //add scores to total
                foreach (Label l in firstSectionScores)
                {
                    total += Convert.ToInt32(l.Text);
                }

                //display total
                firstTotalLbl.Text = total.ToString();

                //if total is greater than 63 give bonus
                if(total >= 63)
                {
                    bonusLbl.Text = bonus.ToString();
                    total += bonus;
                }
                else
                {
                    bonusLbl.Text = "0";
                }

                firstSectionComplete = true;
                GameOver();
            }

        }

        private void threeOfKindBtn_Click(object sender, EventArgs e)
        {
            //counts is an array for each value on a die. A loop goes through the dice 
            //and increases that index in the array.
            int score = 0;
            bool hasThree = false;
            int[] counts = new int[6]; 

            for(int i = 0; i < dice.Count; i++)
            {
                if (dice[i].Value != 0)
                {
                    counts[dice[i].Value - 1]++;
                    score += dice[i].Value; //add all dice for score
                }
            }

            //loop checks to see if any of the values in counts are 3 or greater. If so, sets hasThree to true
            foreach (int i in counts)
            {
                if(i >= 3)
                {
                    hasThree = true;
                    break;
                }
            }
            if (!hasThree)
            {
                score = 0; //set score back to zero if array doesn't have 3
            }

            threeOfKindBtn.BackColor = Color.White;
            threeOfKindBtn.Enabled = false;
            threeOfKindLbl.Text = score.ToString();
            checkSecondSection();
            reset();
        }

        private void fourOfKindBtn_Click(object sender, EventArgs e)
        {
            //counts is an array for each value on a die. A loop goes through the dice 
            //and increases that index in the array. 
            int score = 0;
            bool hasFour = false;
            int[] counts = new int[6];

            for (int i = 0; i < dice.Count; i++)
            {
                if (dice[i].Value != 0)
                {
                    counts[dice[i].Value - 1]++;
                    score += dice[i].Value; //add to all dice for score
                }
            }

            //loop checks to see if any of the values in counts are 4 or greater. If so, sets hasFour to true
            foreach (int i in counts)
            {
                if (i >= 4)
                {
                    hasFour = true;
                    break;
                }
            }
            if (!hasFour)
            {
                score = 0; //set total back to zero if array doesn't have 4
            }

            fourOfKindBtn.BackColor = Color.White;
            fourOfKindBtn.Enabled = false;
            fourOfKindLbl.Text = score.ToString();
            checkSecondSection();
            reset();
        }

        private void fullHouseBtn_Click(object sender, EventArgs e)
        {
            //counts is an array for each value on a die. A loop goes through the dice 
            //and increases that index in the array. 
            int score = 0;
            bool hasTwo = false;
            bool hasThree = false;
            int[] counts = new int[6];
            
                for (int i = 0; i < dice.Count; i++)
                {
                    if (dice[i].Value != 0)
                    {
                        counts[dice[i].Value - 1]++;
                    }
                }

            //loop checks to see if any of the values in counts are 2 or 3. 
            //If so, sets hasTwo or hasThree to true.
            foreach (int i in counts)
            {
                if (i == 3)
                {
                    hasThree = true;
                }
                if (i == 2)
                {
                    hasTwo = true;
                }
            }

            if (hasTwo && hasThree)
            {
                score = 25; //if hand has set of 2 and 3 score = 25
            }

            fullHouseBtn.BackColor = Color.White;
            fullHouseBtn.Enabled = false;
            fullHouseLbl.Text = score.ToString();
            checkSecondSection();
            reset();
        }

        private void smStraightBtn_Click(object sender, EventArgs e)
        {
            dice.Sort();
            int score = 0;
            int run = 1;
            for(int i = 0; i < dice.Count - 1; i++)
            {
                if(dice[i + 1].Value == dice[i].Value + 1)
                {
                    run++;
                }
            }
            if(run >= 4)
            {
                score = 30;
            }

            smStraightBtn.BackColor = Color.White;
            smStraightBtn.Enabled = false;
            smStraightLbl.Text = score.ToString();
            checkSecondSection();
            reset();
        }

        private void lgStraightBtn_Click(object sender, EventArgs e)
        {
            dice.Sort();
            int score = 0;
            int run = 1;
            for (int i = 0; i < dice.Count - 1; i++)
            {
                if (dice[i + 1].Value == dice[i].Value + 1)
                {
                    run++;
                }
            }
            if (run == 5)
            {
                score = 40;
            }

            lgStraightBtn.BackColor = Color.White;
            lgStraightBtn.Enabled = false;
            lgStraightLbl.Text = score.ToString();
            checkSecondSection();
            reset();
        }

        private void yahtzeeBtn_Click(object sender, EventArgs e)
        {
            //counts is an array for each value on a die. A loop goes through the dice 
            //and increases that index in the array. 
            int score = 0;
            int[] counts = new int[6];
            for (int i = 0; i < dice.Count; i++)
            {
                if (dice[i].Value != 0)
                {
                    counts[dice[i].Value - 1]++;
                }
            }

            //loop checks to see if any of the values in counts are 5. If so, sets score to 50
            foreach (int i in counts)
            {
                if (i == 5)
                {
                    score = 50;
                    yahtzeeBonusBtn.Enabled = true;
                    yahtzeeBonusBtn.BackColor = Color.FromArgb(192, 255, 192);
                    break;
                }
            }

            yahtzeeBtn.BackColor = Color.White;
            yahtzeeBtn.Enabled = false;
            yatzeeLbl.Text = score.ToString();
            checkSecondSection();
            reset();
        }

        private void chanceBtn_Click(object sender, EventArgs e)
        {
            int score = 0;

            foreach(Die d in dice)
            {
                score += d.Value;
            }

            chanceBtn.BackColor = Color.White;
            chanceBtn.Enabled = false;
            chanceLbl.Text = score.ToString();
            checkSecondSection();
            reset();
        }

        private void checkSecondSection()
        {
            int count = 0;
            int total = 0;

            foreach (Label l in secondSectionScores)
            {
                if (l.Text != "")
                {
                    count++;
                }
            }

            if (count == 7)
            {
                foreach(Label l in secondSectionScores)
                {
                    total += Convert.ToInt32(l.Text);
                }

                secondTotalLbl.Text = total.ToString();
                secondSectionComplete = true;
                GameOver();
            }

        }

        private void holdBtn1_Click(object sender, EventArgs e)
        {
            if (!dice[0].Hold)
            {
                dice[0].Hold = true;
                holdBtn1.BackColor = Color.Red;
            }
            else
            {
                dice[0].Hold = false;
                holdBtn1.BackColor = Color.White;
            }
        }

        private void holdBtn2_Click(object sender, EventArgs e)
        {
            if (!dice[1].Hold)
            {
                dice[1].Hold = true;
                holdBtn2.BackColor = Color.Red;
            }
            else
            {
                dice[1].Hold = false;
                holdBtn2.BackColor = Color.White;
            }
        }

        private void holdBtn3_Click(object sender, EventArgs e)
        {
            if (!dice[2].Hold)
            {
                dice[2].Hold = true;
                holdBtn3.BackColor = Color.Red;
            }
            else
            {
                dice[2].Hold = false;
                holdBtn3.BackColor = Color.White;
            }
        }

        private void holdBtn4_Click(object sender, EventArgs e)
        {
            if (!dice[3].Hold)
            {
                dice[3].Hold = true;
                holdBtn4.BackColor = Color.Red;
            }
            else
            {
                dice[3].Hold = false;
                holdBtn4.BackColor = Color.White;
            }
        }

        private void holdBtn5_Click(object sender, EventArgs e)
        {
            if (!dice[4].Hold)
            {
                dice[4].Hold = true;
                holdBtn5.BackColor = Color.Red;
            }
            else
            {
                dice[4].Hold = false;
                holdBtn5.BackColor = Color.White;
            }
        }

        private void yahtzeeBonusBtn_Click(object sender, EventArgs e)
        {
            //counts is an array for each value on a die. A loop goes through the dice 
            //and increases that index in the array. 
            int[] counts = new int[6];
            for (int i = 0; i < dice.Count; i++)
            {
                counts[dice[i].Value - 1]++;
            }

            //loop checks to see if any of the values in counts are 5. If so, sets score to 50
            foreach (int i in counts)
            {
                if (i == 5)
                {
                    yatzeeBonus += 100;
                    yatzeeBonusLbl.Text = yatzeeBonus.ToString();
                    reset();
                    break;
                }
            }
        }

        private void GameOver()
        { 
            if(firstSectionComplete && secondSectionComplete)
            {
                int score = Convert.ToInt32(firstTotalLbl.Text) + Convert.ToInt32(secondTotalLbl.Text) + Convert.ToInt32(bonusLbl.Text) + yatzeeBonus;
                Global.ThisScore = score;
                grandTotalLbl.Text = score.ToString();
                Global.CheckScore();
            }
        }
    }
}
