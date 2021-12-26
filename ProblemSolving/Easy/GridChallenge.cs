using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank.Easy
{
    class GridChallenge
    {
        public static string gridChallenge(List<string> grid)
        {
            for (int i = 0; i < grid.Count; i++)
            {
                var s = grid[i];
                var charList = s.ToCharArray().ToList();
                charList.Sort();
                grid[i] = string.Join("", charList);
            }

            bool sorted = true;
            var stringLenngth = grid[0].Count();
            for (int i = 0; i < stringLenngth; i++)
            {
                var vertical = new List<char>();
                for (int j = 0; j < grid.Count; j++)
                {
                    vertical.Add(grid[j][i]);
                    if (j >= 1)
                    {
                        if (vertical[j] < vertical[j - 1])
                            sorted = false;
                    }
                }
            }
            return sorted ? "YES" : "NO";
        }
        public static void Main(string[] args)
        {
           
            int t = Convert.ToInt32(Console.ReadLine().Trim());

            for (int tItr = 0; tItr < t; tItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine().Trim());

                List<string> grid = new List<string>();

                for (int i = 0; i < n; i++)
                {
                    string gridItem = Console.ReadLine();
                    grid.Add(gridItem);
                }

                string result = gridChallenge(grid);

              
            }

           
        }
    }
}
