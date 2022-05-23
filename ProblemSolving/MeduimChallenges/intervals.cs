using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.MeduimChallenges
{
    class intervals
    {
        public static int[][] Merge(int[][] intervals)
        {

            List<int[]> res = new List<int[]>();
            if (intervals.Length == 0) return res.ToArray();
            intervals = intervals.OrderBy(x => x[0]).ToArray();

            int start = intervals[0][0];  // 8
            int end = intervals[0][1];   // 10

            for (int i = 0; i < intervals.Length - 1; i++)
            {

                if (end >= intervals[i + 1][0])
                {
                    end = Math.Max(intervals[i + 1][1], end);   // end =  18

                }
                else
                {
                    res.Add(new int[] { start, end });

                    start = intervals[i + 1][0];
                    end = intervals[i + 1][1];
                }
            }
            res.Add(new int[] { start, end });
            return res.ToArray();  // 
        }
       
    }
}
