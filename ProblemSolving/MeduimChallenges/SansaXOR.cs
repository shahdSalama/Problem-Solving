using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank.MeduimChallenges
{
    class SansaXOR
    {
        public static int XOR(List<int> arr)
        {
            int res = 0;

            for (int i = 0; i < arr.Count; i++)
            {
                res = res ^ arr[i];

            }
            return res;
        }
        public static int sansaXor(List<int> arr)
        {
            var items = new List<int>();

            for (int slow = 1; slow < arr.Count; slow++)
            {
                for (int fast = 0; fast <= arr.Count - slow; fast++)
                {

                    var subset = arr.Skip(fast).Take(slow).ToList();
                    items.Add(XOR(subset));
                }

            }
            return XOR(items);
        }
       
    }
}
