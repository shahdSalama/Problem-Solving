using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.DataStructure.Graph
{
    class houseRob
    {
        public static int Rob(int[] nums)
        {
            int max = 0;
            //                           index, total
            var visited = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int final = explore(nums, i, visited);
                max = Math.Max(max, final);
            }
            return max;
        }

        public static int explore(int[] nums, int i, Dictionary<int, int> visited)
        {
            int final = 0;
            //                index, total
            var s = new Stack<(int, int)>();

            s.Push((i, nums[i]));

            if (visited.TryGetValue(i, out int val3) && val3 > nums[i]) return final;
            if (!visited.TryGetValue(i, out int _))
                visited.Add(i, nums[i]);

            while (s.Count != 0)
            {
                (int currI, int currTotal) = s.Pop();

                if (currI >= nums.Length - 2)
                {
                    final = Math.Max(final, currTotal);
                    continue;
                }
                if (visited.TryGetValue(currI, out int val) && val > currTotal) continue;

                foreach (var nei in getNei(currI, nums))
                {

                    s.Push((nei, nums[nei] + currTotal));
                    if (!visited.TryGetValue(nei, out int _))
                        visited.Add(nei, nums[nei] + currTotal);

                    if (visited.TryGetValue(nei, out int val2) && val2 < nums[nei] + currTotal)
                        visited[nei] = nums[nei] + currTotal;

                    final = Math.Max(final, nums[nei] + currTotal);
                }
            }
            return final;
        }

        // gets indexies of nieghbours... skip the next node and take all the way till the end
        public static List<int> getNei(int index, int[] nums)
        {
            var res = new List<int>();
            for (int i = index + 2; i < nums.Length; i++)
            {
                res.Add(i);
            }
            return res;
        }

       
    }
}
