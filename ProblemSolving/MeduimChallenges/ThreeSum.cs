using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.MeduimChallenges
{
    class ThreeSumi
    {

        public static List<List<int>> ThreeSum(int[] nums)
        {

            var res = new List<List<int>>();
            if (nums.Length < 3) return res;

            Array.Sort(nums);
            nums = nums.Distinct().ToArray();
            for (int i = 0; i < nums.Length; i++)
            {
               // if (i != 0 && nums[i] == nums[i - 1]) continue;
                int val = nums[i];
                int negVal = val * -1;
                int l = i + 1;
                int r = nums.Length - 1;
                while (l < r)
                {
                    if (nums[l] + nums[r] == negVal)
                    {
                        res.Add(new List<int> { nums[l], nums[r], val });
                        r--;
                        l++;
                    }
                   else if (nums[l] + nums[r] > negVal)
                        r--;
                    else
                        l++;
                }
            }
            return res;
        }
   



    }
}

