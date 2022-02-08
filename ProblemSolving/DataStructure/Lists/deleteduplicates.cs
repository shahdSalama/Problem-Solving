using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.DataStructure.Lists
{
    public class deleteduplicates
    {
        public static SinglyLinkedListNode removeDuplicates(SinglyLinkedListNode node)
        {
            var result = node;
            while (node != null && node.next != null)
            {
                if (node.data != node.next.data)
                {
                    node = node.next;
                }
                else
                {
                    node.next = node.next.next;
                    node = node.next;
                }
            }
            return result;
        }

        
    }
}
