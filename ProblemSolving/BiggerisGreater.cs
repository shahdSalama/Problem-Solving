using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank
{
    public class BiggerisGreater
    {
        public const string NO_ANSEWR = "no answer";

        public static string biggerIsGreater(string w)
        {
            if (w.All(x => x == w[0]))
                return NO_ANSEWR;

            // Each letter is bigger than the one after it
            // 0 1 2 3
            // d c b a    length = 4 
           if(AllInDesc(w))
                return NO_ANSEWR;

            return "No Imp";

        }

        private static bool AllInDesc(string w)
        {
            bool allinDesc = true;
            for (int i = 0; i < w.Length - 1; i++)
            {
                if (w[i].CompareTo(w[i + 1]) >= 0)
                    continue;
                else
                {
                    allinDesc = false;
                    break;
                }

            }
            return allinDesc;
        }
    }
}
