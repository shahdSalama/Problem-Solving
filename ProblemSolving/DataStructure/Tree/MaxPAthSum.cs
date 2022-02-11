using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.DataStructure.Tree
{
    class MaxPAthSum
    {
        public int MaxPathSum(TreeNode root)
        {
            if (root == null) return Int32.MinValue;
            if (root.right == null && root.left == null) return root.val;
            int left = MaxPathSum(root.left);
            int right = MaxPathSum(root.right);
            int maxchildPathSum =  Math.Max(left, right);
            return root.val + maxchildPathSum;
        }
    }
}
