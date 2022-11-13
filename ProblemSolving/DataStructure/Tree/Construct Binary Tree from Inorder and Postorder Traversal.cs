using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.DataStructure.Tree
{
    class Construct_Binary_Tree_from_Inorder_and_Postorder_Traversal
    {

        public static TreeNode BuildTree(int[] inorder, int[] postorder)
        {
            if (postorder.Length == 0 || inorder.Length == 0) return null;
            var len = postorder.Length;
            var root = new TreeNode(postorder[len - 1]);

            //1
            var rootIndexInInorder = Array.IndexOf(inorder, root.val);

            root.left = BuildTree(inorder.Take(rootIndexInInorder).ToArray(), postorder.Take(rootIndexInInorder).ToArray());

            root.right = BuildTree(inorder.Skip(1 + rootIndexInInorder).ToArray(), postorder.Skip(rootIndexInInorder).Take(len - 1 - rootIndexInInorder).ToArray());

            return root;
        }
       

    }
}
