using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.DataStructure.Graph
{
    class minmax
    {
        public static int maxMin(int k, List<int> arr)
        {
            int unfairness = int.MaxValue;

            //                i , unfairness, the sub arr
            var s = new Stack<(int, int, List<int>)>();

            // at visited[i] we know that we have reached here with this unfiarness
            var visited = new int[arr.Count];

            s.Push((0, 0, new List<int>()));
            while (s.Count != 0)
            {
                (int currI, int currUn, List<int> currSub) = s.Pop();

                // goal
                if (currSub.Count == k)
                {
                    unfairness = Math.Min(unfairness, currUn);
                    continue;
                }
                // out of bounds 
                if (currI >= arr.Count) continue;
                // i have been here but with a better unfairness
                if (visited[currI] != 0 && visited[currI] < currUn) continue;

                visited[currI] = currUn;

                // add the next states to the stack

                // do not use the current number and move
                s.Push((currI + 1, currUn, currSub));
                // use the current number and move
                // calculate unfairness
                // new sub array
                var newSub = currSub.ToList();
                newSub.Add(arr[currI]);
                s.Push((currI + 1, CalculateUnfaireness(newSub), newSub));

            }
            return unfairness;

        }
        private static int CalculateUnfaireness(List<int> list)
        {
            var max = list.Max();
            var min = list.Min();
            return max - min;

        }
    }
}
