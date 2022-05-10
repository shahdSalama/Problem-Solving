using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Dynamic_Programming.Memoization.CoinChange
{
    class CombinationSumI
    {

        public static IList<IList<int>> CombinationSum(int[] nums, int target)
        {

            IList<IList<int>> res = new List<IList<int>>();
            if (target == 0 || nums.Length == 0) return res;
            var visited = new HashSet<(string, int)>();
            var resHash = new HashSet<string>();
            var s = new Stack<(int, List<int> com, int sum)>();
            s.Push((0, new List<int>(), 0));

            while (s.Count != 0)
            {
                (int currI, List<int> currComb, int currSum) = s.Pop();
               
                // has this state already been visited before
                var str = string.Join(",", currComb);

                if (visited.Contains((str, currI)) && str != "") continue;
                else visited.Add((str, currI));

                // am i out of bounds? current Index is candidates.Length-1
                if (currI == nums.Length) continue;
                // it is equal to target
                if (currSum == target && !resHash.Contains(str))
                {
                    resHash.Add(str);
                    res.Add(currComb);
                    continue;
                }
                // is the sum of the current list bigget than target?
                if (currSum > target) continue;
             



                //at each index
                // take and move
                var newList = currComb.ToList();
                newList.Add(nums[currI]);
                s.Push((currI + 1, newList, currSum + nums[currI]));
                // take and stay 
                var newList2 = currComb.ToList();
                newList2.Add(nums[currI]);
                s.Push((currI, newList2, currSum + nums[currI]));

                // do not take and move
                s.Push((currI + 1, currComb, currSum));
            }
            return res;
        }
       
    }


}
