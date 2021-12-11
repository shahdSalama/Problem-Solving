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


            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> s = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList();

            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int d = Convert.ToInt32(firstMultipleInput[0]);

            int m = Convert.ToInt32(firstMultipleInput[1]);

            int result = SubarrayDivision2.birthday(s, d, m);
        }

    }
}