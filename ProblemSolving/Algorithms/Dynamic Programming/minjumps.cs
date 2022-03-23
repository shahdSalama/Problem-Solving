using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Dynamic_Programming
{
    class minjumps
    {  //  0,  1,  2,  3,  4,  5
        // 2 , 3 , 2 , 1 , 1 , 4
        public static int Jump(int[] nums)
        {
            //                 index, steps taken to reach
            var s = new Stack<(int, int)>();
            //visited array will have the steps taken to reach an index
            
            // min steps taken to reach the index    
            var visited = new int[nums.Length - 1];
            int min = Int32.MaxValue;

            s.Push((0, 0));
            // visited[0] = 0;

            while (s.Count != 0)
            {
                (int currI, int currSteps) = s.Pop();

                // goal
                if (currI == nums.Length - 1)
                {
                    min = Math.Min(currSteps, min);
                    continue;
                }
                // after boundry
                if (currI > nums.Length - 1) continue;

                // i've reached here with min number of steps
                if (visited[currI] != 0 && visited[currI] < currSteps) continue;

                visited[currI] = currSteps;

                foreach (var n in GetN(currI, nums))
                {
                    s.Push((n, currSteps+1));
                }
            }
            return min;
        }
        // Gets List of indexed I can reach from current index
        // value is 2 i is 3 i can reach 3+1 and 3+2
        public static List<int> GetN(int currentI, int[] nums)
        {
            var res = new List<int>();
            for (int i = 1; i <= nums[currentI]; i++)
            {
                res.Add(currentI + i);
            }
            return res;
        }
       
    }
}

