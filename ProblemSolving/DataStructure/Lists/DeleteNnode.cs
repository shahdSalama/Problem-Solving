using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.DataStructure.Lists
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    class DeleteNnode
    {
        public static ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            if (head == null) return null;
            var q = new Queue<ListNode>();
            while (head != null)
            {
                q.Enqueue(new ListNode(head.val));
                head = head.next;
            }
            int i = 1;
            if (n == 1)
            {
                q.Dequeue();
                i++;
            }
            if (q.Count == 0) return null;

            ListNode node = q.Dequeue();
            ListNode temp = node;
           
            i++;

            while (q.Count != 0)
            {

                if (i == n) q.Dequeue();
                else
                {
                    node.next = q.Dequeue();
                    node = node.next;
                }
                i++;
            }
            return temp;

        }
        //public static void Main(string[] args)
        //{
        //    var one = new ListNode(1);
        //    var t = new ListNode(2);
        //    var th = new ListNode(3);
        //    var f = new ListNode(4);
        //    var fv = new ListNode(5);
        //    one.next = t;
        //    t.next = th;
        //    th.next = f;
        //    f.next = fv;
        //    RemoveNthFromEnd(one, 2);


        //}
    }
}
