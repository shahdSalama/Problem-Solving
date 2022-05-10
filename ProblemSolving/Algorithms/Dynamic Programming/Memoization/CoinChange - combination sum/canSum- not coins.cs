using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Dynamic_Programming.Memoization.CoinChange
{
    class canSum // 1,3   not same as 3,1
    {
        bool coinChange(int[] coins, int target, Dictionary<int, bool> memo)
        {
            if (memo.TryGetValue(target, out bool val)) return val;
            if (target == 0) return true;

            if (target < 0) return false;

            foreach (var num in coins)
            {
                int remainder = target - num;
                if (coinChange(coins, remainder, memo))
                    memo.Add(target, true);
                    return true;
            }
            memo.Add(target, false);
            return false;


        }

      
    }
}
