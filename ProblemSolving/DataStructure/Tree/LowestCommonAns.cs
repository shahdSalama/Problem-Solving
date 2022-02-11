using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.DataStructure.Tree
{
    class LowestCommonAns
    {
        public static bool haspath(TreeNode root, List<TreeNode> path, TreeNode target)
        {

            if (root == null) return false;

            path.Add(root);


            if (root == target) return true;

            if (haspath(root.left, path, target) || haspath(root.right, path, target))
                return true;

            path.RemoveAt(path.Count - 1);
            return false;

        }


        public static TreeNode  LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root == null) return null;
            List<TreeNode> pathP = new List<TreeNode>();
            List<TreeNode> pathQ = new List<TreeNode>();

            var haspathp = haspath(root, pathP, p);
            var haspathq = haspath(root, pathQ, q);

            if (haspathq && haspathp)
            {

                int n = pathP.Count;
                int m = pathQ.Count;

                if (n > m)
                {
                    var diff = n - m;
                    for (int i = 0; i < diff; i++)
                    {
                        pathQ.Add(new TreeNode(-1));
                    }
                }
                if (m > n)
                {
                    var diff = m - n;
                    for (int i = 0; i < diff; i++)
                    {
                        pathP.Add(new TreeNode(-1));
                    }
                }

                pathP.Reverse();
                pathQ.Reverse();

                for (int i = 0; i < pathQ.Count; i++)
                {
                    if (pathQ[i] == pathP[i]) return pathP[i];

                }
            }
            return null;
        }



        public static void Main(String[] args)
        {

            TreeNode root = new TreeNode(6);
            root.left = new TreeNode(2);
            root.right = new TreeNode(8);
            root.left.left = new TreeNode(0);
            root.left.right = new TreeNode(4);
            var x = LowestCommonAncestor(root, root.left, root.left.right);

            //  var path = DFS(root, new List<int>(), new Node(5));
        }
    }
}
