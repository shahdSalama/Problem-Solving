using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.DataStructure.Graph
{
    public class Solutionjj
    {
        public static int MaxDistance(int[][] grid)
        {
            // foreach water cell determine the nearist land
            int max = -1;
            var visited = new HashSet<(int, int)>();
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid.Length; j++)
                {
                    if (grid[i][j] == 0)
                    {
                        int minDistToLand = explore(grid, i, j, visited);
                        max = Math.Max(max, minDistToLand);
                    }

                }

            }
            return max;
        }


        // returns the nearest land cell for this water cell
        public static int explore(int[][] grid, int r, int c, HashSet<(int, int)> visited)
        {
            var q = new Queue<(int, int)>();
            visited.Add((r, c));
            q.Enqueue((r, c));
            int d = 0;
            while (q.Count != 0)
            {
                (int currR, int currC) = q.Dequeue();
                if (grid[currR][currC] == 1) 
                    return Math.Abs(currR - r) + Math.Abs(currC - c);
                foreach (var n in GetN(grid, currR, currC))
                {
                    if (visited.Contains(n)) continue;
                    q.Enqueue(n);
                    visited.Add(n);
                }
            }
            return d;
        }
        public static List<(int, int)> GetN(int[][] grid, int r, int c)
        {
            var res = new List<(int, int)>();
            if (r - 1 >= 0) res.Add((r - 1, c));
            if (r + 1 < grid.Length) res.Add((r + 1, c));
            if (c - 1 >= 0) res.Add((r, c - 1));
            if (c + 1 < grid.Length) res.Add((r, c + 1));

            return res;

        }
      
    }
}
