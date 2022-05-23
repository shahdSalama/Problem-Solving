using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.MeduimChallenges
{
    class fruitsinbasket
    {
        public static int TotalFruit(int[] fruits)
        {
            int res = 0;
            int l = 0;
            var dic = new Dictionary<int, int>();
            for (int r = 0; r < fruits.Length; r++)
            {
                if (dic.Keys.Contains(fruits[r]))
                {
                    dic[fruits[r]]++;
                }

                else if (dic.Keys.Count <= 2)
                {
                    dic.Add(fruits[r], 1);
                }

                while (dic.Keys.Count > 2)
                {
                    dic[fruits[l]]--;
                    if (dic[fruits[l]] == 0) dic.Remove(fruits[l]);
                    l++;

                }

                res = Math.Max(res, r - l + 1);
            }
            return res;
        }
       
    }
}
