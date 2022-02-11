using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.DataStructure.Tree
{
    class InvertBinaryTree
    {
        public TreeNode InvertTree(TreeNode root)
        {
            if (root == null) return null;
            if (root.left == null && root.right == null) return root;

            var right = root.right;
            root.right = root.left;
            root.left = right;
            InvertTree(root.left);
            InvertTree(root.right);
            return root;

        }
    }
}
