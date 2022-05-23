using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.HardChallenges
{
    class Calculator
    {
        public static int Calculate(string s)
        {
            int sum = 0;
            int sign = 1;
            var stack = new Stack<int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsDigit(s[i]))
                {
                    int num = 0;
                    while (i < s.Length && char.IsDigit(s[i]))
                    {
                        num = num * 10;
                        var t =  int.Parse(s[i].ToString());
                        num += t;
                        i++;
                    }
                    sum += num * sign;
                    i--;
                }
                else if (s[i] == '+')
                {
                    sign = 1;
                }
                else if (s[i] == '-')
                {
                    sign = -1;
                }
                else if (s[i] == '(')
                {
                    stack.Push(sum);
                    stack.Push(sign);
                    sum = 0;
                    sign = 1;
                }
                else if (s[i] == ')')
                {
                    // sign before paran
                    sum = sum * stack.Pop();
                    // calculated sum before paran
                    sum = sum + stack.Pop();
                }

            }
            return sum;
        }
      
    }
}
