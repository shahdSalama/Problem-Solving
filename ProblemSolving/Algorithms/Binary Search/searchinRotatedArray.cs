using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Binary_Search
{
    class searchinRotatedArray
    {
        public static int Search(int[] nums, int target)
        {
            int l = 0;
            int mid = 0;
            int r = nums.Length - 1;
            //l     
            //r
            //[4, 5, 6, 7, 0, 1, 2]

            while (l <= r)
            {

                mid = (l + r) / 2;


                if (nums[mid] == target) return mid;
                else if (nums[mid] > target && nums[l] > target) l = mid + 1;

                else if (nums[mid] > target && nums[l] <= target) r = mid - 1;

                else if (nums[mid] > target && nums[r] < target) r = mid - 1;

                else if (nums[mid] < target && nums[r] >= target) l = mid + 1;
                else if (nums[mid] < target && nums[r] < target) r = mid - 1;
                else return -1;
            }
            return -1;
        }
      


    }
}
