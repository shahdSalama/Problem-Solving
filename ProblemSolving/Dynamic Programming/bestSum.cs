using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank.Dynamic_Programming
{
    class bestSum1
    {

        public static List<int> bestsum(int targetSum, int[] nums, Dictionary<int, List<int>> memo)
        {
            if (memo.TryGetValue(targetSum, out List<int> val)) 
                return val;
            if (targetSum == 0) return new List<int>();
            if (targetSum < 0) return null;

            List<int> shortestComb = null;

            foreach (var num in nums)
            {
                int remainder = targetSum - num;
                var remainderCombination = bestsum(remainder, nums, memo);
                if (remainderCombination != null)
                {
                    var combination = remainderCombination.ToList();
                    combination.Add(num);
                    if (shortestComb == null || shortestComb.Count > combination.Count)
                    {
                        shortestComb = combination;
                    }
                }

            }
            memo.Add(targetSum, shortestComb);
            return shortestComb;
        }
        //public static void Main(String[] args)
        //{
        //    //  var res5 = HowSum(3, new int[] { 2, 0, 5 });
        //    //  var res2 = CoinChange(new int[] { 2, 3}, 7,  new Dictionary<int, List<int>>());
        //    //  var res23 = CoinChange(new int[] { 5,3,4,7 }, 7, new Dictionary<int, List<int>>());
        //    //  var res55 = CoinChange(new int[] {2, 4 }, 7, new Dictionary<int, List<int>>());
        //    var memo = new Dictionary<int, List<int>>();
        //    var r99es55 = bestsum(100, new int[] { 1, 10,  25  }, memo);
        //    // time n*m
        //    // space : target = n

        //}

    }
}
