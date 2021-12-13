using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank.Easy
{
    class SubarrayDivision2
    {
        /*
    * Complete the 'birthday' function below.
    *
    * The function is expected to return an INTEGER.
    * The function accepts following parameters:
    *  1. INTEGER_ARRAY s
    *  2. INTEGER d
    *  3. INTEGER m
    */

        public static int SumFromTo(int startindex, int endIndex, List<int> list)
        {
            int result = 0;
            for (int i = startindex; i < endIndex; i++)
            {
                result += list[i];
            }
            return result;
        }


        public static int birthday(List<int> s, int d, int m)
        {
            int i = 0;
            int j = m;
            int count = 0;
            while (j <= s.Count)
            {
                if (SumFromTo(i, j, s) == d)
                    count++;
                i++;
                j++;
            }
            return count;
        }


        public static void Main(string[] args)
        {

            int x = (7-4) / 2;

      
        }

    }
}