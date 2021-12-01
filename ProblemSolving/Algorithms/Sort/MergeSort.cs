using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Algorithms.Sort
{
    public class MergeSort
    {
        public static void Merge(int[] A, int[] B)
        {
            int[] C = new int[A.Length + B.Length];

            int i = 0;
            int j = 0;
            int k = 0;

            while (i <= A.Length && j <= B.Length)
            {
                if (A[i] < B[j])
                {
                    C[k] = A[i];
                    i++; k++;
                }
                else
                {
                    C[k] = B[j];
                    j++; k++;
                }
            }


            for (; i <= A.Length; i++)
            {
                C[k] = A[i]; k++;
            }
            for (; j <= B.Length; j++)
            {
                C[k] = B[j]; k++;
            }
        }

        public static void MergeSort(int [] arr, int l, int h)
        {
            int mid = (l + h) / 2;

            if (l < h)
            {

                MergeSort(arr, l, mid);
                MergeSort(arr, mid + 1, h);
                Merge(arr);
            }
        
        }

    }

}