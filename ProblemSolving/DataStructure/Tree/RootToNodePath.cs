// C# implementation to print the path from root
// to a given node in a binary tree
using System;
using System.Collections;
using System.Collections.Generic;

class PrintPath
{

    // A node of binary tree
    public class Node
    {
        public int data;
        public Node left, right;
        public Node(int data)
        {
            this.data = data;
            left = right = null;
        }
    }

    // Returns true if there is a path from root
    // to the given node. It also populates
    // 'arr' with the given path
    public static bool hasPath(Node root, List<int> arr, int x)
    {
        // if root is NULL
        // there is no path
        if (root == null)
            return false;

        // push the node's value in 'arr'
        arr.Add(root.data);

        // if it is the required node
        // return true
        if (root.data == x)
            return true;

        // else check whether the required node lies
        // in the left subtree or right subtree of
        // the current node
        if (hasPath(root.left, arr, x) ||
            hasPath(root.right, arr, x))
            return true;

        // required node does not lie either in the
        // left or right subtree of the current node
        // Thus, remove current node's value from
        // 'arr'and then return false	
        arr.RemoveAt(arr.Count - 1);
        return false;
    }

    // function to print the path from root to the
    // given node if the node lies in the binary tree
    public static void printPath(Node root, int x)
    {
        // List to store the path
        List<int> arr = new List<int>();

        // if required node 'x' is present
        // then print the path
        if (hasPath(root, arr, x))
        {
            for (int i = 0; i < arr.Count - 1; i++)
                Console.Write(arr[i] + "->");
            Console.Write(arr[arr.Count - 1]);
        }

        // 'x' is not present in the binary tree
        else
            Console.Write("No Path");
    }
}

  

    // Driver code
//    public static void Main(String[] args)
//    {

//        Node root = new Node(1);
//        root.left = new Node(2);
//        root.right = new Node(3);
//        root.left.left = new Node(4);
//        root.left.right = new Node(5);
//        root.right.left = new Node(6);
//        root.right.right = new Node(7);
//        int x = 5;

//     //  var path = DFS(root, new List<int>(), new Node(5));
//    }
//}

// This code is contributed by Arnab Kundu
//        1
//    2 ------3
// 4 -- 5   