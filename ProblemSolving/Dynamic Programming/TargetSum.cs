using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Dynamic_Programming
{
    class TargetSumSolution
    {
        public static bool TargetSum(int target, int[] nums, Dictionary<int, bool> memo = null)
        {                                         // target, res
            if (memo == null) memo = new Dictionary<int, bool>();
            if (memo.TryGetValue(target, out bool val)) return val;
            if (target == 0) return true;
            if (target < 0) return false;

            foreach (var num in nums)
            {
                int remainder = target - num;
                bool res = TargetSum(remainder, nums, memo);
                memo.TryAdd(target, res);
                if (res) return true;
            }
            memo.TryAdd(target, false);
            return false;

        }
        // time n*m
        // space : target = n
      
    }
}
