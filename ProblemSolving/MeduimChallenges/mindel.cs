using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.MeduimChallenges
{
    class mindel
    {
        public static int MinDeletions(string s)
        {
            // "aaabbbcc"

            var dic = ConstructDic(s);
            int count = 0;
            var nums = dic.Select(x => x.Value).OrderByDescending(x => x).ToList();
            // 1
            // 0 1 2    len = 3
            // 3 2 1
            for (int i = 0; i < nums.Count; i++)
            {
                int j = i + 1;
                while (j < nums.Count && nums[j] == nums[i] && nums[i] != 0)
                {
                    nums[j]--;
                    j++;
                    count++;
                }
            }
            return count;

        }
        static Dictionary<char, int> ConstructDic(string s)
        {
            var dic = new Dictionary<char, int>();
            foreach (var n in s)
            {
                if (dic.Keys.Contains(n))
                    dic[n]++;
                else dic.Add(n, 1);
            }
            return dic;
        }
       
    }
}
