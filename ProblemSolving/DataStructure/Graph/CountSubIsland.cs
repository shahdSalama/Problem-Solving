using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.DataStructure.Graph
{
    class CountSubIslandSol
    {

        public static int CountSubIslands(int[][] grid1, int[][] grid2)
        {
            int counter = 0;
            // get connected comps in grid1
            var connectedCompsGrid1 = GetConnectedComps(grid1);
            // get connected comps in grid2
            var connectedCompsGrid2 = GetConnectedComps(grid1);

            // for each connected comp in grid 2 
            foreach (var comp in connectedCompsGrid2)
            {
                if (contains(connectedCompsGrid1, comp))
                    counter++;
            }
            return counter;
        }

        public static List<List<(int, int)>> GetConnectedComps(int[][] grid)
        {
            var visited = new HashSet<(int, int)>();
            var components = new List<List<(int, int)>>();

            for (int r = 0; r < grid.Length; r++)
            {
                for (int c = 0; c < grid[0].Length; c++)
                {
                    if (grid[r][c] == 1 && !visited.Contains((r, c)))
                    {
                        List<(int, int)> component = explore(grid, r, c, visited);
                        components.Add(component);
                    }
                }
            }
            return components;
        }
        public static List<(int, int)> explore(int[][] grid, int r, int c, HashSet<(int, int)> visited)
        {
            List<(int, int)> component = new List<(int, int)>();

            var s = new Stack<(int, int)>();

            s.Push((r, c));
            visited.Add((r, c));
            component.Add((r, c));

            while (s.Count != 0)
            {
                (int currR, int currC) = s.Pop();

                foreach (var n in GetN(grid, currR, currC))
                {
                    (int nR, int nC) = n;

                    if (grid[nR][nC] != 1) continue;
                    if (visited.Contains((nR, nC))) continue;

                    visited.Add((nR, nC));
                    s.Push((nR, nC));
                    component.Add((nR, nC));
                }
            }

            return component;
        }

        public static List<(int, int)> GetN(int[][] grid, int r, int c)
        {
            var res = new List<(int, int)>();
            if (r - 1 >= 0) res.Add((r - 1, c));
            if (r + 1 < grid.Length) res.Add((r + 1, c));

            if (c - 1 >= 0) res.Add((r, c - 1));
            if (c + 1 < grid[0].Length) res.Add((r, c + 1));

            return res;
        }

        public static bool contains(List<List<(int, int)>> connectedCompsGrid1, List<(int, int)> comp)
        {

            foreach (List<(int, int)> comp1 in connectedCompsGrid1)
            {
                bool success = comp.All(value => comp1.Contains(value));
                if (success) return success;
            }
            return false;

        }
        // [[1,1,1,0,0],[0,1,1,1,1],[0,0,0,0,0],[1,0,0,0,0],[1,1,0,1,1]]
        // [[1,1,1,0,0],[0,0,1,1,1],[0,1,0,0,0],[1,0,1,1,0],[0,1,0,1,0]]
    } 
    }
