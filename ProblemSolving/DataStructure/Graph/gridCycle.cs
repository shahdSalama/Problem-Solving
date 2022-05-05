using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.DataStructure.Graph
{
    class gridCycle
    {
        //At each point (i, j) in grid, do following:

        //Start DFS from (i, j).
        //Don't visit the last visited point as stated in question.
        //Only visit a point if it has same character as starting position
        //If you still reach a visited point again, there is a cycle.

       
            public  static bool ContainsCycle(char[][] grid)
            {
                var visited = new HashSet<(int, int)>();
                for (int i = 0; i < grid.Length; i++)
                {
                    for (int j = 0; j < grid[0].Length; j++)
                    {
                        if (visited.Contains((i, j))) continue;
                        if (explore(i, j, grid, visited)) 
                        return true;

                    }

                }
                return false;
            }
            static bool explore(int r, int c, char[][] grid, HashSet<(int, int)> visited)
            {
                char currCh = grid[r][c];
                var s = new Stack<(int, int, int, int)>();

                s.Push((r, c, -1, -1));
                while (s.Count != 0)
                {
                    (int currR, int currC, int prevR, int prevC) = s.Pop();

                    var nei = new List<(int, int)>();

                    if (currR + 1 < grid.Length && grid[currR + 1][currC] == currCh && (currR + 1 != prevR || currC != prevC)) nei.Add((currR + 1, currC));
                    if (currR - 1 >= 0 && grid[currR - 1][currC] == currCh && (currR - 1 != prevR || currC != prevC)) nei.Add((currR - 1, currC));

                    if (currC + 1 < grid[0].Length && grid[currR][currC + 1] == currCh && (currR != prevR || currC + 1 != prevC)) nei.Add((currR, currC + 1));
                    if (currC - 1 >= 0 && grid[currR][currC - 1] == currCh && (currR != prevR || currC - 1 != prevC)) nei.Add((currR, currC - 1));

                    foreach (var n in nei)
                    {
                        (int nR, int nC) = n;
                        if (visited.Contains((nR, nC))) return true;
                        visited.Add((nR, nC));
                        s.Push((nR, nC, currR, currC));
                    }
                }
                return false;
            }
        /*[['a','b','b']
        ,['b','z','b'],
         ['b','b','a']]*/
       
    }
    }
