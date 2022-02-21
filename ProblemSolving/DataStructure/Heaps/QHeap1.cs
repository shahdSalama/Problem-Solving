using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class QHeap1
{
    static void Run()
    {
        List<int> output = new List<int>();
        int queryCount = Convert.ToInt32(Console.ReadLine());
        MinHeap h = new MinHeap();
        for (int i = 0; i < queryCount; i++)
        {

            string input = Console.ReadLine();

            string[] inputArray = input.Split(' ');
            string operation = inputArray[0];




            // Console.WriteLine(value);
            if (operation == "1") // insert
            {
                int value = Convert.ToInt32(inputArray[1]);
                h.Add(value);

            }
            if (operation == "2") // Delete
            {

                int value = Convert.ToInt32(inputArray[1]);
                h.Delete(value);

            }
            if (operation == "3")
            {

                var peak = h.Peak();
                output.Add(peak);
                //  Console.WriteLine(peak);
            }
        }
        Console.WriteLine("---------------");
        foreach (var item in output)
        {
            Console.WriteLine(item);
        }
    }
}
public class MinHeap
{
    int size = 0;
    static int capacity = 10;
    int[] items = new int[capacity];

    // get the indexies

    int GetLeftChildIndex(int index) { return 2 * index + 1; }
    int GetRightChildIndex(int index) { return 2 * index + 2; }
    int GetParentIndex(int index) { return (index - 1) / 2; }

    // get values
    int GetLeftChild(int index) { return items[GetLeftChildIndex(index)]; }
    int GetRightChild(int index) { return items[GetRightChildIndex(index)]; }
    int GetPArent(int index) { return items[GetParentIndex(index)]; }

    // check for existance 
    bool HasLeftChild(int index) { return GetLeftChildIndex(index) < size; }
    bool HasRightChild(int index) { return GetRightChildIndex(index) < size; }
    bool HasParent(int index) { return GetParentIndex(index) >= 0; }

    // swap

    void Swap(int indexOne, int indexTwo)
    {
        int firstValue = items[indexOne];
        items[indexOne] = items[indexTwo];
        items[indexTwo] = firstValue;
    }


    // ensure extra capacity, use it when adding items

    void EnsureExtraCapacity()
    {
        if (size == capacity)
        {
            int[] temp = new int[size * 2];
            Array.Copy(items, temp, size);
            capacity = capacity * 2;
            items = temp;
        }
    }

    // add element
    public void Add(int element)
    {
        EnsureExtraCapacity();
        items[size] = element;
        size++;
        HeapifyUp();
    }

    // peak // look at the top
    public int Peak()
    {
        return items[0];
    }

    // poll // pop the root node
    public int Poll()
    {
        int root = items[0];
        items[0] = items[size - 1];
        size--;
        HeapifyDown();
        return root;

    }

    public void Delete(int value)
    {
        int valueIndex = GetIndexOfItem(value);

        Swap(valueIndex, size - 1);
        size--;
        if (size > 0)
            HeapifyDown();
    }

    int GetIndexOfItem(int value)
    {
        for (int i = 0; i < size; i++)
        {
            if (items[i] == value)
                return i;
        }
        return -1;
    }


    // heapify up, after addinf

    void HeapifyUp()
    {
        int value = items[size - 1];
        int index = size - 1;
        while (HasParent(index) && GetPArent(index) > value)
        {
            Swap(index, GetParentIndex(index));
            index = GetParentIndex((index));
        }
    }

    // heapify down, after deleting we work on the root node

    void HeapifyDown()
    {
        int value = items[0];
        int index = 0;
        while (HasLeftChild(index))
        {
            int minValue = GetLeftChild(index);
            int minIndex = GetLeftChildIndex(index);
            if (HasRightChild(index) && GetRightChild(index) < minValue)
            {
                minValue = GetRightChild(index);
                minIndex = GetRightChildIndex(index);
            }
            if (items[index] < minValue) break;

            else Swap(index, minIndex);
            index = minIndex;
        }
    }

}