using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Recursion
{
    class binarySearch
    {
        public static int bs(int[] arr, int x, int left, int right)
        {
            if (left > right) return -1;

            int mid = (right + left )/ 2;

            if (x == arr[mid]) return mid;


            if (x > arr[mid])

                return bs(arr, x, mid +1, right);

            else
                return bs(arr, x, left, mid  -1);
            

        }
    }
}
