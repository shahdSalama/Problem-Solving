using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class SumPairs
{

    /*
     * Complete the 'divisibleSumPairs' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. INTEGER k
     *  3. INTEGER_ARRAY ar
     */

    public static int divisibleSumPairs(int n, int k, List<int> ar)
    {
        int[] remainders = new int[k];

        for (int i = 0; i < n; i++)
        {
            int remainder = ar[i] % k;
            remainders[remainder]++;
        }
        double pairCount = (double)(remainders[0] * (remainders[0] - 1)) / 2;
        double remaindersHalf = (double)k / 2;

        for (int i = 1; i <= remaindersHalf; i++)
        {
            int numberOfRemaindersInIndex = remainders[i];
            if ((k - i) == remaindersHalf && k % 2 == 0)
            {
                pairCount += (double)(remainders[i] * (remainders[i] - 1)) / 2;
            }
            else
            {
                int numberOfComplementaryRemainders = remainders[k - i];
                int pairs = numberOfComplementaryRemainders * numberOfRemaindersInIndex;
                pairCount += pairs;
            }

        }
        return Convert.ToInt32(pairCount);
    }
}

class Solution12
{
    //public static void Main(string[] args)
    //{


    //    string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

    //    int n = Convert.ToInt32(firstMultipleInput[0]);

    //    int k = Convert.ToInt32(firstMultipleInput[1]);

    //    List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();

    //    int result = SumPairs.divisibleSumPairs(n, k, ar);

    //}
}
