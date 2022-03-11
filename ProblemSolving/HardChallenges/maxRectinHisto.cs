using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.HardChallenges
{
    class maxRectinHisto
    {
        public static long largestRectangle(List<int> h)
        {
            long maxArea = 0;
            //                index, height
            var s = new Stack<(int, long)>();


            for (int i = 0; i < h.Count; i++)
            {
                int startIdx = i;
                while (s.Count != 0 && s.Peek().Item2 > h[i])
                {
                    (int idx, long height) = s.Pop();
                    long currArea = (i - idx) * height;
                    maxArea = Math.Max(maxArea, currArea);
                    startIdx = idx;

                }
                s.Push((startIdx, h[i]));


            }

            for (int i = 0;  i < s.Count; i++)
            {
                (int idx, long he) = s.ToList()[i];
                maxArea = Math.Max(maxArea, he * (h.Count - idx));

            }
            return maxArea;
        }
        //public static void Main(string[] args)
        //{
        //    largestRectangle(new List<int> { 2, 1, 5, 6, 2, 3 });
        //}
    }
}
