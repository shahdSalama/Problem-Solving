using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank.Algorithms.Dynamic_Programming.Memoization
{
    class AllConstructSol
    {
        static List<List<string>> allConstruct(string target, string[] subs, Dictionary<string, List<List<string>>> memo)
        {
            if (memo.TryGetValue(target, out List<List<string>> val)) return val;
            if (target == "") return new List<List<string>>();

            List<List<string>> res = new List<List<string>>();
            foreach (var sub in subs)
            {
                if (sub.Length <= target.Length && target.Substring(0, sub.Length) == sub)
                {
                    var suffix = target.Substring(sub.Length);
                    var suffixWays = allConstruct(suffix, subs, memo);
                    
                    var targetways = suffixWays;
                    
                    if (targetways.Count == 0 && suffix == "")
                    {
                        targetways.Add(new List<string> { sub });
                    }
                    else
                    {
                        foreach (var way in suffixWays)
                        {

                           way.Add(sub);
                        }
                    }
                    res.Add(suffixWays.SelectMany(x => x).ToList());

                }
            }
            memo.Add(target, res);
            return res;
        }
        //public static void Main(string[] args)
        //{
        //    var res2 = allConstruct("purple", new string[] { "purp", "p", "ur", "le", "purpl" }, new Dictionary<string, List<List<string>>> ());
        //    //  var res3 = CountWays("enterapotentpot", new string[] { "a", "p", "ent", "enter", "ot", "o", "t" }, new Dictionary<string, int>());
        //}
    }
}
