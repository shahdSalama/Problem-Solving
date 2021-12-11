using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank.Easy
{
    class PermutingTwoArrays
    {
        public static string twoArrays(int k, List<int> A, List<int> B)
        {
            A.Sort();
            B.Sort();

            B.Reverse();

            for (int i = 0; i < A.Count; i++)
            {
                if (A[i] + B[i] < k)
                    return "NO";
            }
            return "YES";

        }


    }
   
        
    }

