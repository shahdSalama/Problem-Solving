using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank.MeduimChallenges
{
    class FlippingMatrix
    {
        public static int flippingMatrix(List<List<int>> matrix)
        {
            int n = matrix.Count / 2;
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    List<int> mirrors = new List<int>();
                    int a = matrix[i][j];
                    int b = matrix[2 * n - 1 - i][j];
                    int c = matrix[i][2 * n - 1 - j];
                    int d = matrix[2 * n - 1 - i][2 * n - 1 - j];

                    mirrors.Add(a);
                    mirrors.Add(b);
                    mirrors.Add(c);
                    mirrors.Add(d);

                    sum += mirrors.Max();

                }

            }

            return sum;
        }
    }
}
