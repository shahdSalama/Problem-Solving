using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Algorithms.Dynamic_Programming.Memoization
{
    class CountConstructSol // no fast return
    {
        public static int CountWays(string target, string[] subs, Dictionary<string, int> memo)
        {
            if (target == "") return 1;
            int count = 0;
            foreach (var sub in subs)
            {
                if (sub.Length <= target.Length && target.Substring(0, sub.Length) == sub)
                {
                    var suffix = target.Substring(sub.Length);

                    count += CountWays(suffix, subs, memo);
                }
            }
            memo.TryAdd(target, count);
            return count;
        }
        // time: n*m^2 
        // space:m^2
        public static void Main(string[] args)
        {
            var res2 = CountWays("purple", new string[] { "purp", "p", "ur", "le", "purpl" }, new Dictionary<string, int>());
            var res3 = CountWays("enterapotentpot", new string[] { "a", "p", "ent", "enter", "ot","o","t" }, new Dictionary<string, int>());
        }
    }
}
