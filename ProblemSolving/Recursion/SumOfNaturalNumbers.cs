using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Recursion
{
    class SumOfNaturalNumbers
    {

        public static int SumOfNaturalNumbersSolution(int n)
        {
            if (n == 0) return 0;

            return SumOfNaturalNumbersSolution(n-1) + n;

        }

        //public static void Main(string[] args)
        //{
        //    var res = SumOfNaturalNumbersSolution(10);
        //}
        //  
    }
}
