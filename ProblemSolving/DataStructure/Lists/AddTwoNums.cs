using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.DataStructure.Lists
{
    class AddTwoNums
    {
        public static SinglyLinkedListNode AddTwoNumbers(SinglyLinkedListNode l1, SinglyLinkedListNode l2)
        {
            long one = ReverseLinkedList(l1);

            long two = ReverseLinkedList(l2);

            long res = one + two;
            return ConstructLL(res);
        }
        static long ReverseLinkedList(SinglyLinkedListNode l1)
        {
            var q = new Queue<int>();
            while (l1 != null)
            {
                q.Enqueue(l1.data);
                l1 = l1.next;
            }
            long num = 0;
            long mul = 1;
            while (q.Count != 0)
            {
                var curr = q.Dequeue();
                var real = curr * mul;
                num += real;
                mul = mul * 10;
            }
            return num;
        }
        static SinglyLinkedListNode ConstructLL(long res)
        {
            // 807  => [7, 0, 8]
            var arr = res.ToString().ToCharArray();
          
            var s = new Stack<int>();
            foreach (var c in arr)
            {
                s.Push(int.Parse(c.ToString()));
            }
            SinglyLinkedListNode node = new SinglyLinkedListNode(s.Pop());
            SinglyLinkedListNode temp = node;
            for (int i = 1 ; i < arr.Length; i++)
            {
                var next = new SinglyLinkedListNode(s.Pop());
                node.next = next;
                node = node.next;
            }
            return temp;
        }
       
    }
}
