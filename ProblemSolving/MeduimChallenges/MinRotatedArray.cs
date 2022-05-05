using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.MeduimChallenges
{
    class MinRotatedArray
    {
        public static int FindMin(int[] nums)
        {
            int l = 0;
            int r = nums.Length - 1;
            int mid = 0;
            // [,3,4,5,1, 2]  
            while (l < r)
            {
                mid = (l + r) / 2;
                if (nums[mid] < nums[mid + 1] && nums[mid + 1] <= nums[r])
                    r = mid;
                else if (nums[mid] < nums[mid + 1] && nums[mid + 1] > nums[r])
                    l = mid - 1;
                else if (nums[mid] > nums[mid + 1])
                    return nums[mid + 1];


            }
            return Math.Min(nums[0], nums[mid]);
        }

       
    }
}