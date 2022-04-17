using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.HardChallenges
{
    class minwindowsub
    {

        public static string MinWindow(string s, string t)
        {

            var charArrT = t.ToList();
            if (!t.All(x => charArrT.Contains(x)) || t.Length > s.Length) return "";
            if (s.All(x => x == s[0])) return s[0].ToString();
            var x = new List<(char c, int i)>(); 
            for (int i = 0; i < s.Length; i++)
            {
                if (charArrT.Contains(s[i]))
                    x.Add((s[i], i));
            }
            
            int l = 0;
            int r = 0;
            string sub = s;

            var set = new List<char>();
            foreach (var c in charArrT)
                set.Add(c); //AA

            while (r < x.Count)
            {// s = AA
                // x = (A, 0), (A, 1)  l = 0 , r = 1  , 2
                set.Remove(x[r].c); //set =
         
                if (set.Count == 0)
                {
                    if (sub.Length >= x[r].i - x[l].i + 1)
                        sub = s.Substring(x[l].i, x[r].i - x[l].i +1);
                    // update pointers
                    l++;
                    r = l;
                   
                    foreach (var c in charArrT)
                        set.Add(c);

                }
                else
                r++; // r = 1
            }
            return sub;

        }
       
    }

}
