using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank.Easy
{
    class PickingNumbers
    {
        public static int pickingNumbers(List<int> arr)
        {

            var counts = new int[100];

            for (int i = 0; i < arr.Count; i++)
            {
                counts[arr[i]]++;
            }

            int max = 0;

            for (int i = 0; i < counts.Count() - 1; i++)
            {
                int newMax = counts[i] + counts[i + 1];
                if (newMax > max)
                    max = newMax;
            }

            //Console.WriteLine(counts.Max());
            return max;

        }

    }
}
