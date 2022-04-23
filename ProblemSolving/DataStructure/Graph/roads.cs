using System;


namespace HackerRank.DataStructure.Graph
{
    public class Solution
    {

        public static int MaximalNetworkRank(int n, int[][] edges)
        {
            if (edges.Length == 0) return 0;
            int[] count = new int[n];
            bool[,] matrix = new bool[n, n];
            int res = 0;
            for (int i = 0; i < edges.Length; i++)
            {
                count[edges[i][0]]++;
                count[edges[i][1]]++;
                matrix[edges[i][0], edges[i][1]] = true;
                matrix[edges[i][1], edges[i][0]] = true;
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; i < n; j++)
                {
                    int adj = 0;
                    if (matrix[i, j]) adj = 1;

                    res = Math.Max(res, count[i] + count[j] - adj);
                }
            }

            return res;
        }




      
    }
}



