using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank.ExamsandMocks
{
    class Microsoft
    {
        public static void Main()
        {
            minCost("aaabbbabbbb", new int[] { 5, 3, 10, 7, 5, 3, 5, 5, 4, 8, 1 });
        }


        public static int minCost(String s, int[] cost)
        {
            int n = s.Length, gsum = 0, gmax = 0, ans = 0;
            for (int i = 0; i < n; i++)
            {
                if (i > 0 && s[i] != s[i - 1])
                {
                    ans += gsum - gmax;
                    gsum = 0;
                    gmax = 0;
                }
                gsum += cost[i];
                gmax = Math.Max(gmax, cost[i]);
            }

            ans += gsum - gmax;
            return ans;
        }

        public static int CompanyExpenses(int[] A)
        {
            int count = 0;

            int balance = 0;


            int prev = 0;

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] < 0 && (A[i] < prev || prev == 0 ))
                {
                  
                    prev = A[i];
                }
                balance += A[i];

                if (balance < 0)
                {
                    count++;
                   
                    balance -= prev;

                   A =  moveNegativeStartIToEndOFArray(A, i);
                   i--;
                }
            }
            return count;
        }

        private static int[] moveNegativeStartIToEndOFArray(int[] a, int i)
        {
            var list = a.ToList();
            var valueInIndex = list[i];

            list.Add(valueInIndex);

            list.RemoveAt(i);

            return list.ToArray();

        }

      
    }
}
