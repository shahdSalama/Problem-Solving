using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace HackerRank.Easy
{
    class ModifiedFib
    {
       
            public static BigInteger fibonacciModified(BigInteger t1, BigInteger t2, BigInteger n)
            {
            BigInteger t3 = 0;
                while (n != 2)
                {
                    t3 = t1 + t2 * t2;
                    t1 = t2;
                    t2 = t3;
                    n--;
                }
                return t3;
            }

            //public static void Main(string[] args)
            //{
            //    fibonacciModified(0, 1, 10);

            //}


        }
    }
