using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{

    public class SinglyLinkedListNode
    {
        public int data;
        public SinglyLinkedListNode next;

        public SinglyLinkedListNode(int nodeData)
        {
            this.data = nodeData;
            this.next = null;
        }
    }

    public class SinglyLinkedList
    {
        public SinglyLinkedListNode head;
        public SinglyLinkedListNode tail;

        public SinglyLinkedList()
        {
            this.head = null;
            this.tail = null;
        }

        public void InsertNode(int nodeData)
        {
            SinglyLinkedListNode node = new SinglyLinkedListNode(nodeData);

            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                this.tail.next = node;
            }

            this.tail = node;
        }
    }

    static void PrintSinglyLinkedList(SinglyLinkedListNode node, string sep)
    {
        while (node != null)
        {
            Console.Write(node.data);

            node = node.next;

            if (node != null)
            {
                Console.Write(sep);
            }
        }
    }

    class Result
    {

        /*
         * Complete the 'reversePrint' function below.
         *
         * The function accepts INTEGER_SINGLY_LINKED_LIST llist as parameter.
         */

        /*
         * For your reference:
         *
         * SinglyLinkedListNode
         * {
         *     int data;
         *     SinglyLinkedListNode next;
         * }
         *
         */


    }




    public static Stack<SinglyLinkedListNode> FillStack(Stack<SinglyLinkedListNode> s1,
SinglyLinkedListNode node)
    {
        if (node.next == null)
        {
            s1.Push(node);
            return s1;
        }

        else
        {
            s1.Push(node);

            return FillStack(s1, node.next);
        }
    }





    public static void reversePrint(SinglyLinkedListNode llist)
    {
        Stack<SinglyLinkedListNode> stack = new Stack<SinglyLinkedListNode>();

        stack = FillStack(stack, llist);


        SinglyLinkedList reversed = new SinglyLinkedList();


        while (stack.Count() != 0)
        {
            reversed.InsertNode(stack.Pop().data);

        }

        llist = reversed.head;

        while (llist != null)
        {
            Console.WriteLine(llist.data);
            llist = llist.next;
        }


    }




}
