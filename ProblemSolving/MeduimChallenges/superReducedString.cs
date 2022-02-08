using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.MeduimChallenges
{
    class superReducedStringsol
    {
        public static (string reduced, int nextStart, bool con) removeAdjacents(string s, int start) //abccddd, 0
        {//  //abddd

            // // //abd, 1
            for (; start < s.Length - 1; start++) // start initilally = 0 , 0, 1
            {
                if (s[start] == s[start + 1])
                {
                    s.Remove(start, 2); // abccddd  
                    return (s, start - 1, true); //abddd, 1    //abd,1


                }

            }
            return (s, start, false);
        }

        public static string superReducedString(string s)
        {
            int i = 0;
            while (i < s.Length) // s.length = 9 
            {
                var tuple = removeAdjacents(s, i);
                s = tuple.reduced;  //abccddd  // //abddd  // //abd
                i = tuple.nextStart; //  1 // 1
                if (i < 0) i = 0; // i = 0
                if (tuple.con == false) return s;
            }
            return s;
        }
        //public static void Main(string[] args)
        //{

        //    string s = Console.ReadLine();

        //    string result = superReducedString(s);

          
        //}

    }
}
