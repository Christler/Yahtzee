using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Yahtzee
{
    static class Global
    { 
        public static int ThisScore { get; set; }
        public static List<Player> players = new List<Player>();
        public static string highScoreFile = "high_scores.txt";

        public static void ReadFile() {
            //create file if it doesn't exist
            if (!File.Exists(highScoreFile))
            {
                File.Create(highScoreFile).Close();

                //populate text file with 5 scores of 0
                using (StreamWriter writer = File.AppendText(Global.highScoreFile))
                {
                    for(int i = 0; i < 5; i++)
                        writer.WriteLine($"N/A:0");
                }
            }

            //declare variables needed to read from file and create player object
            string name;
            int playerScore;
            int index;
            string line;

            //Read from file and add player to list of players
            StreamReader reader = new StreamReader(highScoreFile);
            while ((line = reader.ReadLine()) != null)
            {
                index = line.IndexOf(':');
                name = line.Substring(0, index);
                playerScore = Convert.ToInt32(line.Substring(index + 1));
                players.Add(new Player(name, playerScore));
            }
            reader.Close();
        }

        public static void CheckScore()
        {
            bool newHighScore = false;
            if(players.Count < 1)
            {
                HighScore highScore = new HighScore();
                highScore.Show();
                newHighScore = true;
            }

            foreach (Player p in players)
            {
                if (ThisScore >= p.Score)
                {
                    HighScore highScore = new HighScore();
                    highScore.Show();
                    newHighScore = true;

                    break;
                }
            }

            if (!newHighScore)
            {
                GameOverForm gameOver = new GameOverForm();
                gameOver.Show();
            }
        }

        public static List<Player> GetPlayers()
        {
            return players;
        }

        public static void AddNewPlayer(Player player)
        {
            players.Add(player);
        }
    }
}
