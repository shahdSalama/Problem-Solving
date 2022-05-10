using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.DataStructure.Graph
{
    class inethretwo
    {
        public static bool Find132pattern(int[] nums)
        {
            // termination conditon we have a list of 3 elements that satisfies the 132 pattern

            // if you have one element you may add any element that 
            // nex element > current element +1
            // next element should not be the last element at the list

            //or you may start a new list

            // if you have toq elements you may add anoter element from the coming indecies that is less than last element and bigger than 1st element
            //                       index, 1st, 2ns, 3rd
            var visited = new HashSet<(int, int, int, int)>();
            var s = new Stack<(int, int, int, int)>();
            s.Push((0, nums[0], int.MinValue, int.MinValue));

            while (s.Count != 0)
            {
                (int currI, int one, int three, int two) = s.Pop();
                if (visited.Contains((currI, one, three, two))) continue;
                if (currI == nums.Length - 1) continue;
                if (two != int.MinValue && three != int.MinValue) return true;
                visited.Add((currI, one, three, two));

                // i only have one element
                if (two == int.MinValue && three == int.MinValue)
                {
                    // i can take any bigger number suc that new number > currnumber +1
                    // i may check nums.Length -2
                    for (int i = currI + 1; i < nums.Length - 1; i++)
                    {
                        if (nums[i] > one + 1)// index of second element  (three)
                            s.Push((i, one, nums[i], two));

                    }

                    s.Push((currI + 1, nums[currI + 1], three, two));
                }

                else if (two == int.MinValue)
                {
                    for (int i = currI + 1; i < nums.Length; i++)
                    {
                        if (nums[i] > one && nums[i] < three)// index of third element  (two)
                            s.Push((i, one, three, nums[i]));

                    }

                }


            }
            return false;


        }
      
    }
}
