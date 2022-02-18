using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.DataStructure.Graph
{
    class BFSDAG
    {

        public static void PrintBFS(Dictionary<char, char[]> graph, char source)
        {
            Queue<char> q = new Queue<char>();
            q.Enqueue(source);

            while (q.Count != 0)
            {
                var curr = q.Dequeue();
                Console.WriteLine(curr);

                foreach (var neighbour in graph[curr])
                {
                    q.Enqueue(neighbour);
                }
            }

        }
        //public static void Main(String[] args)
        //{
        //    var graph = new Dictionary<char, char[]> {
        //        {'f',new char []{'g','i' } },
        //        {'g',new char []{'h' } },
        //        {'h',new char []{ } },
        //        {'i',new char []{'g','k' } },
        //        {'j',new char []{'i' } },
        //        {'k',new char []{ } },
        //    };
        //    char source = 'f';
        //    char target = 'k';
        //    var res = hasPath(graph, source, target);
        //    var res2 = hasPath(graph, 'h', 'f');

        //}

        private static bool hasPath(Dictionary<char, char[]> graph, char source, char target)
        {
            var queue = new Queue<char>();
            queue.Enqueue(source);

            while (queue.Count != 0)
            {
                var curr = queue.Dequeue();
                if (curr == target) return true;
                foreach (var neighbour in graph[curr])
                {
                    queue.Enqueue(neighbour);
                }
            }
            return false;
        }
    }

}

