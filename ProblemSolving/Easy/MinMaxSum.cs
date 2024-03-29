﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank
{
    public class MiniMaxSum
    {
        public static void miniMaxSum(List<int> arr)
        {
            int max = arr.Max();
            int indexOfMax = arr.FindIndex(0, arr.Count, x => x == max);
            arr[indexOfMax] = 0;

            Int64 minSum = arr.Select(x => (long)x).Sum();

            arr[indexOfMax] = max;

            int minnumber = arr.Min();
            int indexOfmin = arr.FindIndex(0, arr.Count, x => x == minnumber);
            arr[indexOfmin] = 0;

            Int64 maxSum = arr.Select(x => (long)x).Sum();

            Console.WriteLine($"{minSum} {maxSum}");

        }

        
    }
}
