using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.DataStructure.Graph
{
    class uniquePathWithObs
    {
        public static int UniquePathsWithObstacles(int[][] grid)
        {

            if (grid.Length == 1 && grid[0].Length == 1 && grid[0][0] == 0) return 1;
            if (grid[0][0] == 1) return 0;

            var q = new Queue<(int, int)>();
            var visited = new HashSet<(int, int)>();

            q.Enqueue((0, 0));
            visited.Add((0, 0));
            int counter = 0;

            while (q.Count != 0)
            {/*
                   0 1 2 3
                0 [0,0,0,0],
                1 [0,1,0,0],
                2 [0,0,0,0],
                3 [0,0,1,0],
                4 [0,0,0,0]]
*/
                (int currR, int currC) = q.Dequeue();

                foreach (var n in GetN(currR, currC, grid))
                {
                    (int nR, int nC) = n;
                    // blocked cell
                    if (grid[nR][nC] == 1) continue;
                    // seen before
                 //   if (visited.Contains(n)) continue;

                    if (nR == grid.Length - 1 && nC == grid[0].Length - 1)
                        counter++;
                    else
                    {
                        q.Enqueue(n);
                        visited.Add(n);
                    }
                }
            }
            return counter;
        }
        private static List<(int, int)> GetN(int r, int c, int[][] grid)
        {
            var res = new List<(int, int)>();

            // right
            if (c + 1 < grid[0].Length) res.Add((r, c + 1));

            // down
            if (r + 1 < grid.Length) res.Add((r + 1, c));

            return res;

        }
      
    }
}
