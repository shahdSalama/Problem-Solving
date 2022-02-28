using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Recursion
{
    class fib
    {

       public static Dictionary<long, long> dic = new Dictionary<long, long> { { 1, 1 }, { 0, 0 } };
        public static long fibo(long n, Dictionary<long, long> memo = null)
        {
            // very first call
            if (memo == null) memo = new Dictionary<long, long>();
            // check memo
            if (memo.TryGetValue(n, out long val))
            {
                return val;
            }
            // base case
            if (n <= 2) return n;
            // calculate, passing memo and returning
            else
            {
                memo.Add(n, fibo(n - 1, memo) + fibo(n - 2, memo));
                return memo[n];
            }
        }


    }
}
