using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank.ExamsandMocks
{
    class Microsoft
    {
        //public static void Main()
        //{
        //    minCost("aaabbbabbbb", new int[] { 5, 3, 10, 7, 5, 3, 5, 5, 4, 8, 1 });

        //    int res2 = CompanyExpenses(new int[] { -1, -1, 2, 2, -4, -1, 2 });

        //    int res2_2 = CompanyExpenses(new int[] { -1, -2, 3 });

        //    int res_1 = CompanyExpenses(new int[] { -2, 3 });

        //    int res__1 = CompanyExpenses(new int[] { -3, 3 });

        //    int res0 = CompanyExpenses(new int[] { 0, 3 });

        //    int res_0 = CompanyExpenses(new int[] { 1, 3 });

        //    int res2_3 = CompanyExpenses(new int[] { -1, -1, -1, 0, 3 });

        //}



        ///  ca  
        // a -> apple
        // b -> book
        // c -> car, cat, cycle, category
        // result => car
        public static List<string> autoComplete(string word, List<string> db)
        {
            var dictionary = ConstructDcitioray(db);
            var results = new List<string>();
            // try to see if the first letter exists
            var character = word[0]; // c
            int searchWordLength = word.Length; // 2
            if (dictionary.TryGetValue(character, out List<string> values))
            {
                foreach (var cand in values) // car
                {
                    var trimmedCand = cand.Substring(0, searchWordLength); // 
                    if (word == trimmedCand)
                        results.Add(cand);
                }
            }
            return results;
        }
        //   apple, book, car, cat, cycle, category


        public static Dictionary<char, List<string>> ConstructDcitioray(List<string> db)
        {
            var dic = new Dictionary<char, List<string>>();
            foreach (var word in db) // apple
            {
                if (!dic.TryGetValue(word[0], out List<string> _))
                {
                    dic.Add(word[0], new List<string> { word });
                }
                else
                {
                    dic[word[0]].Add(word);
                }
            }
            return dic;
        }


        public static int minCost(String s, int[] cost)
        {
            int n = s.Length;
            int gsum = 0;
            int gmax = 0;
            int ans = 0;
            for (int i = 0; i < n; i++)
            {
                if (i > 0 && s[i] != s[i - 1])
                {
                    ans += gsum - gmax;
                    gsum = 0;
                    gmax = 0;
                }
                gsum += cost[i];
                gmax = Math.Max(gmax, cost[i]);
            }

            ans += gsum - gmax;
            return ans;
        }

        public static int CompanyExpenses(int[] A)
        {
            int count = 0;

            int balance = 0;

            int prev = 0;

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] < 0 && (A[i] < prev || prev == 0))
                {

                    prev = A[i];
                }
                balance += A[i];

                if (balance < 0)
                {
                    count++;

                    balance -= prev;

                    A = moveNegativeStartIToEndOFArray(A, i);
                    i--;
                }
            }
            return count;
        }

        private static int[] moveNegativeStartIToEndOFArray(int[] a, int i)
        {
            var list = a.ToList();
            var valueInIndex = list[i];

            list.Add(valueInIndex);

            list.RemoveAt(i);

            return list.ToArray();

        }

    }
    }

}