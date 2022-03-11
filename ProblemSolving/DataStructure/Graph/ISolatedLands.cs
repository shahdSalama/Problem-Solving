using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.DataStructure.Graph
{
    class ISolatedLands
    {
        public static int NumEnclaves(int[][] grid)
        {
            int IsolatedLandsCells = 0;

            var visited = new HashSet<(int, int)>();

            for (int r = 0; r < grid.Length; r++)
            {
                for (int c = 0; c < grid[0].Length; c++)
                {

                    (int count, bool succ) = Explore(grid, r, c, visited);
                    if (succ) IsolatedLandsCells += count;

                }

            }
            return IsolatedLandsCells;
        }

        public static  (int, bool) Explore(int[][] grid, int r, int c, HashSet<(int, int)> visited)
        {
            if (grid[r][c] == 0) return (0, false);

            if (visited.Contains((r, c))) return (0, false);

            if (IsBoundryCell(grid, r, c)) return (0, false);

            var s = new Stack<(int, int)>();

            s.Push((r, c));

            visited.Add((r, c));

            int count = 1;
            bool success = true;
            while (s.Count != 0)
            {
                (int currR, int currC) = s.Pop();

                foreach (var n in GetN(grid, r, c))
                {
                    (int rn, int cn) = n;
                    if (visited.Contains(n)) continue;
                    if (IsBoundryCell(grid, rn, cn)) success = false;
                    else count++;
                    visited.Add(n);
                    s.Push(n);
                }
            }
            return (count, success);
        }

        public static List<(int, int)> GetN(int[][] grid, int r, int c)
        {
            var res = new List<(int, int)>();
            if (r - 1 >= 0 && grid[r - 1][c] == 1) res.Add((r - 1, c));
            if (r + 1 < grid.Length && grid[r + 1][c] == 1) res.Add((r + 1, c));

            if (c - 1 >= 0 && grid[r][c - 1] == 1) res.Add((r, c - 1));
            if (c + 1 < grid[0].Length && grid[r][c + 1] == 1) res.Add((r, c + 1));
            return res;
        }

        public static bool IsBoundryCell(int[][] grid, int r, int c)
        {
            if (r == 0) return true;
            if (r == grid.Length - 1) return true;

            if (c == 0) return true;
            if (c == grid[0].Length - 1) return true;
            return false;
        }

  //     // [[0,1,1,0],[0,0,1,0],[0,0,1,0],[0,0,0,0]]
  //          NumEnclaves(new int[][] {
  //       new int[]{   0,0,0,1,1,1,0,1,0,0 },
  //new int[]{ 1,1,0,0,0,1,0,1,1,1 },
  //new int[]{ 0,0,0,1,1,1,0,1,0,0 },
  //new int[]{ 0,1,1,0,0,0,1,0,1,0 },
  //new int[]{ 0,1,1,1,1,1,0,0,1,0 },
  //new int[]{ 0,0,1,0,1,1,1,1,0,1 },
  //new int[]{ 0,1,1,0,0,0,1,1,1,1 },
  //new int[]{  0,0,1,0,0,1,0,1,0,1 },
  //new int[]{ 1,0,1,0,1,1,0,0,0,0 },
  //new int[]{  0,0,0,0,1,1,0,0,0,1 }
  //          });
  //      }
    }
}
