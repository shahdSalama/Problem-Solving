using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    public class BreakingTheRecord
    {
        public static List<int> breakingRecords(List<int> scores)
        {
            var min = scores[0];
            var max = scores[0];

            int minCount = 0;
            int maxCount = 0;

            for (int i = 1; i < scores.Count; i++)
            {
                if (scores[i] < min)
                {
                    min = scores[i];
                    minCount++;
                }
                if (scores[i] > max)
                {
                    max = scores[i];
                    maxCount++;
                }
            }
            return new List<int> { maxCount, minCount };
        }

       

    }
}
