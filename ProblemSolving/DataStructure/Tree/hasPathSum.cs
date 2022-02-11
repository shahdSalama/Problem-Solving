using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.DataStructure.Tree
{
    public class Solution
    {

        public static bool DFS(TreeNode root, int result, int target)
        {

            if (root == null) return result == target;

            result += root.val;

            bool left = false;
            if (root.left != null) left = DFS(root.left, result, target);

            bool right = false;
            if (root.right != null) right = DFS(root.right, result, target);

            return right || left;

        }



        public static bool HasPathSum(TreeNode root, int targetSum)
        {
            if (root == null) return false;
            return DFS(root, 0, targetSum);
        }

        //public static void Main(string[] args)
        //{
        //    TreeNode root = new TreeNode(5);
        //    root.left = new TreeNode(4);
        //    root.right = new TreeNode(8);
        //    root.left.left = new TreeNode(11);
        //    root.left.left.left = new TreeNode(7);
        //    root.left.left.right = new TreeNode(2);
        //    root.right.left = new TreeNode(13);
        //    root.right.right = new TreeNode(4);
        //    root.right.right.right = new TreeNode(1);
        //    bool x = HasPathSum(root, 22);

        //}
    }
}
