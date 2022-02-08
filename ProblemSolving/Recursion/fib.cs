using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Recursion
{
    class fib
    {

       public static Dictionary<long, long> dic = new Dictionary<long, long> { { 1, 1 }, { 0, 0 } };


        public static long fibo(long n)
        {
            if (n == 0 || n == 1) return n;

            long fnm1;
            if (dic.TryGetValue(n - 1, out long val))
            {
                fnm1 = val;
            }
            else
            {
                fnm1 = fibo(n - 1);
                dic.Add(n - 1, fnm1);
            }

            long fnm2;
            if (dic.TryGetValue(n - 2, out long val2))
            {
                fnm2 = val2;
               
            }
            else
            {
                fnm2 = fibo(n - 2);
                dic.Add(n - 2, fnm2);
            }

            return fnm2 + fnm1;
        }

       
    }
}
