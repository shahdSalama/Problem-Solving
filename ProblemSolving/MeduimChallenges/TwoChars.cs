using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank.MeduimChallenges
{
    class TwoChars
    {
        public static void Main(string[] args)
        {
         

            int l = Convert.ToInt32(Console.ReadLine().Trim());

            string s = Console.ReadLine();

            int result = alternate(s);

        }
        static bool isTwoAlter(string s)
        {

            // Check if ith character matches  
            // with the character at index (i + 2)  
            for (int i = 0; i < s.Length - 2; i++)
            {
                if (s[i] != s[i + 2])
                {
                    return false;
                }
            }

            // If string consists of a single  
            // character repeating itself  
            if (s[0] == s[1])
                return false;

            return true;
        }
        // Complete the alternate function below.
        static int alternate(string s)
        {
            var distinct = s.ToList().Distinct();

            if (s.Length == 2 && s[0] != s[1])
                return 2;

            List<char> distinctList = distinct.ToList();
            List<string> charOptionList = new List<string>();
            for (int i = 0; i < distinctList.Count(); i++)
            {
                for (int j = i + 1; j < distinctList.Count(); j++)
                {

                    var tempCharList = distinctList.Where(x => x == distinctList[i] || x == distinctList[j]);
                    charOptionList.Add(string.Join("", tempCharList));

                }

            }
            int max = 0;
            for (int i = 0; i < charOptionList.Count; i++)
            {

                var tempString = s.Where(x => x == charOptionList[i][0] || x == charOptionList[i][1]);
                if (isTwoAlter(string.Join("", tempString)))
                {
                    if (string.Join("", tempString).Length > max)
                    {
                        max = string.Join("", tempString).Length;
                    }
                }

            }
            return max;

        }
    }
}
