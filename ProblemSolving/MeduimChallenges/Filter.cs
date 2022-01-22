using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.MeduimChallenges
{
    class Filter
    {
        public static int solution(int[] a)
        {
            double[] A = copy(a);

            double polutionCount = Sum(A);

            double polutionHalf = polutionCount / 2;

            var filterCount = 0;


            while (polutionCount > polutionHalf)
            {
                A = ApplyFilter(A);

                polutionCount = Sum(A);

                filterCount++;
            }
            return filterCount;

        }
        public static double[] ApplyFilter(double[] a)
        {
            Array.Sort(a);
            Array.Reverse(a);
            a[0] = a[0] / 2;
            return a;
        }


        public static double[] copy(int[] a)
        {
            double[] re = new double[a.Length];

            for (int i = 0; i < a.Length; i++)
            {
                re[i] = a[i];
            }
            return re;
        }

        public static double Sum(double[] a)
        {
            double result = 0;
            for (int i = 0; i < a.Length; i++)
            {
                result += a[i];
            }
            return result;
        }
    }
}
