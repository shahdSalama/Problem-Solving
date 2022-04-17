using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Dynamic_Programming.Memoization
{
    class uniquePath2
    {
        public static int UniquePathsWithObstacles(int[][] grid)
        {
            return dfs(0, 0, grid, new Dictionary<(int, int), int>());
        }

        public static int dfs(int r, int c, int[][] grid, Dictionary<(int, int), int> memo)
        {
           

            if (r < 0 || c < 0 || r == grid.Length || c == grid[0].Length || grid[r][c] == 1) return 0;
            if (r == grid.Length - 1 && c == grid.Length - 1) return 1;

            if (memo.TryGetValue((r, c), out int val)) return val;

            int res = dfs(r, c + 1, grid, memo) + dfs(r + 1, c, grid, memo);

            memo.TryAdd((r, c), res);
          
            return res;


        }

      
    }
}
