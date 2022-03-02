using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Dynamic_Programming
{
    class gridTraveller
    {                
        // start at top left of grid and end at bottom right
        // number of paths you can take.. you only can move down or right
        public static long gridTraveler(int n, int m, Dictionary<(int, int), long> memo = null)
        {
            if (memo == null) memo = new Dictionary<(int, int), long>();

            if (memo.TryGetValue((n, m), out long val)) return val;

            if (n == 0 || m == 0) return 0;

            if (n == 1 || m == 1) return 1;

            long res = gridTraveler(n - 1, m, memo) + gridTraveler(n, m - 1, memo);

            memo.TryAdd((n, m), res);
            memo.TryAdd((m, n), res);

            return res;
        }
        // time :  m*n
        // space  n + m

        //public static void Main(String[] args)
        //{
        //    var res = gridTraveler(18, 18);
        //}
    }
}
