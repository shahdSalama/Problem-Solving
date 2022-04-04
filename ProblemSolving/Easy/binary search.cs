using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Easy
{
    class binary_search
    {
        public static int Search(int[] nums, int target)
        {
            int left = 0;

            int right = nums.Length - 1; //5

            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (nums[mid] == target) return mid;
                if (nums[mid] > target) right = mid - 1;
                if (nums[mid] < target) left = mid + 1;
            }
            return -1;
        }
            //  [-1,0,3,5,9,12], target = 9
            public static void Main(string[] args)
        {
            Search(new int[] { -1, 0, 3, 5, 9, 12 }, 2);

        }

    }

}
