using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Dynamic_Programming
{
    class stock
    {
        public static int MaxProfit(int[] prices)
        {
            return dfs(0, prices, true, new Dictionary<(int, bool), int>());
        }

        private static int dfs(int i, int[] prices, bool buying, Dictionary<(int, bool), int> memo)
        {
            if (i >= prices.Length) return 0;
            if (memo.TryGetValue((i, buying), out int val)) return val;

            int cool = dfs(i + 1, prices, buying, memo);

            if (buying)
            {
                int buy = dfs(i + 1, prices, !buying, memo) - prices[i];
                memo.Add((i, buying), Math.Max(cool, buy));
            }
            else
            {
                int sell = dfs(i +2, prices, !buying, memo) + prices[i];
                memo.Add((i, buying), Math.Max(cool, sell));
            }
            return memo[(i, buying)];


        }

       
    }
}

