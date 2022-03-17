using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.DataStructure.Graph
{
    class shortestPathDiagonal
    {
        public static int ShortestPathBinaryMatrix(int[][] grid)
        {
            // we want to go from 0, 0 till grid.Length-1, grid.Length-1;
            // find shortes path bfs

            var q = new Queue<(int, int, int)>();

            if (grid[0][0] != 0) return -1;
            if (grid[grid.Length - 1][grid.Length - 1] != 0) return -1;

            q.Enqueue((0, 0, 1));
            grid[0][0] = 1;
            while (q.Count != 0)
            {
                (int currR, int currC, int currS) = q.Dequeue();

                if (currR == grid.Length - 1 && currC == grid.Length - 1)

                    return currS;



                foreach (var n in GetN(currR, currC, grid))
                {
                    (int nR, int nC) = n;
                    if (grid[nR][nC] != 0) continue;

                    q.Enqueue((nR, nC, currS + 1));
                    grid[nR][nC] = 1;
                }

            }
            return -1;
        }

        public static List<(int, int)> GetN(int r, int c, int[][] grid)
        {
            var res = new List<(int, int)>();
            bool rup = (r - 1 >= 0);
            bool rdown = (r + 1 < grid.Length);

            bool cleft = (c - 1 >= 0);
            bool cright = (c + 1 < grid.Length);

            if (rup) res.Add((r - 1, c));
            if (rdown) res.Add((r + 1, c));

            if (cleft) res.Add((r, c - 1));
            if (cright) res.Add((r, c + 1));

            if (rup && cleft) res.Add((r - 1, c - 1));
            if (rup && cright) res.Add((r - 1, c + 1));

            if (rdown && cleft) res.Add((r + 1, c - 1));
            if (rdown && cright) res.Add((r + 1, c + 1));

            return res;
        }
      
    }
}
