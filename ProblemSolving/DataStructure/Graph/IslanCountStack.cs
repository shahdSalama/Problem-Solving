using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.DataStructure.Graph
{
    class IslanCountStack
    {
        // number of connected components on a grid
        public static int NumIslands(string[][] grid)
        {
            int rowcount = grid.Length;
            int colcount = grid[0].Length;
            int count = 0;
            var visited = new HashSet<(int row, int col)>();
            for (int r = 0; r < rowcount; r++)
            {
                for (int c = 0; c < colcount; c++)
                {
                    if (explore(grid, r, c, visited))
                        count++;
                }

            }
            return count;
        }
        public static bool explore(string[][] grid, int r, int c, HashSet<(int, int)> visited)
        {
            if (grid[r][c] != "1") return false;

            if (visited.Contains((r, c))) return false;

            var stack = new Stack<(int rowS, int ColS)>();
            
            visited.Add((r, c));
            stack.Push((r, c));
           
            while (stack.Count != 0)
            {
                (int currRow, int currCol) = stack.Pop();
                // GetNeigh returns the valid neighbors, all neighbors returned = 1 and within grid boundaries
                foreach (var neigh in GetNeigh(grid, currRow, currCol))
                {
                    if (visited.Contains(neigh))  continue;
                    visited.Add(neigh);
                    stack.Push(neigh);
                }
            }
            return true;
        }
        public static List<(int rowN, int colN)> GetNeigh(string[][] grid, int currRow, int currCol)
        {
            var res = new List<(int rowN, int colN)>();
            if (currRow - 1 >= 0 && grid[currRow - 1][currCol] == "1") res.Add((currRow - 1, currCol));
            if (currRow + 1 < grid.Length && grid[currRow + 1][currCol] == "1") res.Add((currRow + 1, currCol));
            if (currCol - 1 >= 0 && grid[currRow][currCol-1] == "1") res.Add((currRow, currCol - 1));
            if (currCol + 1 < grid[0].Length && grid[currRow][currCol+1] == "1") res.Add((currRow, currCol + 1));
            
            return res;

        }

        //public static void Main(String[] args)
        //{
        //    string[][] jaggedArray2 = new string[][] {
        //                             new string[]  {"1","1","1","1","0"},
        //                            new string[]  {"1","1","0","1","0"},
        //                            new string[]  {"1","1","0","0","0"},
        //                            new string[]  { "0", "0", "0", "0", "0" }

        //             };
        //    var x = NumIslands(jaggedArray2);
        //}
    }
}
