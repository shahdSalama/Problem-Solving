using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Dynamic_Programming.Memoization
{
    class patternmatching
    {
        public bool IsMatch(string s, string p)
        {
            return helper(0, 0, s, p, new Dictionary<(int, int), bool>());

        }
        private bool helper(int i, int j, string s, string p, Dictionary<(int, int), bool> memo)
        {
            if (memo.TryGetValue((i, j), out bool val)) return val;
            if (i >= s.Length && j >= p.Length)
            {
                memo.Add((i, j), true);
                return true;
            }
            // only the pattern is finished 
            if (j >= p.Length)
            {
                memo.Add((i, j), false);
                return false;
            }

            bool match = i < s.Length && (s[i] == p[j] || p[j] == '.');
            if (j + 1 < p.Length && p[j + 1] == '*')
                // use * and mach         ||               do not use
                return match && helper(i + 1, j, s, p, memo) || helper(i, j + 2, s, p, memo);
            if (match)
            {
                var res = helper(i + 1, j + 1, s, p, memo);
                memo.Add((i, j), res);
                return res;
            }
            memo.Add((i, j), false);
            return false;
        }
       
    }
}
