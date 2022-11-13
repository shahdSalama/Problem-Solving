using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank.Algorithms.Dynamic_Programming
{
    class LongestPalandromicSubstring
    {


        public static string LongestPalindrome(string s)
        {
            int longest = 0;
            string res = "";
            for (int i = 0; i < s.Length; i++)
            {
                int r = i; int l = i;
                while (l >= 0 && r < s.Length && s[l] == s[r])
                {
                    int length = r - l + 1;
                    r++;
                    l--;
                    if (length > longest)
                    {
                        longest = length;
                        res = s.Substring(l, length);

                    }

                }


                r = i + 1; l = i;
                while (l >= 0 && r < s.Length && s[l] == s[r])
                {
                    int length2 = r - l + 1;
                    r++;
                    l--;
                    if (length2 > longest)
                    {
                        longest = length2;
                        res = s.Substring(l, length2);

                    }
                }
            }
            return res;
        }
     
    }

}
