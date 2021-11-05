using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank
{
    class Program
    {
        public static void Main(string[] args)
        {
            //    //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
            //    int T = Convert.ToInt32(Console.ReadLine().Trim());

            //    for (int TItr = 0; TItr < T; TItr++)
            //    {
            //        string w = Console.ReadLine();

            //        string result = BiggerisGreater.biggerIsGreater(w);

            //       Console.WriteLine(result);
            //    }

            Queue q = new Queue();
            q.enQueue(1);
            q.enQueue(2);
            q.enQueue(3);

            /* Dequeue items */
            Console.Write(q.deQueue() + " ");
            Console.Write(q.deQueue() + " ");
            Console.Write(q.deQueue() + " ");
            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
