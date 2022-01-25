using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank.MeduimChallenges
{
    class SherlockAndAngarams
    {
        public static void Main()
        {
            sherlockAndAnagrams("cdcd");
        }

        public static List<string> GetAllSubstrings(string s)
        {
            var subs = new List<string>();
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 1; j < s.Length - i + 1; j++)
                {
                    subs.Add(s.Substring(i, j));
                }

            }
            return subs;
        }

        public static string arrangedString(string s)
        {
            var charArr = s.ToCharArray();

            Array.Sort(charArr);

            return string.Join("", charArr);

        }


        public static int sherlockAndAnagrams(string s)
        {
            var subs = GetAllSubstrings(s);
            var dic = new Dictionary<string, int>();
            for (int i = 0; i < subs.Count; i++)
            {
                string arranged = arrangedString(subs[i]);
                if (!dic.TryGetValue(arranged, out int value))
                {
                    dic.Add(arranged, 1);
                }
                else dic[arranged]++;
            }

            var values = dic.Values.ToList();

            int count = 0;

            for (int i = 0; i < values.Count; i++)
            {
                count += values[i] * (values[i] - 1) / 2;

            }
            return count;
        }


    }


}
