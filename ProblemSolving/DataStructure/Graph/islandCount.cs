
using System.Collections.Generic;

namespace HackerRank.DataStructure.Graph
{
    class islandCount
    {
        public int NumIslands(char[][] grid)
        {
            int count = 0;
            for (int r = 0; r < grid.Length; r++)
            {
                for (int c = 0; c < grid[0].Length; c++)
                {
                    if (grid[r][c] == '1')
                        if (explore(grid, r, c)) count++;

                }
            }
            return count;
        }
        public bool explore(char[][] grid, int r, int c)
        {
            if (!(r >= 0 && r < grid.Length && c >= 0 && c < grid[0].Length)) return false;

            if (grid[r][c] != '1') return false;

            grid[r][c] = '#';

            explore(grid, r + 1, c);
            explore(grid, r - 1, c);
            explore(grid, r, c + 1);
            explore(grid, r, c - 1);

            return true;
        }
    }
}
