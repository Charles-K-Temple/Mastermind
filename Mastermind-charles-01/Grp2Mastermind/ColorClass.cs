using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grp2Mastermind
{
    class ColorClass
    {
        public static string color(int x)
        {
            string[] colors = { "blank", "Red", "Blue", "Green", "Yellow", "White", "Black", "Orange", "Violet" };
            return colors[x];
        }
    }
}

