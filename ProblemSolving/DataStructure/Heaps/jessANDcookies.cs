using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.MeduimChallenges
{
    class jessANDcookies
    {
        public static int cookies(int k, List<int> a)
        {
            int i = 0;


            a.Sort(); // sorting ascending, time: (nLogn)

            while (a.Count > 1 && a[0] < k)
            {

                {
                    var temp1 = a[0];
                    var temp2 = a[1];

                    var newCookie = temp1 + (2 * temp2);
                    a.RemoveAt(0);
                    a.RemoveAt(1);

                    int index = a.BinarySearch(newCookie);
                    if (index < 0) a.Insert(~index, newCookie);
                    else a.Insert(index, newCookie);

                    i++;
                }
            }
            if (a[0] < k) return -1;
            return i;
        }
    }
}
