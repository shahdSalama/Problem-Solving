using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank
{
    public class AmazonEncoder
    {
        public static int merge(List<int> subFilesSizes)
        {
            var mergedsubfiles = new List<int>();
           

            while (subFilesSizes.Count > 2)
            {
                subFilesSizes.Sort();

                var sum = subFilesSizes[1] + subFilesSizes[0];

                subFilesSizes.Add(sum);
                mergedsubfiles.Add(sum);
                subFilesSizes.RemoveRange(0, 2);

            }
            var sumLast = subFilesSizes.Sum(x => x);
            mergedsubfiles.Add(sumLast);

            return mergedsubfiles.Sum(x => x);
        }
    }
}
