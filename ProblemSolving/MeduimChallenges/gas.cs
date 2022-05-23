using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.MeduimChallenges
{
    class gas
    {
        public static int CanCompleteCircuit(int[] gas, int[] cost)
        {
            //[5,1,2,3,4]
            //[4,4,1,5,1]
            for (int i = 0; i < cost.Length; i++)
            {
                if (TryCompleteACycle(i, cost, gas))
                    return i;
            }
            return -1;
        }
        static bool TryCompleteACycle(int start, int[] cost, int[] gas)
        {
            int n = cost.Length;

            int fuel = gas[start];

            for (int i = start; i < n - 1; i++)
            {
                if (fuel - cost[i] >= 0)
                    fuel = fuel - cost[i] + gas[i + 1];
                else return false;
            }
            if (start == 0) return true;
            if (fuel - cost[n - 1] < 0) return false;
            fuel -= cost[n - 1] + gas[0];

            for (int i = 0; i < start - 1; i++)
            {
                if (fuel - cost[i] >= 0)
                    fuel = fuel - cost[i] + gas[i + 1];
                else return false;
            }
            return true;
        }
       
    }
}
