using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yahtzee
{
    class Die : IComparable<Die>
    {
        public Die(){ }

        public int Value { get; set; }
        public bool Hold { get; set; }

        public int CompareTo(Die other)
        {
            if (this.Value == other.Value)
                return 0;
            if (this.Value > other.Value)
                return 1;
            return -1;
        }
    }
}
