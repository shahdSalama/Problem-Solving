﻿using System;
using System.Collections.Generic;
using System.Text;
using static HackerRank.DataStructure.Tree.Traversal.LevelOrderTraversal;

namespace HackerRank.DataStructure.Tree.Traversal
{
    public class LevelOrderTraversal // BFS
    {
        public class TreeNode
        {
            public int data;
            public TreeNode left, right;

            public TreeNode(int x)
            {
                data = x;
                left = right = null;
            }

        }


        public static int Hieght(TreeNode root)
        {
            if (root == null) return 0; // base condition

            int leftH = Hieght(root.left);
            int rightH = Hieght(root.right);

            if (leftH > rightH)
                return (leftH + 1);
            else return rightH + 1;

        }

        public static void PrintLevelOrderWithLoop(TreeNode root)
        {
            int hieght = Hieght(root);
            for (int level = 1; level <= hieght; level++)
            {
                printCurrentLevel(root, level);
            }

        }


        private static void printCurrentLevel(TreeNode root, int level)
        {
            if (root == null) return;
            if (level == 1) Console.Write(root.data + " ");

            else if (level >= 1)
            {
                printCurrentLevel(root.left, level - 1);
                printCurrentLevel(root.right, level - 1);
            }
        }

        public static List<TreeNode> PrintLevelOrderWithQueue(TreeNode root)
        {
            List<TreeNode> result = new List<TreeNode>();
            var q = new Queue<TreeNode>();
            if (root != null)
            {
                q.Enqueue(root);
            }

            while (q.Count != 0)
            {
                var curr = q.Dequeue();

                result.Add(curr);

                if (curr.left != null)  q.Enqueue(curr.left);
                if (curr.right != null) q.Enqueue(curr.right);

            }
            return result;

        }

        //public static void Main(string[] args)
        //{
        //    var root = new TreeNode(3);

        //    root.left = new TreeNode(2);
        //    root.right = new TreeNode(5);

        //    root.left.left = new TreeNode(1);
        //    root.right.left = new TreeNode(4);
        //    root.right.right = new TreeNode(6);
        //    root.right.right.right = new TreeNode(7);
        //    Console.WriteLine("level order traversal "
        //                      + "of binary tree is ");
        //    var res = PrintLevelOrderWithQueue(root);
        //    //    3 

        //    //2        5
        //  //1          4   6
        //  //                          7
        //}

    }



}
