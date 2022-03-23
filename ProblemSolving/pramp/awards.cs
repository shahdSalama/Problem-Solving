using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.pramp
{
    class awards
    {
        public static double FindGrantsCap(double[] grants, double newBudget)
        {
            Array.Sort(grants);

            var minGrant = grants[0];
            //  38
            var cap = newBudget / grants.Length;

            while (cap > minGrant)
            {
                // calculate new cap
                // not affected by new cap
                // 2, 2, 12
                var lessThanGrantList = grants.Where(x => x < cap).OrderBy(x => x).ToList();

                //(190 -(16)) /( 5-3) = 87
                cap = (newBudget - (lessThanGrantList.Sum())) / (grants.Length - lessThanGrantList.Count);
                // 50
                minGrant = grants.Skip(lessThanGrantList.Count).Take(1).FirstOrDefault();


            }
            return cap;

        }
    }
}
