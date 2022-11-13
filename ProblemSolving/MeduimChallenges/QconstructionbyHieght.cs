using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.MeduimChallenges
{
    class QconstructionbyHieght
    {
        public static int[][] ReconstructQueue(int[][] people)
        {
            people = people.OrderByDescending(x => x[0]).ThenBy(x => x[1]).ToArray();

            List<int[]> res = new();

            foreach (var p in people)
            {
                res.Insert(p[1], p);
            }

            return res.ToArray();
        }
       
    }
}
