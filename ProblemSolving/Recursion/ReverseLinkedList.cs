using HackerRank.DataStructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Recursion
{
    class ReverseLinkedList
    {
        public static SinglyLinkedListNode RevListRec(SinglyLinkedListNode head)
        {
            if (head == null || head.next == null)
                return head;

            var p = RevListRec(head.next);

            head.next.next = head;
            head.next = null;
            return p;
        }
    }

}

