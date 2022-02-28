using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Dynamic_Programming
{
    class HowSumSolution
    {

        public static List<int> HowSum(int target, int[] nums, Dictionary<int, List<int>> memo = null)
        {
            if (memo == null) memo = new Dictionary<int, List<int>>();
            
            if (memo.TryGetValue(target, out List<int> val)) return val;
            
            if (target == 0) return new List<int>();

            if (target < 0) return null;

            foreach (var num in nums)
            {
                int rem = target - num;
                var res = HowSum(rem, nums);
                if (res != null) res.Add(num);
                memo.TryAdd(target, res);
                return res;
            }
            memo.TryAdd(target, null);
            return null;
        }
        //public static void Main(String[] args)
        //{
        //    //  var res5 = HowSum(3, new int[] { 2, 0, 5 });
        //    var res2 = HowSum(8, new int[] { 2, 3, 5 });

        //    // time n*m
        //    // space : target = n

        //}

    }
}
