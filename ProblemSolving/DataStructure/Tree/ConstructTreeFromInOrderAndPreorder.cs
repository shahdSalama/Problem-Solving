using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.DataStructure.Tree
{
    class ConstructTreeFromInOrderAndPreorder
    {
        public static TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            if (preorder.Length == 0 || inorder.Length == 0) return null;
            // pre      // root  left right
            // inorder // left   root right 
            var root = new TreeNode(preorder[0]);
            var rootIndexInInorder = Array.IndexOf(inorder, root.val);
            // what is the preorder of left, what is inorder of right


            root.left = BuildTree(preorder.Skip(1).Take(rootIndexInInorder).ToArray(), inorder.Take(rootIndexInInorder).ToArray());
            root.right = BuildTree(preorder.Skip(rootIndexInInorder + 1).ToArray(), inorder.Skip(rootIndexInInorder + 1).ToArray());
            return root;

        }
    

    }
}
