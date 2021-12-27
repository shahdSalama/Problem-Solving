using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank.Algorithms.Sort
{
    class CountSort
    {
        public static void countSort(List<List<string>> arr)
        {

            List<List<string>> sorted = new List<List<string>>();

            for (int i = 0; i < 100; i++)
            {
                sorted.Add(new List<string>());
            }

            for (int i = 0; i < arr.Count / 2; i++)
            {
                sorted[Convert.ToInt32(arr[i][0])].Add("-");
            }

            for (int i = arr.Count / 2; i < arr.Count; i++)
            {
                sorted[Convert.ToInt32(arr[i][0])].Add(arr[i][1]);
            }

            var flattened = sorted.SelectMany(x => x).ToList();
            for (int i = 0; i < flattened.Count; i++)
            {
                Console.Write(flattened[i] + " ");
            }
        }

    }

}

