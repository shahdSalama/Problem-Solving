using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank
{
    public class PlusMinus
    {
        public static void plusMinus(List<int> arr)
        {
            decimal arrCount = arr.Count;
            decimal positiveCount = arr.Where(x => x > 0).Count();

            decimal positiveRatio = positiveCount / arrCount;
            Console.WriteLine(positiveRatio.ToString("N6"));

            decimal negativeCount = arr.Where(x => x < 0).Count();
            decimal negativeRatio = negativeCount / arrCount;
            Console.WriteLine(negativeRatio.ToString("N6"));

            decimal zeroCount = arr.Where(x => x == 0).Count();
            decimal zeroRatio = zeroCount / arrCount;
            Console.WriteLine(zeroRatio.ToString("N6"));
        }

      
    }
}
