using System;
using System.Collections.Generic;

namespace HackerRank
{

    // class of queue having two stacks
    public class Queue
    {
        public Queue()
        {
            stack1 = new Stack<int>();
        }

        public Stack<int> stack1;

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
        public void enQueue(int x)
        {
            push(stack1, x);
        }

        /* Function to deQueue an item from queue */
        public int deQueue()
        {
            int x, res = 0;

            /* If the stacks is empty then error */
            if (stack1.Count == 0)
            {
                Console.WriteLine("Q is Empty");
                Environment.Exit(0);
            }

            // Check if it is a last element of stack
            else if (stack1.Count == 1)
            {
                return pop(stack1);
            }
            else
            {

                /* pop an item from the stack1 */
                x = pop(stack1);

                /* store the last deQueued item */
                res = deQueue();

                /* push everything back to stack1 */
                push(stack1, x);
                return res;
            }
            return 0;
        }
    }

    ///* Driver function to test above functions */

    ///* Create a queue with items 1 2 3*/
    //Queue q = new Queue();
    //q.stack1 = new Stack<int>();

    //    enQueue(q, 1);
    //enQueue(q, 2);
    //enQueue(q, 3);

    ///* Dequeue items */
    //Console.Write(deQueue(q) + " ");
    //    Console.Write(deQueue(q) + " ");
    //    Console.Write(deQueue(q) + " ");




}
