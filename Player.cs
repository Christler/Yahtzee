using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee
{
    class Player : IComparable<Player>
    {
        public Player(string name, int score)
        {
            Name = name;
            Score = score;
        }

        public string Name { get; set; }
        public int Score { get; set; }

        public int CompareTo(Player other)
        {
            if (this.Score == other.Score)
                return 0;
            if (this.Score > other.Score)
                return 1;
            return -1;
        }
    }
}
