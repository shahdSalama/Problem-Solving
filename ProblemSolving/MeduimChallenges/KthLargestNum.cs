
using HackerRank.DataStructure;
using System.Collections.Generic;


namespace HackerRank.MeduimChallenges
{
    class KthLargestNum
    {
        int kth;
        MinHeap q;


        public KthLargestNum(int k, int[] nums)
        {
            kth = k;
            q = new MinHeap();
            foreach (var num in nums)
            {
                Add(num);
            }
        
        }
        public int Add(int num)
        {
            if (q.size < kth)
                q.addElement(num);
            else if (num > q.peak())
            {
                q.poll();
                q.addElement(num);
            
            }
            return q.peak();
        }

    }
}
