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


        public static int Rob2(int[] nums)
        {

            if (nums.Length == 1) return nums[0];
            if (nums.Length == 2) return Math.Max(nums[0], nums[1]);
            var visited = new int[nums.Length];
            int res = int.MinValue;
            for (int i = 0; i < nums.Length; i++)
            {
                res = Math.Max(res, explore2(i, nums, visited));

            }
            return res;
        }
        static int explore2(int j, int[] nums, int[] visited)
        {
            if (visited[j] > nums[j]) return 0;
          
            int res = 0;
            var s = new Stack<(int, int)>();
            s.Push((j, nums[j]));

            while (s.Count != 0)
            {
                (int currI, int currSum) = s.Pop();

                if (visited[currI] >= currSum) continue;
                visited[currI] = currSum;
                res = Math.Max(res, currSum);

                for (int i = currI + 2; i < nums.Length; i++)
                {
                    s.Push((i, currSum + nums[i]));
                }

            }
            return res;


        }

      
    }
}
