using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.MeduimChallenges
{
    class MinAbsDifference
    {
        static int minAbs(int[] nums)
        {

            if (nums.Length == 0) return 0;
            //               index, s1  , s2
            var s = new Stack<(int, int, int)>();
            int minDiff = int.MaxValue;
            var visited = new HashSet<(int, int, int)>();
            s.Push((0, 0, 0));
            while (s.Count != 0)
            {

                (int currI, int currs1, int currs2) = s.Pop();
                if (currI == nums.Length)
                {
                    minDiff = Math.Min(minDiff, Math.Abs(currs1 - currs2));
                    continue;
                }
                if (visited.Contains((currI, currs1, currs2))) continue;
                visited.Add((currI, currs1, currs2));

                s.Push((currI + 1, currs1 + nums[currI], currs2));
                s.Push((currI + 1, currs1 , currs2 + nums[currI]));

            }
            return minDiff;

        }
       
    }
}
