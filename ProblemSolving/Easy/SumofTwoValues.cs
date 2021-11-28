using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    class SumofTwoValues
    {
        static bool findSumOfTwo(int[] A, int val)
        {
            HashSet<int> visited = new HashSet<int>();

            foreach (var a in A) 
            {
                visited.Add(a);
                if (visited.Contains(val - a))
                    return true;
            }
            return false;
        }

    }
}
