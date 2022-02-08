using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Recursion
{
    class Palindrome
    {
        public static string RemoveNonAlphaNumericChars(string s)
        {
            string result = "";

            for (int i = 0; i < s.Length; i++)
            {
                if (Char.IsLetter(s[i]) || Char.IsNumber(s[i]))
                    result += s[i];
            }
            return result;
        }

        public static bool IsPalindrome(string s)
        {

            s = RemoveNonAlphaNumericChars(s);

            return isPalindromeRec(0, s.Length - 1, s);
        }
        public static bool isPalindromeRec(int start, int end, string s)
        {
            if (start >= end)
                return true;

            if (Char.ToLower(s[start]) != Char.ToLower(s[end])) return false;


            else return isPalindromeRec(start + 1, end - 1, s);

        }
       // public static void Main(string[] args)
       // {
       //     bool res = IsPalindrome("A man, a plan, a canal: Panama");
       // }
       ////  

    }
}
