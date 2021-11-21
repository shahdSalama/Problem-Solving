using HackerRank.DataStructure;
using HackerRank.Recursion;
using System;
using System.Collections.Generic;
using System.Linq;
using static Solution;

namespace HackerRank
{
    class Program
    {
        static void Main(string[] args)
        {

            SinglyLinkedList llist1 = new SinglyLinkedList();

            int llist1Count = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < llist1Count; i++)
            {
                int llist1Item = Convert.ToInt32(Console.ReadLine());
                llist1.InsertNode(llist1Item);
            }

            SinglyLinkedList llist2 = new SinglyLinkedList();

            int llist2Count = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < llist2Count; i++)
            {
                int llist2Item = Convert.ToInt32(Console.ReadLine());
                llist2.InsertNode(llist2Item);
            }

            SinglyLinkedListNode llist3 = MergeTwoSortedLinkedLists.mergeLists(llist1.head, llist2.head);

            SinglyLinkedList.Print(llist3, " ");
            Console.WriteLine();


        }


    }
}

