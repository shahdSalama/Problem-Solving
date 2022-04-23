using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank.Algorithms.Dynamic_Programming
{
    class LongestPalandromicSubstring
    {

        public static string LongestPalindrome(string s)
        {
            // 0 1 234  5
            // b a bad  cooooc
            if (s.Length == 1) return s[0].ToString();
            string res = "";
            var visited = new HashSet<(int, string)>();
            var stack = new Stack<(int index, string str)>();
            stack.Push((0, s[0].ToString()));
            while (stack.Count != 0)
            {
                (int currI, string currS) = stack.Pop();
                var len = currS.Length;
                if (res.Length < len) res = currS;
                if (len == s.Length) return res;

                if (visited.Contains((currI, currS))) continue;
                visited.Add((currI, currS));

                // can I just take  one more letter // currs is all of same chars and i can add more char to it
                // currS.Length number of chars in currs
                // index of last element in currS = currI+currS.Length-1


                if (currS.All(x => x == currS[0]) && currI + len < s.Length && currS[0] == s[currI + len])
                {
                    var news1 = s.Substring(currI, len + 1);
                    stack.Push((currI, news1));

                }


                // can I take one from forward and one from back
                // aba
                if (currI - 1 >= 0 && currI + len < s.Length)
                {
                    if (s[currI - 1] == s[currI + len])
                    {
                        string news = s.Substring(currI - 1, len + 2);
                        stack.Push((currI - 1, news));
                    }
                }
                // move forward and start a new string
                if (currI + 1 < s.Length)
                    stack.Push((currI + 1, s[currI + 1].ToString()));

            }
            return res;
        }

        
    }
    }
