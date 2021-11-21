using HackerRank.DataStructure;
using System;

public class Solution
{

   

    public static void reversePrint(SinglyLinkedListNode llist)
    {
        if (llist == null)
            return;
        reversePrint(llist.next);
        Console.WriteLine(llist.data);

    }




}
