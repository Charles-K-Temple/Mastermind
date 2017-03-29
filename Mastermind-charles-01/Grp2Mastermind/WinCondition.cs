using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grp2Mastermind
{
    class WinCondition
    {
        public static int Matches(int[] comp, int[] player)
            {
            List<int> listX = new List<int> { 0, 1, 2, 3 };
            List<int> listY = new List<int> { 0, 1, 2, 3 };
            int match = 0;

            foreach (int x in listX)
            {
                foreach (int y in listY)
                {
                    if (comp[x] == player[y])
                    {
                        match++;
                        listX.Remove(x);
                        listY.Remove(y);
                    }
                }
            }
            return match;
        }

        public static int InOrder(int[] comp, int[] player)
        {
            int match = 0;
            foreach (int c in comp)
            {
                foreach (int p in player)
                {
                    if (c == p)
                    {
                        match ++;
                    }
                }
            }
            return match;
        }

        public static bool Winner(int[] comp, int[] player)
        {
            if (InOrder(comp, player) == comp.Length)
            {
                return true;
            }
            return false;
        }

    }
}
