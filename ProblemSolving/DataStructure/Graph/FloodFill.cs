using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.DataStructure.Graph
{
    class FloodFillsol
    {

        public int[][] FloodFill(int[][] image, int sr, int sc, int newColor)
        {
            //                   row , col
            var s = new Stack<(int, int)>();

            var visited = new HashSet<(int, int)>();

            s.Push((sr, sc));

            visited.Add((sr, sc));
            int sourceVal = image[sr][sc];

            image[sr][sc] = newColor;


            while (s.Count != 0)
            {
                (int currRow, int currCol) = s.Pop();

                foreach (var nei in GetNei(image, currRow, currCol, sourceVal))
                {
                    if (visited.Contains(nei)) continue;

                    (int neiRow, int neiCol) = nei;
                    image[neiRow][neiCol] = newColor;
                    visited.Add((neiRow, neiCol));
                    s.Push((neiRow, neiCol));
                }

            }

            return image;
        }
        public List<(int, int)> GetNei(int[][] image, int currRow, int currCol, int sourceVal)
        {
            var res = new List<(int, int)>();

            int rowUp = currRow - 1;
            if (rowUp >= 0 && image[rowUp][currCol] == sourceVal) res.Add((rowUp, currCol));

            int rowDown = currRow + 1;
            if (rowDown < image.Length && image[rowDown][currCol] == sourceVal) res.Add((rowDown, currCol));

            int colUp = currCol - 1;
            if (colUp >= 0 && image[currRow][colUp] == sourceVal) res.Add((currRow, colUp));

            int colDown = currCol + 1;
            if (colDown < image[0].Length && image[currRow][colDown] == sourceVal) res.Add((currRow, colDown));
            return res;
        }

        //public static void Main(string[] args)
        //{
        //    var res2 = FloodFill(new int[][] { new int[] { 1,1,1}, new int[] { 1,1, 0 }, new int[] { 1, 0, 1 } },1 , 1, 2);
        //}
    }
}
