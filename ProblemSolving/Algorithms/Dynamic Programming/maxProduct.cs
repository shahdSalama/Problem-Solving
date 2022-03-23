using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Dynamic_Programming
{
    class maxProductxx
    {
        public  static int MaxProduct(int[] nums)
        {
            int currMax = 1;
            int currMin =1;
            int res = nums.Max();

            for (int i = 0; i < nums.Length - 1; i++)
            {
                var temp = currMax* nums[i];
                currMax = Math.Max(currMax * nums[i], Math.Max(nums[i], nums[i] * currMin));
                currMin = Math.Min(temp, Math.Min(nums[i], nums[i] * currMin));

                res = Math.Max(res, currMax);

            }
            return res;
        }
       
    }
}
