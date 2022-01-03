using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Easy
{
    class CounterGame
    {

        public static long next(long n)
        {

            long final = 0;
            for (double i = 1; i < n; i++)
            {
                var res = (long)Math.Pow(i, 2);
                if (res < n) final = res;
                if (res > n) break;
            }
            return final;

        }

        public static string counterGame(long n)
        {

            int count = 0;
            while (n > 1)
            {
                if (Math.Log(n, 2) == (int)Math.Log(n, 2))
                {
                    n = n / 2;
                    count++;
                }


                else
                {
                    long x = (int)Math.Log(n, 2);
                    long p = Convert.ToInt32(Math.Pow(2, x));
                    n -= p;
                    count++;
                }
            }

            if (count % 2 == 0)
                return "Richard";
            else
                return "Louise";
        }



        //    public static void Main(string[] args)
        //{
         

        //    int t = Convert.ToInt32(Console.ReadLine().Trim());

        //    for (int tItr = 0; tItr < t; tItr++)
        //    {
        //        long n = Convert.ToInt64(Console.ReadLine().Trim());

        //        string result = counterGame(n);

              
        //    }

        
        }
    }


