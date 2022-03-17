using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Dynamic_Programming
{
    class DeleteandEarnn
    {

        public static int DeleteAndEarn(int[] nums)
        {
            var dic = GetDic(nums);
            int earn1 = 0; int earn2 = 0;
            Array.Sort(nums);
            var dis = nums.Distinct().ToArray();

            for (int i = 0; i < dis.Length; i++)
            {
                int currEarn = dis[i] * dic[dis[i]];

                if (i > 0 && dis[i] == dis[i - 1] + 1)
                {
                    var temp = earn2;
                    earn2 = Math.Max(currEarn + earn1, earn2);
                    earn1 = temp;
                }
                else
                {
                    var temp = earn2;
                    earn2 = currEarn + earn2;
                    earn1 = temp;
                }
            }
            return earn2;
        }


        public static Dictionary<int, int> GetDic(int[] nums)
        {
            var res = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (res.TryGetValue(nums[i], out int val))
                    res[nums[i]]++;
                else
                    res.Add(nums[i], 1);

            }
            return res;
        }
        public static List<int> GetN(int index, int[] nums)
        {
            var res = new List<int>();

            for (int i = index + 1; i < nums.Length; i++)
                res.Add(i);
            return res;

        }
    
    }
}
