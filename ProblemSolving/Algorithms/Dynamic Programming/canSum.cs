using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Algorithms.Dynamic_Programming
{
    class canSumSol
    {                                                          // input, output
        static bool canSum(int targetSum, int [] nums, Dictionary<int, bool> memo)
        {
            if (memo.TryGetValue(targetSum, out bool val)) return val;
            if (targetSum == 0) return true;
            if (targetSum < 0) return false;

            foreach (var num in nums)
            {
                int remiainder = targetSum - num;
                if (canSum(remiainder, nums, memo) == true)
                    memo.TryAdd(targetSum, true);
                    return true;
            }
            memo.TryAdd(targetSum, false);
            return false;
        }

        // time: O(n*m)
        // space O (m)
    }
}
