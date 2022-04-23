using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.DataStructure
{
    class spiral_matrix
    {
        public class Solution
        {
            public IList<int> SpiralOrder(int[][] grid)
            {
                // dfs
                var res = new List<int>();

                var visited = new HashSet<(int, int)>();
                var s = new Stack<(int, int, bool)>();
                s.Push((0, 0, false));

                while (s.Count != 0)
                {
                    var currCell = s.Pop();
                    (int currR, int currC, bool isup) = currCell;
                    if (visited.Contains((currR, currC))) continue;
                    visited.Add((currR, currC));
                   
                    res.Add(grid[currR][currC]);

                    if (isup)
                    {
                        // check left  c-1
                        if (currC - 1 >= 0) s.Push((currR, currC - 1, false));
                        // check bottom r+1
                        if (currR + 1 < grid.Length) s.Push((currR + 1, currC, false));
                        // check right c+1
                        if (currC + 1 < grid[0].Length) s.Push((currR, currC + 1, false));
                        // check up  r-1
                        if (currR - 1 >= 0) s.Push((currR - 1, currC, true));


                    }
                    else
                    {
                        // check up  r-1
                        if (currR - 1 >= 0) s.Push((currR - 1, currC, true));
                        // check left  c-1
                        if (currC - 1 >= 0) s.Push((currR, currC - 1, false));
                        // check bottom r+1
                        if (currR + 1 < grid.Length) s.Push((currR + 1, currC, false));
                        // check right c+1
                        if (currC + 1 < grid[0].Length) s.Push((currR, currC + 1, false));
                    }
                }
                return res;




            }
        }
    }
}
