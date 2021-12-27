using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Easy
{
    class ModifiedFib
    {
        public static long fibonacciModified(long A, long B, int N)
        {
            

            long F = 0;
            for (int i = 2; i < N; i++)
            {
                F = A + B * B;
                A = B;
                B = F;
            }
            return F;
        }
    
        public static void Main(string[] args)
        {
            fibonacciModified(0, 1, 10);

        }


    }
    }
