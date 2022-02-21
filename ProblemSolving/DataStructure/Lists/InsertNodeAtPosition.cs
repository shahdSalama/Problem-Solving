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

class Solutionmm
{

    class SinglyLinkedListNode
    {
        public int data;
        public SinglyLinkedListNode next;

        public SinglyLinkedListNode(int nodeData)
        {
            this.data = nodeData;
            this.next = null;
        }
    }

    class SinglyLinkedList
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

    static void PrintSinglyLinkedList(SinglyLinkedListNode node, string sep, TextWriter textWriter)
    {
        while (node != null)
        {
            textWriter.Write(node.data);

            node = node.next;

            if (node != null)
            {
                textWriter.Write(sep);
            }
        }
    }

   

        /*
         * Complete the 'insertNodeAtPosition' function below.
         *
         * The function is expected to return an INTEGER_SINGLY_LINKED_LIST.
         * The function accepts following parameters:
         *  1. INTEGER_SINGLY_LINKED_LIST llist
         *  2. INTEGER data
         *  3. INTEGER position
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

        static SinglyLinkedListNode insertNodeAtPosition(SinglyLinkedListNode llist, int data, int position)
        {
            SinglyLinkedListNode newNode = new SinglyLinkedListNode(data);

            int positionCounter = 0;

            var head = llist;
            

            while (positionCounter != position)
            {
                head = head.next;

                positionCounter++;
            }

            var temp = head;

            head = newNode;
            head.next = temp;

            return llist;
        
    }

        //static void Main(string[] args)
        //{
        //   // TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        //    SinglyLinkedList llist = new SinglyLinkedList();

        //    int llistCount = Convert.ToInt32(Console.ReadLine());

        //    for (int i = 0; i < llistCount; i++)
        //    {
        //        int llistItem = Convert.ToInt32(Console.ReadLine());
        //        llist.InsertNode(llistItem);
        //    }

        //    int data = Convert.ToInt32(Console.ReadLine());

        //    int position = Convert.ToInt32(Console.ReadLine());

        //    SinglyLinkedListNode llist_head = insertNodeAtPosition(llist.head, data, position);

        //}
    }
