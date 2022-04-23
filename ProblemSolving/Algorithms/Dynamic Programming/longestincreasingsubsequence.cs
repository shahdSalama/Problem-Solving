using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Dynamic_Programming
{
    class longestincreasingsubsequence
    {

            public static int LengthOfLIS(int[] nums)
            {
                // [0,1,0,3,2,3]
                //                           i  , count
                if (nums.Length == 0) return 0;
                if (nums.All(x => x == nums[0])) return 1;
                var original = nums.ToArray();
                Array.Sort(nums);
                bool success = true;
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] != original[i])
                        success = false;

                }
                if (success) return nums.Length;
                nums = original;
                var visited = new Dictionary<int, int>();
                var s = new Stack<(int, int)>();
                int res = 0;
                s.Push((0, 1));

                while (s.Count != 0)
                {  // s = (1, 1)
                    (int i, int currCount) = s.Pop();

                    // been here with better count
                    if (visited.TryGetValue(i, out int val) && val >= currCount) continue;

                    // been here with worse situation
                    else if (visited.TryGetValue(i, out int val2))
                        visited[i] = currCount;

                    // never been here
                    else visited.Add(i, currCount);
                    // updated count of sequence
                    res = Math.Max(res, currCount);
                    // res = 1
                    // visited = (0,1)

                    // start a new sequence
                    if (i + 1 < nums.Length)
                        s.Push((i + 1, 1));
                    foreach (var nI in GetN(i, nums))
                    {
                        s.Push((nI, currCount + 1));
                    }
                }
                return res;
            }
            static System.Collections.Generic.IEnumerable<int> GetN(int i, int[] nums) // 0 
            {

                for (int index = i + 1; index < nums.Length; index++)
                {
                    if (nums[index] > nums[i])
                        yield return index;
                }

            }
        
       
    }
}
