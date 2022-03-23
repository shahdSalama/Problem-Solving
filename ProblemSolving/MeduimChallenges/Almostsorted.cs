using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.MeduimChallenges
{
    class Almostsorted
    {
        public static void almostSorted(List<int> arr)
        {
            // 2 peak, 1 valley
            // 2, 8, 6, 7, 4 // yes swap

            // 2, 8, 6, 7, 4, 3 // no

             // 1 peak 1 valley 
            //2, 6, 4, 8  // yes swap
            //2, 6, 4, 1

             // 1 peak, 1 valley
            //  2, 7, 5, 3, 9 yes reverse

            //  2,7, 5, 3, 6 no
            //  4,7, 5, 3, 9
        }
    }
}
