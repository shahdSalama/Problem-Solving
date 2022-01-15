using System;
using System.Collections.Generic;
using System.IO;
class Solution1
{
    //static void Main(String[] args)
    //{
    //    int queriesCount = Convert.ToInt32(Console.ReadLine());
    //    var queue = new Queue();
    //    for (int i = 0; i < queriesCount; i++)
    //    {
    //        var queryString = Console.ReadLine();
    //        var stringArr = queryString.Split(' ');
    //        if (stringArr.Length > 1) // enqueu
    //        {

    //            queue.Enqueue(Convert.ToInt32(stringArr[1]));
    //        }
    //        else if (Convert.ToInt32(stringArr[0]) == 2)
    //        {
    //            queue.Dequeue();
    //        }
    //        else if (Convert.ToInt32(stringArr[0]) == 3)
    //        {
    //            queue.Print();
    //        }
    //    }
    //}
}

public class Queue
{
    Stack<int> s1;
    Stack<int> s2;

    public Queue()
    {
        s1 = new Stack<int>();
        s2 = new Stack<int>();
    }
    public void Enqueue(int x)
    {
        s1.Push(x);
    }
    public void Dequeue()
    {
        if (s2.Count == 0)
        {
            while (s1.Count != 0)
                s2.Push(s1.Pop());
        }
        s2.Pop();
    }
    public void Print()
    {
        if (s2.Count != 0)
            s2.Peek();

        else
        {
            while (s1.Count != 0)
            {
                s2.Push(s1.Pop());
            }
            Console.WriteLine("---->" + s2.Peek());

        }
    }
}