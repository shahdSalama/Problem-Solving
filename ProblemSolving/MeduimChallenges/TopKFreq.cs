using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.MeduimChallenges
{
    class TopKFreq
    {
        public static int[] TopKFrequent(int[] nums, int k)
        {
            var numcount = new Dictionary<int, int>();
            foreach (var num in nums)
            {
                if (!numcount.Keys.Contains(num))
                    numcount.Add(num, 1);
                else numcount[num]++;
            }
            var freq = new List<int>[nums.Length];

            //1->3   2->2    3-1
            foreach (var element in numcount.ToList())
            {
                var num = element.Key; var count = element.Value;
                if (freq[count] == null)
                    freq[count] = new List<int>();
                freq[count].Add(num);
            }
            // [  [3]   [2]   [1]      ]
            // [0, 1 , 2, 3,   4,     5]
            // 
            var res = new List<int>();
            for (int i = freq.Length - 1; i >= 0; i--)
            {
                if (freq[i] == null) continue;
                foreach (var n in freq[i])
                {
                   
                    res.Add(n);
                    if (res.Count == k) return res.ToArray();
                }
            }
            return res.ToArray();
        }
       
    }
}
