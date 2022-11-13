using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Easy
{
    class moveZeros
    {
        public static void MoveZeroes(int[] nums)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                int j = i + 1;
                if (nums[i] == 0)
                {
                    while (j < nums.Length && nums[j] == 0)
                        j++;
                    // swap
                    int temp = nums[i];
                    nums[i] = nums[j];
                    nums[j] = temp;

                }

            }
        }
      
    }
}
