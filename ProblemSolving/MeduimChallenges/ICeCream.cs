using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.MeduimChallenges
{
    class ICeCream
    {
        public static List<int> icecreamParlor(int m, List<int> arr)
        {
            //                          key, remainder,index of key
            var dic = new Dictionary<int, (int, int)>();
            for (int i = 0; i < arr.Count; i++)
            {
                if (!dic.TryGetValue(arr[i], out _))
                {
                    if (dic.TryGetValue(m - arr[i], out (int, int) value2))

                        return new List<int> { value2.Item2, i + 1 };
                    //  3 , (1, 1)
                    dic.Add(arr[i], (m - arr[i], i + 1));

                }
                else // value exist
                {
                    if (arr[i] * 2 == m)
                    {
                        dic.TryGetValue(arr[i], out (int, int) value);
                        return new List<int> { value.Item2, i + 1 };
                    }
                }
            }
            return new List<int> { };
        }
        //public static void Main(string[] args)
        //{
        //      icecreamParlor(4, new List<int> { 1, 4, 5, 3 ,2 });



        //}
    }
}
