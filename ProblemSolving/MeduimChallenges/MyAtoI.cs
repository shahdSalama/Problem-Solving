using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.MeduimChallenges
{
    class MyAtoI
    {
        public static int MyAtoi(string s)
        {

            int res = 0;

            s = s.Trim();

            if (s.Length == 0) return res;

            bool positive = true;
            int i = 0;

            if (s[0] == '-')
            {
                positive = false;
                i++;
            }
            else if (s[0] == '+')
                i++;

            if (!char.IsDigit(s[i])) return res;

            var ns = "";

            while (i < s.Length && char.IsDigit(s[i]))
            {
                ns += s[i];
                i++;
            }

            // handle overflows
            int max = int.MaxValue;
            int min = int.MinValue;

            string maxs = max.ToString();
            string mins = min.ToString();
            if (!positive) ns = '-' + ns;
            if (positive && ns.Length > maxs.Length) return int.MaxValue;
            if (!positive && ns.Length > mins.Length) return int.MinValue;
            if (maxs.Length == ns.Length && positive)
            {
                for (int j = 0; j < maxs.Length; j++)
                {
                    int numi = int.Parse(ns[j].ToString());
                    int maxsi = int.Parse(maxs[j].ToString());
                    if (numi > maxsi) return int.MaxValue;
                    // no overflow
                    else if (numi < maxsi)
                        break;

                }
            }
            else if (mins.Length == ns.Length && !positive)
            {
                for (int j = 1; j < maxs.Length; j++)
                {
                    int numi = int.Parse(ns[j].ToString());
                    int minsi = int.Parse(mins[j].ToString());
                    if (numi > minsi) return int.MinValue;
                    // no overflow
                    else if (numi < minsi)
                        break;

                }
            }

            bool resb = int.TryParse(ns, out int val);

            // now we have a number in string and we want to parse it
            return resb ? val : 0;
        }
      
    }
}
