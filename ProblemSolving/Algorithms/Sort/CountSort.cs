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
            List<string> sorted = new List<string>();

            for (int i = 0; i < 100; i++)
            {
                sorted.Add(" ");
            }

            for (int i = 0; i < arr.Count / 2; i++)
            {
                sorted[Convert.ToInt32(arr[i][0])]+= "- ";
            }

            for (int i = arr.Count / 2; i < arr.Count; i++)
            {
                sorted[Convert.ToInt32(arr[i][0])] += (" " + arr[i][1]);
            }

            var s = string.Join("", sorted);

           
            for (int i = 0; i < s.Length -1; i++)
            {

                if (s[i] == s[i + 1])
                   s= s.Remove(i, 1);
            
            }

            for (int i = 0; i < arr.Count; i++)
            {
                Console.Write(sorted[i]);
            }
        }

        //public static void Main(string[] args)
        //{
        //    int n = Convert.ToInt32(Console.ReadLine().Trim());

        //    List<List<string>> arr = new List<List<string>>();

        //    for (int i = 0; i < n; i++)
        //    {
        //        arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList());
        //    }

        //    countSort(arr);
        //}


    }

}

