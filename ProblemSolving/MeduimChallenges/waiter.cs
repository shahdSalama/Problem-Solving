using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank.MeduimChallenges
{
    class waiter
    {
        public static List<int> GeneratePrimesNaive(int n)
        {
            List<int> primes = new List<int>();
            primes.Add(2);
            int nextPrime = 3;
            while (primes.Count < n)
            {
                int sqrt = (int)Math.Sqrt(nextPrime);
                bool isPrime = true;
                for (int i = 0; (int)primes[i] <= sqrt; i++)
                {
                    if (nextPrime % primes[i] == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    primes.Add(nextPrime);
                }
                nextPrime += 2;
            }
            return primes;
        }

        public static List<int> waiters(List<int> number, int q)
        {
            var primes = GeneratePrimesNaive(q);
            var ans = new List<int>();
            var arr = new Stack<int>();
            var a = new Stack<int>();
            var b = new Stack<int>();


            for (int i = 0; i < number.Count; i++)
            {
                arr.Push(number[i]);
            }


            for (int i = 0; i < q; i++)
            {
                for (int j = 0; j < number.Count; j++)
                {
                    if (arr.Count != 0)
                    {
                        var poped = arr.Pop();
                        bool div = poped % primes[i] == 0;
                        if (div) b.Push(poped);
                        else a.Push(poped);
                    }
                    else break;
                }

                while (b.Count != 0)
                {
                    ans.Add(b.Pop());
                }
                arr = a;
                a = new Stack<int>();

            }

            while (arr.Count != 0)
            {
                ans.Add(arr.Pop());


            }
            return ans;
        }

        //public static void Main(string[] args)
        //{
        //   // TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        //    string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        //    int n = Convert.ToInt32(firstMultipleInput[0]);

        //    int q = Convert.ToInt32(firstMultipleInput[1]);

        //    List<int> number = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(numberTemp => Convert.ToInt32(numberTemp)).ToList();

        //    List<int> result = waiters(number, q);

        //   // textWriter.WriteLine(String.Join("\n", result));

        //  //  textWriter.Flush();
        //  //  textWriter.Close();
        //}
    }
}
