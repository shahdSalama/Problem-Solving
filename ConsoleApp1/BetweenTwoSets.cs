
using System.Collections.Generic;
using System.Linq;

class BetweenTwoSets
{

    /*
     * Complete the 'getTotalX' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY a
     *  2. INTEGER_ARRAY b
     */


    private static bool IsFactor(int x, int y)
    {
        return y % x == 0;
    }

    public static int getTotalX(List<int> a, List<int> b)
    {
        int count = 0;
        for (int i = a[^1]; i <= b[0]; i++)
        {
            if (a.All(x => IsFactor(x, i) && b.All(y => IsFactor(i, y))))
                count++;
        }
        return count;
    }

}

