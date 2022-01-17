using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank.MeduimChallenges
{
    class SherlokAndValidStrings
    {
        public static bool IsAllSameOrOnlyOneIsMoreByOne(List<int> list)
        {
            // dic key is element in list we are suppose to have only 
            //1 key or 2 keys
            var dic = new Dictionary<int, int>();

            if (list.All(x => x == list[0])) return true;

            for (int i = 0; i < list.Count; i++)
            {
                // int already in dic
                if (dic.TryGetValue(list[i], out int value))
                {
                    dic[list[i]] = value + 1;
                }
                else
                {
                    dic.Add(list[i], 1);
                }
            }
            if (dic.Keys.Count > 2) return false;
            else
            {
                var keys = dic.Keys.OrderBy(x => x).ToList();
                if (keys[1] - keys[0] == 1 &&  dic[keys[1]] == 1 || keys[0] == 1 && dic[keys[0]] == 1) return true;
                else return false;
            }



        }

        public static string isValid(string s)
        {
            var dic = new Dictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
            {
                // char already in dic
                if (dic.TryGetValue(s[i], out int value))
                {
                    dic[s[i]] = value + 1;

                }
                else
                {
                    dic.Add(s[i], 1);

                }
            }

            var values = dic.Values.ToList();
            if (IsAllSameOrOnlyOneIsMoreByOne(values)) return "YES";
            else return "NO";

        }


        public static void Main(string[] args)
        {
            //  TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string s = Console.ReadLine();

            string result = isValid(s);


        }

    }
}
