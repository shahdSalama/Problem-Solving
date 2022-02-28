using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.DataStructure.Tree
{
    public class Solution1
    {


        public static bool IsLeaf(TreeNode x)
        {
            return x.left == null && x.right == null;
        }

        public static List<string> paths = new List<string>();

        public static void AddToListOfPaths(Stack<int> p)
        {
            var q = new Stack<int>(p);

            string path = "";
            while (q.Count != 0)
            {
                int value = q.Pop();
                if (q.Count > 0) path += value + "->";
                else path += value;
            }
            paths.Add(path);
        }

        public static void FindBinaryTreePaths(TreeNode root, Stack<int> s)
        {
            if (root == null) return;
            s.Push(root.val);

            if (IsLeaf(root))
            {
                AddToListOfPaths(s);
            }
            FindBinaryTreePaths(root.left, s);
            FindBinaryTreePaths(root.right, s);
            if (s.Count != 0) s.Pop();

        }

        public static List<string> BinaryTreePaths(TreeNode node)
        {
            // list to store root-to-leaf path
            var path = new Stack<int>();
            FindBinaryTreePaths(node, path);
            return paths;
        }

        //public static void Main(String[] args)
        //{

        //    TreeNode root = new TreeNode(1);
        //    root.left = new TreeNode(2);
        //    root.right = new TreeNode(3);
        
        //    root.left.right = new TreeNode(5);
        //    var x = BinaryTreePaths(root);

        //    //  var path = DFS(root, new List<int>(), new Node(5));
        //}
    }
}
