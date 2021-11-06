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
      
            Solution.SinglyLinkedList llist = new SinglyLinkedList();

            int llistCount = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < llistCount; i++)
            {
                int llistItem = Convert.ToInt32(Console.ReadLine());
                llist.InsertNode(llistItem);
            }

            reversePrint(llist.head);

        }
    }
}
