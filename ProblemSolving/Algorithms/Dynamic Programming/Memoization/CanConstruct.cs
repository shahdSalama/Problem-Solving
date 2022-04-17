using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Algorithms.Dynamic_Programming
{

    class CanConstructSol
    {
        static bool canConstruct(string target, string[] subs, Dictionary<string, bool> memo)
        {
            if (memo.TryGetValue(target, out bool val)) return val;
            if (target == "") return true;

            foreach (var sub in subs)
            {
                if (sub == target.Substring(0, sub.Length))
                {
                    var suffix = target.Substring(sub.Length);
                    if (canConstruct(suffix, subs, memo) == true)
                    {
                        memo.Add(target, true);
                        return true;
                    }
                }
            }
            memo.Add(target, false);
            return false;
        }
        //"catsandog"
      //  ["cats","dog","sand","and","cat"]
        // time:m^2*n
        //  .. space: m^2   remember the sufffix
       
    }
}
