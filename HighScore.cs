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

namespace Yahtzee
{
    public partial class HighScore : Form
    {
        public HighScore()
        {
            InitializeComponent();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            string name = nameText.Text; //get name input

            //write new score to file
            using (StreamWriter writer = File.AppendText(Global.highScoreFile))
            {
                writer.WriteLine($"{name}:{Global.ThisScore}");
            }

            //add player to players list
            Global.AddNewPlayer(new Player(name, Global.ThisScore));

            //create game over object and show form
            GameOverForm gameOver = new GameOverForm();
            gameOver.Show();
            this.Close();
        }
    }
}
