using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Dynamic_Programming
{
    class LongestCommonSubseq
    {

            public static int LongestCommonSubsequence(string s, string t)
            {
                int res = 0;
                var visited = new HashSet<(int, int)>();
                var stack = new Stack<(int i, int j, int count)>();

                stack.Push((0, 0, 0));

                while (stack.Count != 0)
                {
                    (int currI, int currJ, int currCount) = stack.Pop();
                    // out of bounds
                    if (currI >= s.Length || currJ >= t.Length) continue;
                    // been here with better count
                    if (visited.Contains((currI, currJ))) continue;
                    visited.Add((currI, currJ));
                    res = Math.Max(currCount, res);

                    // options
                    // both indexes are the same char
                    // inc both, int counter

                    if (s[currI] == t[currJ])
                    {
                        stack.Push((currI + 1, currJ + 1, currCount + 1));
                    }


                    // both indexes do not have equal chars
                    // either inc 1sr index or inc second ind
                    else
                    {
                        stack.Push((currI, currJ + 1, currCount));

                        stack.Push((currI + 1, currJ, currCount));

                    }


                }
                return res;

            }
       
    }
}
