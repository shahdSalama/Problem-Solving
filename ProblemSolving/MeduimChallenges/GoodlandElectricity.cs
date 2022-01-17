using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.MeduimChallenges
{
    class GoodlandElectricity
    {
        public static int pylons(int k, List<int> arr)
        {
            int count = 0;
            int start = 0;
            int n = arr.Count;
            int location = start + k - 1;
            while (start < n)
            {
                if (arr[location] == 1)
                {
                    count++;
                    start = location + k;
                    location = start + k - 1;
                    if (location >= n) location = n - 1;

                }
                else
                {
                    location--;
                    if (location < start - k + 1) return -1;
                }
            }
            return count;

        }
    }
}