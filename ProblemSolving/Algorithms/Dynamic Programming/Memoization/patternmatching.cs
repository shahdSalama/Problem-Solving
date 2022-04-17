using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Dynamic_Programming.Memoization
{
    class patternmatching
    {
        public static bool IsMatch(string text, string pattern)
        {
            // we are finished with both
            return helper(0, 0, text, pattern, new Dictionary<(int, int), bool>());
        }
        public static bool helper(int i, int j, string text, string pattern, Dictionary<(int, int), bool> memo)
        {
            if (memo.TryGetValue((i, j), out bool val)) return val;
            if (i >= text.Length && j >= pattern.Length) return true;
            // finished with pattern only.. not good
            if (j >= pattern.Length) return false;

            bool match = (i < text.Length && (text[i] == pattern[j] || pattern[j] == '.'));
            // next element is star  
            if (pattern[j + 1] < pattern.Length && pattern[j + 1] == '*')
            { // use star and match, or do not use
                var res = helper(i + 1, j, text, pattern, memo) || helper(i, j + 2, text, pattern, memo);
                memo.Add((i, j), res);
                return res;

            }
            if (match)
            {
                var res2 = helper(i + 1, j + 1, text, pattern, memo);
                memo.Add((i, j), res2);
                return res2;
            }
            memo.Add((i, j), false);
            return false;

        }


    }
}
