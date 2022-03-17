using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.DataStructure.Graph
{
    class shortestBridgesol
    {
        public static int ShortestBridge(int[][] grid)
        {
            bool firstISlandFound = false;
            Queue<(int, int, int)> q = new Queue<(int, int, int)>();
            var visited = new HashSet<(int, int)>();
            for (int i = 0; i < grid.Length; i++)
            {

                for (int j = 0; j < grid.Length; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        firstISlandFound = true;
                        q = explore(grid, i, j, visited);
                    }
                    if (firstISlandFound) break;
                }
                if (firstISlandFound) break;
            }

            int res = int.MaxValue;
            // do bfs with the queue to find any cell that has 1 on it

            while (q.Count > 0)
            {
                (int currR, int currC, int currD) = q.Dequeue();

                foreach (var n in GetN(currR, currC, grid))
                {
                    if (visited.Contains(n)) continue;
                    (int nR, int nC) = n;

                    visited.Add(n);

                    if (grid[nR][nC] == 1)
                        res = Math.Min(res, currD);
                    else if (grid[nR][nC] == 0)
                        q.Enqueue((nR, nC, currD + 1));
                }
            }
            return res;
        }

        public static Queue<(int, int, int)> explore(int[][] grid, int r, int c, HashSet<(int, int)> visited)
        {
            var q = new Queue<(int, int, int)>();
            // to get the cells in the 1st island i am gonna use a stack and do a dfs
            var s = new Stack<(int, int)>();
            s.Push((r, c));
          
            while (s.Count != 0)
            {
                // a cell in the 1st land
                (int currR, int currC) = s.Pop();

                foreach (var n in GetN(currR, currC, grid))
                {
                    if (visited.Contains(n)) continue;
                    visited.Add(n);
                    (int nR, int nC) = n;
                    if (grid[nR][nC] == 1)
                    {
                        s.Push(n);
                        grid[nR][nC] = 2;
                    }
                    else if (grid[nR][nC] == 0)
                        q.Enqueue((nR, nC, 1));
                }
            }
            return q;
        }


        public static List<(int, int)> GetN(int r, int c, int[][] grid)
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
