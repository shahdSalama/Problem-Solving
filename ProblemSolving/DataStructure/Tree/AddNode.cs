using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.DataStructure.Tree
{
    public class TreeNode
    {
        public int val;
        public TreeNode left, right;

        public TreeNode(int x)
        {
            val = x;
            left = right = null;
        }

        class AddNode
        {
            public static TreeNode InsertIntoBST(TreeNode root, int val)
            {
                var newNode = new TreeNode(val);
                AddNodeRec(ref root, newNode);
                return root;

            }
            public static void AddNodeRec(ref TreeNode root, TreeNode nodeToBeAdded)
            {
                if (root == null) root = nodeToBeAdded;

                if (nodeToBeAdded.val < root.val && root.left == null) root.left = nodeToBeAdded;
                else if (nodeToBeAdded.val > root.val && root.right == null) root.right = nodeToBeAdded;


                if (nodeToBeAdded.val < root.val && root.left != null) AddNodeRec(ref root.left, nodeToBeAdded);
                else if (nodeToBeAdded.val > root.val && root.right != null) AddNodeRec(ref root.right, nodeToBeAdded);

            }



            //public static void Main(string[] args)
            //{
            //    TreeNode root = null;

            //    InsertIntoBST(root, 5);





                 
            //}

        }
    }
}