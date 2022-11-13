using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.MeduimChallenges
{
    public class MaxPoint
    {
        public static int MaxScore(int[] arr, int k)
        {
            int n = arr.Length;
            int l = 0;
            int r = k - 1;
            int max = 0;
            int sum = arr.Sum();

            int win = 0;

            for (int i = 0; i < n- k; i++)
            {
                win += arr[i];
            }
            max = sum - win;

            for (int i = 0; i <  k ; i++)
            {

                var nwin = win - arr[i] + arr[i + n - k];
                win = nwin;
                max = Math.Max(sum - win, max);
            }
            return max;
        }
       
    }
}