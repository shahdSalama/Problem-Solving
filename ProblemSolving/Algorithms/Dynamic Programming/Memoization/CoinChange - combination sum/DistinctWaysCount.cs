
using System.Collections.Generic;

namespace HackerRank.Algorithms.Dynamic_Programming.Memoization.CoinChange
{
    class DistinctWaysCount
    {
        public static long getWays(long target, List<long> nums)
        {
            return coinchange(target, nums, nums.Count - 1, new Dictionary<(long, int), long>());
        }
        //                                                                         input(target, n)
        public static long coinchange(long target, List<long> nums, int n, Dictionary<(long, int), long> memo)
        {
            if (memo.TryGetValue((target, n), out long value)) return value;


            if (target == 0) return 1;

            if (target < 0 || n < 0) return 0;

            // use the coin
            //                        new target,       nums,
            long subres1 = coinchange(target - nums[n], nums, n, memo);
            // do not use the coin and use the rest

            //                    same target, nums,  n-1
            long subres2 = coinchange(target, nums, n - 1, memo);

            var res = subres1 + subres2;

            if (!memo.TryGetValue((target, n), out long _))
                memo.Add((target, n), res);

            return res;
        }
        
    }
}
