using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.MeduimChallenges
{
    class reverse
    {
        public static int Reverse(int x)
        {
            int max = int.MaxValue;
            int min = int.MinValue;
            string maxstr = max.ToString();
            string minstr = min.ToString();
            // "234"  "142"   
            string xstr = x.ToString();

            if (x < 0)
            {
                xstr = xstr.Substring(1, xstr.Length - 1) + xstr[0];
            }
            var arr = xstr.ToArray();
            Array.Reverse(arr);

            if (xstr.Length == maxstr.Length)
            {
                if (arr[0] != '-')
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        int maxi = int.Parse(maxstr[i].ToString());
                        int xi = int.Parse(arr[i].ToString());
                        if (xi > maxi)
                            return 0;
                        else if (xi < min) break;
                    }
                }
            }
            else if (xstr.Length == minstr.Length)
            {
                for (int i = 1; i < arr.Length; i++)
                {
                    int mini = int.Parse(minstr[i].ToString());
                    int xi = int.Parse(arr[i].ToString());
                    if (xi > mini)
                        return 0;
                    else if (xi < min) break;
                }

            }
            string s = string.Join("", arr);
            return int.Parse(s);

        }
       
    }
}
