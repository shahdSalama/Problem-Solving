using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Dynamic_Programming
{
    class coinchange
    {

        public static long getWays(long n, List<long> nums)
        {
            if (n == 0) return 1;
            if (n < 0) return 0;

            foreach (var num in nums)
            {
                var remainder = n - num;
                long res = getWays(remainder, nums);
                if (res == 1)
                {
                    res += 1;
                    return res;
                }


            }
            return 0;
        }

      

    }
}
