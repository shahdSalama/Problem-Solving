using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.DataStructure.Arrays
{
    class Merge2sortedArray
    {
        //public static void Main(string[] args)
        //{
        //    Merge(new int[] {2, 0}, 1, new int[] { 1 }, 1);

        //}
        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {

            var temp = new int[nums1.Length];
            var p1 = 0;
            var p2 = 0;
            int i = 0;
            // [1,2,3,0,0,0], m = 3, nums2 = [2,5,6], n = 3
            // [1,2,2,3,0,0]
            while (p1 < m && p2 < nums2.Length)
            {
                if (nums1[p1] <= nums2[p2])
                {
                    temp[i] = nums1[p1];
                    i++; //4
                    p1++; //3
                }
                else
                {
                    temp[i] = nums2[p2];
                    p2++;  //1
                    i++;   //3
                }
            }


            while (i < temp.Length && p2 < nums2.Length)
            {
                temp[i] = nums2[p2];
                p2++;  //1
                i++;   //3   
            }
            while (i < temp.Length && p1 <m)
            {
                temp[i] = nums1[p1];
                p1++;  //1
                i++;   //3   
            }
            if (n != 0)
            {
                for (int j = 0; j < nums1.Length; j++)
                {
                    nums1[j] = temp[j];

                }
            }
        }

    }
}
