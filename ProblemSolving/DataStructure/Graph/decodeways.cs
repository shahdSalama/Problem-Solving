using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.DataStructure.Graph
{
    class decodeways
    {
        public static int NumDecodings(string input)
        {

            int counter = 0;
            if (input[0] == '0') return 0;
            if (input.Length == 1) return 1;
            var v = new HashSet<string>();
            var s = new Stack<(string, int)>();
            s.Push((input.Substring(0, 1), 0));
            s.Push((input.Substring(0, 2), 0));
            v.Add(input.Substring(0, 1));
            v.Add(input.Substring(0, 2));

            while (s.Count != 0)
            {
                (string currString, int currIndex) = s.Pop();
                if (currString[0] == '0') continue;

                // if the curr string > 26
                if (Convert.ToInt32(currString) > 26)
                    continue;
                // goal 
                if (currIndex + currString.Length == input.Length)
                {
                    counter++;
                    continue;
                }
                // out of bounds
                if (currIndex > input.Length - 1)
                    continue;
                v.Add(currString);

                string nextString = "";
                string nextString2 = "";
                var currLength = currString.Length; //1
                if (currIndex + currLength + 1 <= input.Length)
                {
                    nextString = input.Substring(currIndex + currLength, 1);

                }

                if (currIndex + currLength + 2 <= input.Length)
                {
                    nextString2 = input.Substring(currIndex + currLength, 2);
                }

                if (v.Contains(nextString) && v.Contains(nextString2))
                {
                    counter++;
                    continue;
                }
                if (nextString2 != "")
                    s.Push((nextString2, currIndex + currLength));
                if (nextString != "")
                    s.Push((nextString, currIndex + currLength));
            }
            return counter;
        }
     
    }
}
