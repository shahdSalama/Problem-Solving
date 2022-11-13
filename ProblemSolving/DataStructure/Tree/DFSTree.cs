using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.DataStructure.Tree
{
    class DFSTree
    {
        public bool dfsRec(TreeNode root, int data)
        {
            if (root == null) return false;
            if (root.val == data) return true;

            return dfsRec(root.left, data) && dfsRec(root.right, data);
        }

        public bool dfsWithtack(TreeNode root, int data)
        {
            if (root == null) return false;
            var s = new Stack<TreeNode> ();
            s.Push(root);
            while (s.Count != 0)
            {
                var current = s.Pop();
                if (current.val == data) return true;
                if (current.right != null) s.Push(current.right);
                if (current.left != null) s.Push(current.left);
            }
            return false;
        }


        /// <summary>
        /// left root right
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static List<TreeNode> DFSInOrder(TreeNode root)
        {
            if (root == null) return new List<TreeNode>();
            var leftNodes = DFSInOrder(root.left);
            var rightNodes = DFSInOrder(root.right);
            leftNodes.Add(root);
            leftNodes.AddRange(rightNodes);
            return leftNodes;
        
        }

        /// <summary>
        /// left right root
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static List<TreeNode> DFSPostOrder(TreeNode root)
        {
            if (root == null) return new List<TreeNode>();
            var leftNodes = DFSPostOrder(root.left);
            var rightNodes = DFSPostOrder(root.right);
            leftNodes.AddRange(rightNodes);
            leftNodes.Add(root);
            return leftNodes;

        }
        /// <summary>
        ///  root left right
        ///
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static List<TreeNode> DFSPreOrder(TreeNode root)
        {
            if (root == null) return new List<TreeNode>();
            var leftNodes = DFSPreOrder(root.left);
            var rightNodes = DFSPreOrder(root.right);
            var list = new List<TreeNode> { root };
            list.AddRange(leftNodes);
            list.AddRange(rightNodes);
            return list;

        }
        //public static void Main(string[] args)
        //{

        //    var root = new TreeNode(5);
        //    root.right = new TreeNode(3);
        //    root.left = new TreeNode(1);
        //    root.left.left = new TreeNode(7);
        //    root.left.right = new TreeNode(3);
        //    var res = DFSPreOrder(root);
        //}

    }
}
