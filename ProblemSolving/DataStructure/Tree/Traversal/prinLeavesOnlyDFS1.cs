using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.DataStructure.Tree.Traversal
{
    public class prinLeavesOnlyDFS1
    {
        public static void prinLeavesOnlyDFS(TreeNode node)
        {
            if (node == null) return;

            // leaf node
            if (node.left == null && node.right == null)
                Console.WriteLine(node.val);

            if (node.left != null)
            {
                prinLeavesOnlyDFS(node.left);
            }
            if (node.right != null)
                prinLeavesOnlyDFS(node.left);

        }
    }
}
