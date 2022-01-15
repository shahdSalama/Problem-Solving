// C# program for above approach
using System;
using System.Collections.Generic;

class GFG
{

    // Create a class Node to enter 
    // values and address in the list
    public class Node
    {
        public int data;
        public Node next;
    };
    static Node head = null;

    // Function to reverse the 
    // linked list
    static void reverseLL()
    {

        // Create a stack "s" 
        // of Node type
        Stack<Node> s = new Stack<Node>();
        Node temp = head;

        while (temp.next != null)
        {

            // Push all the nodes 
            // in to stack
            s.Push(temp);
            temp = temp.next;
        }
        head = temp;

        while (s.Count != 0)
        {

            // Store the top value of
            // stack in list
            temp.next = s.Peek();

            // Pop the value from stack
            s.Pop();

            // Update the next pointer in the
            // in the list
            temp = temp.next;
        }
        temp.next = null;
    }

    // Function to Display 
    // the elements in List
    static void printlist(Node temp)
    {
        while (temp != null)
        {
            Console.Write(temp.data + " ");
            temp = temp.next;
        }
    }

    // Function to insert back of the 
    // linked list
    static void insert_back(int value)
    {

        // We have used insertion at back method
        // to enter values in the list.(eg:
        // head.1.2.3.4.Null)
        Node temp = new Node();
        temp.data = value;
        temp.next = null;

        // If *head equals to null
        if (head == null)
        {
            head = temp;
            return;
        }
        else
        {
            Node last_node = head;

            while (last_node.next != null)
            {
                last_node = last_node.next;
            }
            last_node.next = temp;
            return;
        }
    }

    // Driver Code
    //public static void Main(String[] args)
    //{
    //    insert_back(1);
    //    insert_back(2);
    //    insert_back(3);
    //    insert_back(4);
    //    Console.Write("Given linked list\n");

    //    printlist(head);
    //    reverseLL();

    //    Console.Write("\nReversed linked list\n");
    //    printlist(head);
    //}
}

// This code is contributed by gauravrajput1 