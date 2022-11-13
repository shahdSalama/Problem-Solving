using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.DataStructure.Tree
{
    class sol
    {
        // Definition for a Node.
        public class Node
        {
            public int val;
            public IList<Node> children;

            public Node() { }

            public Node(int _val)
            {
                val = _val;
            }

            public Node(int _val, IList<Node> _children)
            {
                val = _val;
                children = _children;
            }
        }



        public static IList<IList<int>> LevelOrder(Node root)
        {
            if (root == null)
                return new List<IList<int>>();

            IList<IList<int>> res = new List<IList<int>>();
            var q = new Queue<(Node, int)>();

            q.Enqueue((root, 0));
            while (q.Count != 0)
            {//    
                (var currN, int currLevel) = q.Dequeue();
                if (res.Count >= currLevel + 1)
                    res[currLevel].Add(currN.val);
                // {{1}{3,2}}
                res.Add(new List<int> { currN.val });
                // q {{4,1}{5,2}{6,2}
                if (currN.children != null)
                {
                    foreach (var n in currN.children)
                        q.Enqueue((n, currLevel + 1));
                }

            }
            return res;
        }
       

    }
}
