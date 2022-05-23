using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.MeduimChallenges
{
    class Minimum_Cost_Homecoming_of_a_Robot_in_a_Grid
    {
        public static int MinCost(int[] startPos, int[] homePos, int[] rowCosts, int[] colCosts)
        {
            int r = rowCosts.Length;
            int c = colCosts.Length;


            int sRow = startPos[0];
            int sCol = startPos[1];

            int tRow = homePos[0];
            int tCol = homePos[1];

            var visited = new int[r, c];
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++) visited[i, j] = int.MaxValue;
            }

            visited[sRow, sCol] = 0;
            var q = new Queue<(int, int)>();
            q.Enqueue((sRow, sCol));
            while (q.Count != 0)
            {
                (int currRow, int currCol) = q.Dequeue();
                int currCost = visited[currRow, currCol];

                // up
                if (currRow - 1 <= 0)
                {
                    var neiCost = rowCosts[currRow - 1];
                    var newCost = Math.Max(neiCost, currCost);
                    if (newCost < visited[currRow - 1, currCol])
                    {
                        visited[currRow - 1, currCol] = newCost;
                        q.Enqueue((currRow - 1, currCol));
                    }
                }
                // down
                if (currRow + 1 < r)
                {
                    var neiCost = rowCosts[currRow + 1];
                    var newCost = Math.Max(neiCost, currCost);
                    if (newCost < visited[currRow + 1, currCol])
                    {
                        visited[currRow + 1, currCol] = newCost;
                        q.Enqueue((currRow + 1, currCol));
                    }
                }

                // left 
                if (currCol - 1 >= 0)
                {
                    var neiCost = colCosts[currCol - 1];
                    var newCost = Math.Max(neiCost, currCost);
                    if (newCost < visited[currRow, currCol - 1])
                    {
                        visited[currRow, currCol - 1] = newCost;
                        q.Enqueue((currRow, currCol - 1));
                    }
                }

                // right 
                if (currCol + 1 < c)
                {
                    var neiCost = colCosts[currCol + 1];
                    var newCost = Math.Max(neiCost, currCost);
                    if (newCost < visited[currRow, currCol + 1])
                    {
                        visited[currRow, currCol + 1] = newCost;
                        q.Enqueue((currRow, currCol + 1));
                    }
                }



            }
            return visited[tRow, tCol];

        }
       
    }
}
