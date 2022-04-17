using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.MeduimChallenges
{
    class arith
    {
        public  static int NumberOfArithmeticSlices(int[] nums)
        {
            if (nums.Length < 3) return 0;
            int count = 0;
            int l = 0;
            int r = 2;
            while (r < nums.Length && l < nums.Length - 2)
            {
                bool good = isGood(l, r, nums);
                if (good)
                {
                    count++;
                    r++;
                }
                if (!good || r == nums.Length)
                {
                    l++;
                    r = l + 2;
                }

            }
            return count;
        }
         static bool isGood(int l, int r, int[] nums)
        {
            if (r - l < 2) return false;
            int diff = nums[l] - nums[l + 1];

            for (int i = l + 1; i <= r - 1; i++)
            {
                if (nums[i] - nums[i + 1] != diff)
                    return false;
            }
            return true;

        }
      
    }
}
