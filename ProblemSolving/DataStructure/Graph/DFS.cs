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



    class DFS
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
    }
}
