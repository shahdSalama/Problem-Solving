using HackerRank.DataStructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Recursion
{
    class sortMerge
    {
        public static SinglyLinkedListNode sortMergeNode(SinglyLinkedListNode A, SinglyLinkedListNode B)
        {
            if (A == null) return B;
            if (B == null) return A;

            if (A.data < B.data)
            {
                A.next = sortMergeNode(A.next, B);
                return A;
            }
            else
            {
                B.next = sortMergeNode(A, B.next);
                return B;
            }
        }
    }
}
