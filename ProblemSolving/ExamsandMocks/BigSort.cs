using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.ExamsandMocks
{
    public class CustomComparer : IComparer<string>
    {
        public int Compare(string a, string b)
        {
            if (a.Length != b.Length) return a.Length - b.Length;

            for (int i = 0; i < a.Length; i++)
            {
                var left = a[i];
                var right = b[i];
                if (left != right) return left - right;
            }
            return 0;
        }
    }


    public class BigSort
    {
        public static List<string> bigSorting(List<string> unsorted)
        {
            unsorted.Sort(new CustomComparer());

            return unsorted;



        }

    }
}
