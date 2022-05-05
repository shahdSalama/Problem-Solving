using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.MeduimChallenges
{
    class smallestString
    {
        public  static string SmallestStringWithSwaps(string str, List<List<int>> pairs)
        {
            var visited = new HashSet<string>();
            var s = new Stack<string>();
            s.Push(str);
            var res = str;
            while (s.Count != 0)
            {
                var currS = s.Pop();
                if (visited.Contains(currS)) continue;
                visited.Add(currS);
                if (String.Compare(currS, res) < 0)
                {
                    res = currS;
                }
                foreach (var pair in pairs)
                {
                    var nei = Swap(currS, pair);
                    s.Push(nei);


                }

            }
            return res;
        }
       static string Swap(string str, IList<int> pair)
        {

            var stI = pair[0];
            var ndI = pair[1];
            char temp = 'a';
            var s = new StringBuilder(str);
            for (int i = 0; i < str.Length; i++)
            {

                if (i == stI)
                {
                    temp = str[i];
                    s[i] = str[ndI];
                }
                else if (i == ndI)
                {
                    s[ndI] = temp;
                }
              //  else s.Append(str[i]);
            }
            return s.ToString();


        }
       

    }

}
