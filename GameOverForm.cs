using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Yahtzee
{
    public partial class GameOverForm : Form
    {
        public GameOverForm()
        {
            InitializeComponent();

            //show this game's score
            scoreLbl.Text = $"Score: {Global.ThisScore}";

            //sort by player score
            var playersSorted =
                from p in Global.GetPlayers()
                orderby p.Score descending
                select p;

            //clear high score text file
            File.Create(Global.highScoreFile).Close();

            //use streamwriter and write top 5 scores to file
            using(StreamWriter writer = File.AppendText(Global.highScoreFile))
            {
                int count = 0; //to keep track of how many scores. limited to 5
                foreach (var p in playersSorted)
                {
                    if (count < 5)
                    {
                        //display top 5 sorted players and write high scores to text file 
                        namesLbl.Text += $"\n{p.Name}";
                        scoresLbl.Text += $"\nScore: { p.Score}";
                        writer.WriteLine($"{p.Name}:{p.Score}");
                    }
                    count++;
                }
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void playAgainBtn_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

    }
}
