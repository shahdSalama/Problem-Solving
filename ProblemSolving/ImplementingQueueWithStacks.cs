using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    class ImplementingQueueWithStacks
    {
        // class of queue having two stacks
        public class Queue
        {
            public Stack<int> stack1;
        }

        /* Function to push an item to stack*/
        static void push(Stack<int> top_ref, int new_data)
        {
            /* put in the data */
            top_ref.Push(new_data);
        }

        /* Function to pop an item from stack*/
        static int pop(Stack<int> top_ref)
        {
            /*If stack is empty then error */
            if (top_ref == null)
            {
                Console.WriteLine("Stack Underflow");
                Environment.Exit(0);
            }
            // return element from stack
            return top_ref.Pop();
        }

        /* Function to enqueue an item to queue */
        static void enQueue(Queue q, int x)
        {
            push(q.stack1, x);
        }

        /* Function to deQueue an item from queue */
        static int deQueue(Queue q)
        {
            int x, res = 0;

            /* If the stacks is empty then error */
            if (q.stack1.Count == 0)
            {
                Console.WriteLine("Q is Empty");
                Environment.Exit(0);
            }

            // Check if it is a last element of stack
            else if (q.stack1.Count == 1)
            {
                return pop(q.stack1);
            }
            else
            {

                /* pop an item from the stack1 */
                x = pop(q.stack1);

                /* store the last deQueued item */
                res = deQueue(q);

                /* push everything back to stack1 */
                push(q.stack1, x);
                return res;
            }
            return 0;
        }

        /* Driver function to test above functions */
        public static void Main(String[] args)
        {
            /* Create a queue with items 1 2 3*/
            Queue q = new Queue();
            q.stack1 = new Stack<int>();

            enQueue(q, 1);
            enQueue(q, 2);
            enQueue(q, 3);

            /* Dequeue items */
            Console.Write(deQueue(q) + " ");
            Console.Write(deQueue(q) + " ");
            Console.Write(deQueue(q) + " ");
        }


    }
}
