using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Easy
{
    class NumberLineJumps
    {
        public static string kangaroo(int x1, int v1, int x2, int v2)
        {
            if (v1 == v2) return "NO";

            int vdiff = v1 - v2;
            int sdiff = x2 - x1;
            double j = (double)sdiff / vdiff;

            return j >= 0 && j % 1 == 0 ? "YES" : "NO";

        }

    }
}
