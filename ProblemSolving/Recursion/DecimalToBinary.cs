using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Recursion
{
    class DecimalToBinary
    {
        public static string DecimalToBinary2(int n, string result)
        {
            if (n == 0) return result;

            int remainder = n % 2;

            int div = n / 2;

            result = remainder + result;

            return DecimalToBinary2(div, result);


        }

    }
}
