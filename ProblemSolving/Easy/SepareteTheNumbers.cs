using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Easy
{
    class SepareteTheNumbers
    {
        public static bool IsBeautiful(int i, string s)
        {
            string number = s.Substring(0, i);

            long numberInt = Convert.ToInt64(number);

            string beautiful = number;

            for (int j = 1; j < s.Length / i; j++)
            {

                long nextnumber = numberInt + 1;
                numberInt++;
                beautiful += nextnumber.ToString();

                if (beautiful.Length == s.Length || beautiful.Length > s.Length) break;
            }
            //if (i == 1) Console.WriteLine(beautiful);
            return beautiful == s;
        }


        public static void separateNumbers(string s)
        {
            int mid = s.Length / 2;

            for (int i = 1; i <= mid; i++)
            {
                bool isBeautiful = IsBeautiful(i, s);
                if (isBeautiful)
                {
                    Console.WriteLine("YES " + s.Substring(0, i));
                    return;
                }
            }
            Console.WriteLine("NO");

        }


        public static void Main(string[] args)
        {
            int q = Convert.ToInt32(Console.ReadLine().Trim());

            for (int qItr = 0; qItr < q; qItr++)
            {
                string s = Console.ReadLine();

                SepareteTheNumbers.separateNumbers(s);
            }
        }
    }
}
