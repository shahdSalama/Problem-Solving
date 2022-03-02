using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.DataStructure.Graph
{
    class castleonthegrid
    {
        public static int minimumMoves(List<string> grid, int startX, int startY, int goalX, int goalY)
        {
            // shortest path bfs
            int reaches = int.MaxValue;
                              //x,  y,    steps
            var q = new Queue<(int, int, int)>();
            var visited = new HashSet<(int, int)>();

            q.Enqueue((startX, startY, 0));
            visited.Add((startX, startY));

            while (q.Count != 0)
            {
                var (currX, currY, currM) = q.Dequeue();
                foreach (var nei in GetNei(grid, currX, currY))
                {
                    int neiX = nei.Item1; 
                    int neiY = nei.Item2;

                    if (visited.Contains((neiX, neiY))) continue;
                    
                    // reached the castle with moves less than last time.
                    if (neiX == goalX && neiY == goalY && currM + 1 < reaches) reaches = currM + 1;

                    visited.Add((neiX, neiY));

                    q.Enqueue((neiX, neiY, currM + 1));
                }
            }
            return reaches;
        }

        public static List<(int, int)> GetNei(List<string> grid, int x, int y)
        {
            var res = new List<(int, int)>();
            // same y dec x untill we reach 0 or X 
            int xup = x;
            while (xup > 0 && grid[xup - 1][y] != 'X')
            {
                xup--;
                res.Add((xup, y));
            }

            int xdown = x;
            while (xdown < grid.Count - 1 && grid[xdown + 1][y] != 'X')
            {
                xdown++;
                res.Add((xdown, y));
            }

            //--

            int yup = y;
            while (yup > 0 && grid[x][yup - 1] != 'X')
            {
                yup--;
                res.Add((x, yup));
            }

            int ydown = y;
            while (ydown < grid.Count - 1 && grid[x][ydown + 1] != 'X')
            {
                ydown++;
                res.Add((x, ydown));
            }

            return res;
        }
    }
}
