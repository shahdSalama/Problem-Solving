using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank.MeduimChallenges
{
    public class item
    {
        public item(int p, bool isp)
        {
            price = p;
            isPeak = isp;
        }
        public int price;
        public bool isPeak;

    }

    public class Stock
    {
        public List<item> itemList = new List<item>();
        public bool anypeak;

    }
    public class StockMax2
    {
        public static long stockmax(List<int> prices)
        {
            // var itemList new List<item>();
            var s = new Stock();
            s.anypeak = false;
            s.itemList.Add(new item(prices[0], false));
            int i;
            for (i = 1; i < prices.Count - 1; i++)
            {
                bool ispeak = prices[i] > prices[i - 1] && prices[i] > prices[i + 1];
                if (ispeak) s.anypeak = true;
                s.itemList.Add(new item(prices[i], ispeak));

            }
            var isFinalpeak = prices[i] > prices[i - 1];
            if (isFinalpeak) s.anypeak = true;
            s.itemList.Add(new item(prices[i], isFinalpeak));

            int items = 0;
            int balance = 0;

            if (s.anypeak == false) return 0;

            for (int j = 0; j < s.itemList.Count; j++)
            {
                if (!s.itemList[j].isPeak)
                balance -= s.itemList[j].price;
                items++;

                if (s.itemList[j].isPeak)
                {
                    balance += items * s.itemList[j].price;
                    items = 0;
                }

            }
            return balance;

        }

        //public static void Main(string[] args)
        //{
        //    //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        //    int t = Convert.ToInt32(Console.ReadLine().Trim());

        //    for (int tItr = 0; tItr < t; tItr++)
        //    {
        //        int n = Convert.ToInt32(Console.ReadLine().Trim());

        //        List<int> prices = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(pricesTemp => Convert.ToInt32(pricesTemp)).ToList();

        //        long result = stockmax(prices);

        //        // textWriter.WriteLine(result);
        //    }

            //  textWriter.Flush();
            // textWriter.Close();
        }

    }
//}
