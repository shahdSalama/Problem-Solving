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
using static Solution;
using HackerRank.DataStructure;

public class MergeTwoSortedLinkedLists
{
   

    public static SinglyLinkedListNode mergeLists(SinglyLinkedListNode head1, SinglyLinkedListNode head2)
    {

        if (head1 == null)
        {
            return head2;
        }
        else if (head2 == null)
        {
            return head1;
        }


        SinglyLinkedListNode mergedHead = null;
        if (head1.data <= head2.data)
        {
            mergedHead = head1;
            head1 = head1.next;
        }
        else
        {
            mergedHead = head2;
            head2 = head2.next;
        }

        SinglyLinkedListNode mergedTail = mergedHead;

        while (head1 != null && head2 != null)
        {
            SinglyLinkedListNode temp = null;
            if (head1.data <= head2.data)
            {
                temp = head1;
                head1 = head1.next;
            }
            else
            {
                temp = head2;
                head2 = head2.next;
            }

            mergedTail.next = temp;
            mergedTail = temp;
           
        }

        if (head1 != null)
        {
            mergedTail.next = head1;
        }
        else if (head2 != null)
        {
            mergedTail.next = head2;
        }
        return mergedHead;
    }

    public static SinglyLinkedListNode mergeLists2(SinglyLinkedListNode headA, SinglyLinkedListNode headB)
    {

        /* a dummy first node to
        hang the result on */
        SinglyLinkedListNode dummyNode = new SinglyLinkedListNode(0);

        /* tail points to the
        last result node */
        SinglyLinkedListNode tail = dummyNode;
        while (true)
        {

            /* if either list runs out,
            use the other list */
            if (headA == null)
            {
                tail.next = headB;
                break;
            }
            if (headB == null)
            {
                tail.next = headA;
                break;
            }

            /* Compare the data of the two
            lists whichever lists' data is
            smaller, append it into tail and
            advance the head to the next Node
            */
            if (headA.data <= headB.data)
            {
                tail.next = headA;
                headA = headA.next;
            }
            else
            {
                tail.next = headB;
                headB = headB.next;
            }

            /* Advance the tail */
            tail = tail.next;
        }
        return dummyNode.next;
    }
}