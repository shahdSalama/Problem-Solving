using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Dynamic_Programming
{
    class matrixSquare
    {

        static public int MaximalSquare(char[][] grid)
        {
            int res = 0;
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    if (grid[i][j] == '1')
                    {
                        var area = explore(i, j, grid);
                        res = Math.Max(res, area);
                    }
                }
            }
            return res;
        }
        static int explore(int r, int c, char[][] grid)
        {
            int area = 0;
            var visited = new HashSet<(int row, int col)>();
            var s = new Stack<(int, int, int)>();

            s.Push((r, c, 1));
            while (s.Count != 0)
            {
                (int currR, int currC, int currArea) = s.Pop();

                if (visited.Contains((currR, currC))) continue;

                area = Math.Max(area, currArea);
                visited.Add((currR, currC));

                if (canTakeDi(r, c, currR, currC, grid))
                {
                   
                    s.Push((currR + 1, currC + 1, (currC - c) *(currR - r)));// do
                }// 

            }
            return area;
        }
        static bool canTakeDi(int r, int c, int currR, int currC, char[][] grid)
        {
            if (!(currR + 1 < grid.Length && currC + 1 < grid[0].Length && grid[currR + 1][currC + 1] == '1')) return false;
            for (int i = r; i < currR + 1; i++)
            {
                if (grid[i][currC + 1] != '1') return false;

            }
            for (int i = c; i < currC + 1; i++)
            {
                if (grid[currR][i + 1] != '1') return false;
            }
            return true;
        }




      

    }
    }
