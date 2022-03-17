using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.DataStructure.Graph
{
    class pacificAtlanticOcean
    {
        public static List<List<int>> PacificAtlantic(int[][] grid)
        {

            var res = new List<List<int>>();
            var pacificQ = new Queue<List<int>>();
            var atlanticQ = new Queue<List<int>>();
            int n = grid.Length; int m = grid[0].Length;
            bool[,] pVisited = new bool[n, m];
            bool[,] aVisited = new bool[n, m];
            // horizontal
            for (int i = 0; i < grid[0].Length; i++)
            {
                pacificQ.Enqueue(new List<int> { 0, i });
                atlanticQ.Enqueue(new List<int> { grid.Length - 1, i });
            }


            // vartical
            for (int i = 0; i < grid.Length; i++)
            {
                pacificQ.Enqueue(new List<int> { i, 0 });
                atlanticQ.Enqueue(new List<int> { i, grid[0].Length - 1 });
            }

            bfs(grid, pacificQ, pVisited);
            bfs(grid, atlanticQ, aVisited);


            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {

                    if (pVisited[i, j] && aVisited[i, j])
                        res.Add(new List<int> { i, j });
                }

            }

            return res;
        }
        public static void bfs(int[][] grid, Queue<List<int>> oceanQ, bool[,] oVisited)
        {
            while (oceanQ.Count != 0)
            {
                List<int> curr = oceanQ.Dequeue();
                oVisited[curr[0], curr[1]] = true;

                foreach (var n in GetN(grid, curr))
                {

                    if (grid[n[0]][n[1]] < grid[curr[0]][curr[1]]) continue;
                    if (oVisited[n[0], n[1]]) continue;
                    oceanQ.Enqueue(new List<int> { n[0], n[1] });
                }
            }
        }

        public static List<List<int>> GetN(int[][] grid, List<int> curr)
        {
            int r = curr[0]; int c = curr[1];
            var res = new List<List<int>>();
            if (r - 1 >= 0) res.Add(new List<int> { r - 1, c });
            if (r + 1 < grid.Length) res.Add(new List<int> { r + 1, c });

            if (c - 1 >= 0) res.Add(new List<int> { r, c - 1 });
            if (c + 1 < grid[0].Length) res.Add(new List<int> { r, c + 1 });
            return res;
        }


    }
}
