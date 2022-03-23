using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.DataStructure.Graph
{
    class minmax
    {
        public static int maxMin(int k, List<int> arr)
        {
            arr.Sort();
            k = k - 1;
            int min = int.MaxValue;
            for (int i = 0; i < arr.Count - k; i++)
            {

                min = Math.Min(min, arr[i + k] - arr[i]);
            }
            return min;

        }
      
    }
}
