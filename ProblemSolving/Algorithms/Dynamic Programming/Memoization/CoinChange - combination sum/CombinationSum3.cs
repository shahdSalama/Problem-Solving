using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Dynamic_Programming.Memoization.CoinChange___combination_sum
{
    class CombinationSumIII
    {
        public IList<IList<int>> CombinationSum3(int k, int n)
        {
            IList<IList<int>> res = new List<IList<int>>();
            // using k integers, construct n
            if (k == 0 || n == 0 || k > n) return res;
            if (k == 1)
            {
                res.Add(new List<int> { n });
                return res;
            }
            var resHash = new HashSet<string>();

            var q = new Queue<List<int>>();
            q.Enqueue(new List<int>());
            while (q.Count != 0)
            {
                var currList = q.Dequeue();
                // goal
                if (currList.Count == k && currList.Sum() == n)
                {
                    currList.Sort();
                    // ensuring no duplicate combinations exist
                    // example n = 9 k = 3 comb1= {1,2,6}   we will not have another comb {6,2,1}
                    var hash = string.Join(",", currList);
                    if (resHash.Contains(hash)) continue;
                    resHash.Add(hash);
                    res.Add(currList);
                    continue;
                }
                // check out of bounds
                if (currList.Count > k) continue;
                if (currList.Sum() > n) continue;

                // neigbours
                for (int i = 1; i <= 9; i++)
                {
                    var newList = currList.ToList();
                    if (!newList.Contains(i))
                    {
                        newList.Add(i);
                        q.Enqueue(newList);
                    }
                }

            }
            return res;
        }
    }
}
