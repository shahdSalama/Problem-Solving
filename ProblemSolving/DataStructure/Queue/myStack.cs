using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.DataStructure.Queue
{

    public class MyStack
    {
        Queue<int> Q1;
        Queue<int> Q2;
        public MyStack()
        {
            var Q1 = new Queue<int>();// 1
            var Q2 = new Queue<int>();// 2
        }

        public void Push(int x)
        {
            if (Q2.Count != 0)
                Q1.Enqueue(Q2.Dequeue());
            Q2.Enqueue(x);
        }

        public int Pop()
        {

            int res = Q2.Dequeue();
            return res;

        }

        public int Top()
        {
            return Q2.Peek();
        }

        public bool Empty()
        {
            return Q2.Count == 0;
        }
    }
    public class sol
    {
       
    }



}
