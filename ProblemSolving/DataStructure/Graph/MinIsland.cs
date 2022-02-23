using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.DataStructure.Graph
{
    class MinIsland
    {
		public int minislandCount(char[][] grid)
		{
			int minisland = Int32.MaxValue;
			for (int r = 0; r < grid.Length; r++)
			{
				for (int c = 0; c < grid[0].Length; c++)
				{
					if (grid[r][c] != '1') continue;
					int islandCount = GetIslandCount(grid, r, c);
					if (islandCount < minisland) minisland = islandCount;

				}

			}
			return minisland;
		}
		public int GetIslandCount(char[][] grid, int r, int c)
		{

			var s = new Stack<(int, int)>();
			s.Push((r, c));
			int islandCount = 1;
			grid[r][c] = '#';
			while (s.Count != 0)
			{
				(int currRow, int currCol) = s.Pop();
				foreach (var nei in GetNei(grid, currRow, currCol))
				{
					(int rown, int coln) = nei;
					if (grid[rown][coln] != '1') continue;
					grid[rown][coln] = '#';
					islandCount++;
					s.Push((rown, coln));
				}
			}
			return islandCount;
		}

		public List<(int, int)> GetNei(char[][] grid, int r, int c)
		{
			var res = new List<(int, int)>();

			if (r - 1 >= 0) res.Add((r - 1, c));
			if (r + 1 < grid.Length) res.Add((r + 1, c));

			if (c - 1 >= 0) res.Add((r, c - 1));
			if (c + 1 < grid[0].Length) res.Add((r, c + 1));

			return res;
		}
	}
}
