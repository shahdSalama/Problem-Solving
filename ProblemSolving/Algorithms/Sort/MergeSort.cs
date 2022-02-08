using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank.Algorithms.Sort
{
    public class MergeSort
    {
        static public void Merge(int[] data, int startSub, int midSub, int endSub)
        {
            int[] temp = new int[endSub - startSub + 1];
            int i = startSub; int j = midSub + 1;
            int k = 0;
            while (i <= startSub && j <= endSub)
            {
                if (data[i] <= data[j])
                {
                    temp[k++] = data[i++];
                }
                else
                {
                    temp[k++] = data[j++];
                }
            }
            while (i <= midSub)
            {

                temp[k++] = data[i++];
            }
            while (j <= endSub)
            {

                temp[k++] = data[j++];
            }

            for (i = startSub; i <= endSub; i++)
            {
                data[i] = temp[i - startSub];
            }



        }

        /// <summary>
        /// the function manipulates the array
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        static public void SortMerge(int[] numbers, int start, int end)
        {
           // stopping condition
            if (end > start)
            {
                int mid = (end + start) / 2;
                SortMerge(numbers, start, mid); // first half till mid
                SortMerge(numbers, (mid + 1), end); // seconf half from mid + 1
                Merge(numbers, start, (mid + 1), end); // merge both halves
            }
        }
        //public static void Main(string[] args)
        //{
        //    var x = new int[] { 3, 6, 1, 5, 4, 2, };
        //    SortMerge(x, 0, 5);
        //}

    }

}