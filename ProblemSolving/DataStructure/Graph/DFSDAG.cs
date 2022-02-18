using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.DataStructure.Graph
{

    public class Node
    {
        public int val;
        public List<Node> neighbours;
    }

    class DFSDAG
    {
        public static bool graphDFS(Node node, int goal, HashSet<Node> visitid)
        {
            // base case
            if (node == null) return false;

            // base case, success
            if (node.val == goal) return true;

            // get all neighbours of node and perform recusrive dfs one by one if it is not in the visited set
            // then add it to the visited set
            foreach (Node neighbour in node.neighbours)
            {
                // check the visited set to avoid cycles
                if (visitid.Contains(neighbour)) continue;

                visitid.Add(neighbour);

                var found = graphDFS(neighbour, goal, visitid);
                if (found) return true;
            }
            return false;
        }

        public static void printDFSWithStack(Dictionary<char, char[]> graph, char source)
        {
            var stack = new Stack<char>();
            stack.Push(source);
            while (stack.Count != 0)
            {
                var current = stack.Pop();
                Console.WriteLine(current);
                foreach (var neighbour in graph[current])
                {
                    stack.Push(neighbour);
                }
            }
        }

       // public static HashSet<Node> visited = new HashSet<Node>();


        public static void printDFSWithRec(Dictionary<char, char[]> graph, char source)
        {
            Console.WriteLine(source);
           // visited.Add(node);
            foreach (var neighbour in graph[source])
            {
               printDFSWithRec(graph, neighbour);
            }
        }

        public static bool hasPath(Dictionary<char, char[]> graph, char source, char target)
        {
            if (source == target) return true;

            foreach (var neighbour in graph[source])
            {
                if (hasPath(graph, neighbour, target) == true) return true;
            }
            return false;
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
        //    var res=  hasPath(graph, source, target);

        //}

    }
}
