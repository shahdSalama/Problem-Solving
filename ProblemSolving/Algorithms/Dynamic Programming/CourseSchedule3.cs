using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Dynamic_Programming
{
    public class Solutionmm
    {
        public static int ScheduleCourse(int[][] courses)
        {
            Array.Sort(courses, (a, b) => a[1].CompareTo(b[1]));
            int totalCount = 0;
            //                 ind, timecons, count   
            var s = new Stack<(int, int, int)>();
            var visited = new Dictionary<(int, int), int>();
            s.Push((0, 0, 0));
            while (s.Count != 0)
            {
                (var currI, var currTime, var currCount) = s.Pop();
                if (visited.TryGetValue((currI, currTime), out int count) && count <= currCount) continue;
                else if (visited.TryGetValue((currI, currTime), out int count2)) visited[(currI, currTime)] = currCount;
                else visited.Add((currI, currTime), currCount);

                totalCount = Math.Max(totalCount, currCount);

                if (currI == courses.Length) continue;



                // take course if posible
                if (currTime + courses[currI][0] <= courses[currI][1])
                {
                    s.Push((currI + 1, currTime + courses[currI][0], currCount + 1));
                }
                // skip course
                s.Push((currI + 1, currTime, currCount));
            }
            return totalCount;
        }

      
    }
}
