using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.MeduimChallenges
{
    class doubleArray
    {
        public static int[] FindOriginalArray(int[] arr)
        {

          
            if (arr.Length % 2 != 0) return new int[] { };
            var original = new int[arr.Length / 2];
            int j = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == -1) continue;
                // get index of the double if exists
                int temp = arr[i];
                arr[i] = -1;
                var doubleIndex = Array.IndexOf(arr, temp * 2);
                arr[i] = temp;
                if (doubleIndex == -1) continue;
                else
                {

                    original[j] = arr[i];
                    j++;
                    arr[i] = -1;
                    arr[doubleIndex] = -1;
                }
            }
            if (arr.All(x => x == -1)) return original;
            else return new int[] { };
        }
        static void Main(string[] args)
        {//[]
         // 3

            FindOriginalArray(new int[] {1, 3, 4, 2, 6, 8 });
        }
    }
}
