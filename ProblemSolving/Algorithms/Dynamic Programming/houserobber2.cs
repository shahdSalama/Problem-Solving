using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Dynamic_Programming
{
    public class Solutiojkjn
    {
        public static int Rob(int[] nums)
        {
            int[] numswithoutfirtselement = new int [nums.Length];
            Array.Copy(nums, numswithoutfirtselement, nums.Length);
            numswithoutfirtselement[0] = 0;

            int[] numswithoutLastselement = new int[nums.Length];
            Array.Copy(nums, numswithoutLastselement, nums.Length);
         

            numswithoutLastselement[nums.Length - 1] = 0;
            int res = Math.Max(rob(numswithoutfirtselement, nums.Length - 1, new Dictionary<int, int>()), rob(numswithoutLastselement, nums.Length - 1, new Dictionary<int, int>()));

            return Math.Max(res, nums[0]);
        }
        // gets indexies of nieghbours... skip the next node and take all the way till the end
        public static int rob(int[] nums, int n, Dictionary<int, int> memo)
        {
            if (memo.TryGetValue(n, out int val)) return val;
            if (n < 0) return 0;
            int res = Math.Max(rob(nums, n - 2, memo) + nums[n], rob(nums, n - 1, memo));
            memo.Add(n, res);
            return res;
        }
        public static void Main(string[] args)
        {
            Rob(new int[] { 1, 2, 3,  1 });
        }

    }
}
