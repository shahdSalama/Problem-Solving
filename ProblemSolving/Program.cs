using HackerRank.Recursion;
using System;
using System.Collections.Generic;
using System.Linq;
using static Solution;

namespace HackerRank
{
    class Program
    {
        static void Main(string[] args)
        {

            var reversed = StringReverse.ReverseString("mmm");
            
            Console.WriteLine(reversed);

            reversed = StringReverse.ReverseString("lol");

            Console.WriteLine(reversed);

            reversed = StringReverse.ReverseString("lool");

            Console.WriteLine(reversed);

            reversed = StringReverse.ReverseString("abs");

            Console.WriteLine(reversed);

            reversed = StringReverse.ReverseString("abms");

            Console.WriteLine(reversed);

        }
    }
}
