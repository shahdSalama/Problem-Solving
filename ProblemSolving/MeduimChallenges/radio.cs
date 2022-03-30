using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.MeduimChallenges
{
    class radio
    {
        /*
 * Complete the 'hackerlandRadioTransmitters' function below.
 *
 * The function is expected to return an INTEGER.
 * The function accepts following parameters:
 *  1. INTEGER_ARRAY x
 *  2. INTEGER k
 */

        public static int hackerlandRadioTransmitters(List<int> x, int k)
        {
            int i = 0;
            int count = 0;

            while (i < x.Count)
            {
                int maxTransmittingHouse = x[i] + k;

                count++;

                while (i < x.Count && x[i] <= maxTransmittingHouse)
                    i++;

                int lastHouse = x[i - 1] + k;

                while (i < x.Count && x[i] <= lastHouse)
                    i++;
            }
            return count;

        }


       
    }
}
