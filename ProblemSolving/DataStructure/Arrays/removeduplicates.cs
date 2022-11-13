using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.DataStructure.Arrays
{
    class removeduplicates
    {

        public static int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 1) return 1;
            else if (nums.Length == 2)
            {
                if (nums[0] == nums[1]) return 1;
                else return 2;

            }

            int l = 0;
            int r = 1;
            while (r < nums.Length - 1)
            {
                while (nums[r] == nums[l] && r < nums.Length - 1)
                {
                    r++;
                }

                l++;
                nums[l] = nums[r];
            }
            return l + 1;
        }

     
    }
}
