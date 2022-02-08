using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Recursion
{
   public class StringReverse
   {
        public static string ReverseString(string input)
        {
            if (input == "")
                return "";
       
            return ReverseString(input.Substring(1)) + input[0];
        
        }
   }
}