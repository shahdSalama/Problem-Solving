using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Dynamic_Programming
{
    class snakesAndladders
    {
        public static int quickestWayUp(List<List<int>> ladders, List<List<int>> snakes)
        {
            int fewestRolls = int.MaxValue;
            var visited = new int[100];
            //                 cell, rolls
            var q = new Queue<(int, int)>();

            q.Enqueue((1, 0));

            while (q.Count != 0)
            {
                (int currCell, int currRolls) = q.Dequeue();

                // goal
                if (currCell >= 100)
                {
                    fewestRolls = Math.Min(fewestRolls, currRolls);
                    continue;
                }

                // been here with better rolls
                if (visited[currCell] != 0 && visited[currCell] < currRolls) continue;

               

              

                visited[currCell] = currRolls;

                foreach (var n in GetNei(currCell, ladders, snakes))
                {
                    q.Enqueue((n, currRolls + 1));

                }
            }
            return fewestRolls == int.MaxValue ? -1 : fewestRolls;
        }
        private static List<int> GetNei(int currCell, List<List<int>> ladders, List<List<int>> snakes)
        {
            var res = new List<int>();
            for (int i = 1; i < 7; i++)
            {
                int tempCell = currCell + i;

                var ladder = ladders.FirstOrDefault(x => x[0] == tempCell);

                if (ladder != null) tempCell = ladder[1];

                var snake = snakes.FirstOrDefault(x => x[0] == tempCell);

                if (snake != null) tempCell = snake[1];
                res.Add(tempCell);
            }
            return res;

        }
        
    }
}
