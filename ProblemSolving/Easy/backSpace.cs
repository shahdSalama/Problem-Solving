using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Easy
{
    class backSpace
    {
        public static bool BackspaceCompare(string s, string t)
        {
 
            var s1 = HandleString(s);
      
            var s2 = HandleString(t);
            return s1 == s2;
        }
        static string HandleString(string s)
        {
            var stack = new Stack<char>(s.ToList());
            var res = "";

            while (stack.Count != 0)
            {
                int count = 0;
                while (stack.Count != 0 && stack.Peek() == '#')
                {
                    stack.Pop();
                    count++;
                }

                for (int i = 0; i < count; i++)
                {
                    if (stack.Count == 0) return res;
                    char x = stack.Pop();
                    if (x == '#') count+=2;
 
                }
                if (stack.Count != 0 && stack.Peek() != '#')
                {
                    var currChar = stack.Pop();
                    res += currChar;
                }
            }
            return res;
        }
        /*"bxj##tw"
        "bxo#j##tw"*/
       
    }
}
