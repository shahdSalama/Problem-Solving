using HackerRank.DataStructure;
using System;

public class ReverseSinglyLinkedList
{
    public static void reversePrint(SinglyLinkedListNode llist)
    {
        if (llist == null)
            return;
        reversePrint(llist.next);
        Console.WriteLine(llist.data);

    }




}
