using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.DataStructure.Graph
{
    class closedISlands
    {
        public int ClosedIsland(int[][] grid)
        {

            int count = 0;

            var visited = new HashSet<(int, int)>();

            for (int i = 0; i < grid.Length; i++)
            {

                for (int j = 0; j < grid[0].Length; j++)
                {

                    if (explore(grid, i, j, visited))
                        // a component that is a all 0
                        // and not in edges
                        count++;

                }
            }

            return count;
        }

        public bool explore(int[][] grid, int r, int c, HashSet<(int, int)> visited)
        {
            if (grid[r][c] != 0) return false;

            if (visited.Contains((r, c))) return false;

            if (IsCornerCell(grid, r, c)) return false;

            bool succes = true;
            // dfs the cell
            var s = new Stack<(int, int)>();

            s.Push((r, c));

            visited.Add((r, c));

            while (s.Count != 0)
            {
                (int currR, int currC) = s.Pop();

                foreach (var n in GetN(grid, currR, currC))
                {
                    (int rowN, int colN) = n;

                    if (visited.Contains((rowN, colN))) continue;

                    if (grid[rowN][colN] != 0) continue;

                    if (IsCornerCell(grid, rowN, colN)) succes = false;

                    s.Push((rowN, colN));
                    visited.Add((rowN, colN));
                }


            }
            return succes;


        }

        public List<(int, int)> GetN(int[][] grid, int r, int c)
        {
            var res = new List<(int, int)>();

            if (r - 1 >= 0) res.Add((r - 1, c));
            if (r + 1 < grid.Length) res.Add((r + 1, c));

            if (c - 1 >= 0) res.Add((r, c - 1));
            if (c + 1 < grid[0].Length) res.Add((r, c + 1));

            return res;
        }

        public bool IsCornerCell(int[][] grid, int r, int c)
        {
            if (r == 0) return true;
            if (r == grid.Length - 1) return true;

            if (c == 0) return true;
            if (c == grid[0].Length - 1) return true;

            return false;


        }



    }
}
