using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Dynamic_Programming
{
    class MaxWigle
    {
        public static int WiggleMaxLength(int[] nums)
        {
            var visited = new Dictionary<int, int>();
            var s = new Queue<(int index, int count, int isInc)>();
            var res = 0;
            s.Enqueue((0, 1, 0));
            while (s.Count != 0)
            {
                (int currIndex, int currCount, int currWiggle) = s.Dequeue();
                res = Math.Max(res, currCount);
                // have i been here before with a better count
                if (visited.TryGetValue(currIndex, out int count) && count >= currCount)
                    continue;
                // have i been here before with less count
                else if (visited.TryGetValue(currIndex, out int _))
                    visited[currIndex] = currCount;
                // I have never been here before
                else
                    visited.Add(currIndex, currCount);


                // decisions
                // take another element from forward   
                if (currIndex + 1 < nums.Length)
                {
                    if (currWiggle == 0) // very fist time
                    {
                        for (int i = currIndex; i < nums.Length; i++) // i can take any of the following
                            if (nums[i] < nums[currIndex]) // we are dec
                                s.Enqueue((i, currCount + 1, 2));
                            else if (nums[i] > nums[currIndex])
                                s.Enqueue((i, currCount + 1, 1)); // we are inc
                    }
                    else if (currWiggle == 1) // we need to dec
                    {
                        // find all the values in the array where index on value is bigger than curr index and the value is less than the value in curr index
                        for (int i = currIndex; i < nums.Length; i++)
                            if (nums[i] < nums[currIndex])
                                s.Enqueue((i, currCount + 1, 2));
                    }
                    else if (currWiggle == 2) // we need to inc
                    {
                        for (int i = currIndex; i < nums.Length; i++)
                            if (nums[i] > nums[currIndex])
                                s.Enqueue((i, currCount + 1, 1));
                    }

                    //2. start a new sq        
                    s.Enqueue((currIndex + 1, 1, 0));
                }

            }
            return res;
        }
    
  
    }
}
