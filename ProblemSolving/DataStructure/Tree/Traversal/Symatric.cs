using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.DataStructure.Tree.Traversal
{
    class Symatric
    {

        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }

        public bool isMirror(TreeNode a, TreeNode b)
        {
            if (a == null && b == null) return true;

            if (a != null && b != null)

                return (a.val == b.val && isMirror(a.left, b.right) && isMirror(a.right, b.left));

            return false;
        }

    }
}
