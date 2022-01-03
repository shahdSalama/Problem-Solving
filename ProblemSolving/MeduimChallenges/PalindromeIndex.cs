using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank.MeduimChallenges
{
    class PalindromeIndex
    {


        public static bool isPalindrome(string s)
        {
            var rev = s.Reverse();
            string reverse = string.Join("", rev);
            return s == reverse;

        }

        public static int palindromeIndex(string s)
        {
            int i, j;

            for (i = 0, j = s.Length - 1; i < s.Length; i++, j--)
            {
                if (s[i] != s[j])
                    break;

            }
            if (i > j) return -1;

            string withoutI = s.Remove(i,1);

            string withoutJ = s.Remove(j,1);

            if (isPalindrome(withoutI)) return i;
            if (isPalindrome(withoutJ)) return j;
            return -1;
        }

        //public static void Main(string[] args)
        //{
        //    //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        //    int q = Convert.ToInt32(Console.ReadLine().Trim());

        //    for (int qItr = 0; qItr < q; qItr++)
        //    {
        //        string s = Console.ReadLine();

        //        int result = palindromeIndex(s);

              
        //    }

            
        }
    }

