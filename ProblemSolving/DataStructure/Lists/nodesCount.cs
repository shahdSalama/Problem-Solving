using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.DataStructure.Lists
{
    class nodesCount
    {
        public static int getnumber(SinglyLinkedListNode node)
        {
            if (node == null) return 0;
            if (node.next == null)
                return 1;
            else return 1 + getnumber(node.next);
        }

        //public static void Main(string[] args)
        //{
        //    var node = new SinglyLinkedListNode(1);
        //    node.next = new SinglyLinkedListNode(2);
        //    node.next.next = new SinglyLinkedListNode(3);


        //  int res =  getnumber(node.next.next.next);
        //}
    }
}
