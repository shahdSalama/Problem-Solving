using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HackerRank
{
    public class Solution
    {
        //23
        public IList<string> LetterCombinations(string digits)
        {
            IList<string> res = new List<string>();

            var dic = new Dictionary<char, List<char>>();
            if (digits == "" || digits == null)
                return res;

            dic.Add('2', new List<char> { 'a', 'b', 'c' });
            dic.Add('3', new List<char> { 'd', 'e', 'f' });
            dic.Add('4', new List<char> { 'g', 'h', 'i' });
            dic.Add('5', new List<char> { 'j', 'k', 'l' });
            dic.Add('6', new List<char> { 'm', 'n', 'o' });
            dic.Add('7', new List<char> { 'p', 'q', 'r', 's' });
            dic.Add('8', new List<char> { 'v', 't', 'u' });
            dic.Add('9', new List<char> { 'x', 'w', 'y', 'z' });

            var s = new Stack<(string, int)>();
            var digitstring = digits.ToString();

            var firstdigit = digitstring[0];

            foreach (var ch in dic[firstdigit])
                s.Push((ch.ToString(), 0));

            int n = digitstring.Length;

            while (s.Count != 0)
            {
                (var currS, int currI) = s.Pop();

                if (currS.Length == n)
                {
                    res.Add(currS);
                    continue;
                }

                if (currI == n - 1) continue;

                //(a, 0)  (b, 0) (c,0)
                // get next number

                foreach (var c in dic[digitstring[currI + 1]])
                {

                    var news = currS + c;
                    s.Push((news, currI + 1));

                }
             
            }

            return res;

        }
    }
}

