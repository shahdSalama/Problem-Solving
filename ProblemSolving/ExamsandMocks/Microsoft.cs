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
       
        }

      
        public int StringDeletionMinCost(String S, int[] C)
        {
            var jagged = new List<List<string>>();
            for (int i = 0; i < S.Length; i++)
            {
                jagged.Add(new List<string> { S[i].ToString(), C[i].ToString() });
            }

            int count = 0;
            for (int i = 0; i < jagged.Count - 1; i++)
            {
                if (jagged[i][0] == jagged[i + 1][0])
                {
                    if (Convert.ToInt32(jagged[i][1]) < Convert.ToInt32(jagged[i + 1][1]))
                    {
                        count += Convert.ToInt32(Convert.ToInt32(jagged[i][1]));

                    }
                    else count += Convert.ToInt32(Convert.ToInt32(jagged[i + 1][1]));

                }
            }
            return count;

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
