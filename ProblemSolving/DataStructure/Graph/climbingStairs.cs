using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.DataStructure.Graph
{
    class climbingStairs
    {
        public int MinCostClimbingStairs(int[] cost)
        {
            var s = new Stack<(int index, int amount)>();

            int totalCost = Int32.MaxValue;
            // index, amount
            var visited = new Dictionary<int, int>();

            s.Push((0, 0));
            s.Push((1, 0));


            while (s.Count != 0)
            {
                (int currI, int currAmount) = s.Pop();

                if (currI == cost.Length)
                    totalCost = Math.Min(currAmount, totalCost);


                if (visited.TryGetValue(currI, out int val) && val < currAmount) continue;

                if (visited.TryGetValue(currI, out int _)) visited[currI] = currAmount;
                else visited.Add(currI, currAmount);

                if (currI < cost.Length)
                {
                    s.Push((currI + 1, currAmount + cost[currI]));

                    s.Push((currI + 2, currAmount + cost[currI]));
                }

            }
            return totalCost;
        }
    }
}
