using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Binary_Search
{
    class MedianOfTwoSortedArrays
    {
        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            // A has the smaller array to run binary search

            var A = nums1;
            var B = nums2;


            if (nums1.Length > nums2.Length)
            {
                A = nums2;
                B = nums1;
            }

            var total = nums1.Length + nums2.Length;

            var half = total / 2;

            int l = 0;
            int r = A.Length - 1;

            while (true)
            {
                if (r < 0) return A[l];
                int aMid =  ( l+r) / 2;     // A mid
                int j = half - aMid - 2;    // index of the number to be taken from B

                int aLeft = int.MinValue;
                int bLeft = int.MinValue;
                int aRight = int.MaxValue;
                int bRight = int.MaxValue;

                // any of the following indecies can be out of bounds

                if (aMid >= 0)
                    aLeft = A[aMid];

                if (aMid + 1 < A.Length)
                    aRight = A[aMid + 1];

                if (j >= 0)
                    bLeft = B[j];

                if (j + 1 < B.Length)
                    bRight = B[j + 1];

                // we found the good half
                if (aLeft <= bRight && bLeft <= aRight)
                {
                    // odd
                    if (total % 2 == 1)
                        return Math.Min(aRight, bRight);
                    else
                        return (Math.Min(aRight, bRight) + Math.Max(aLeft, bLeft)) / 2;

                }
                else if (aLeft > bRight)
                    r = aMid - 1;
                else
                    l = aMid + 1;
            }
        }
       
    }
}
