﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.DataStructure
{
    public class MinHeap
    {
        public static int capacity = 10;
        public int size;
        public int[] items = new int[capacity];

        int getLeftChildIndex(int i) { return i * 2 + 1; }
        int getRightChildIndex(int i) { return i * 2 + 2; }
        int getParentIndex(int i) { return (i - 1) / 2; }
        bool hasRightChild(int i) { return getRightChildIndex(i) < size; }
        bool hasLeftChild(int i) { return getLeftChildIndex(i) < size; }
        bool hasParent(int i) { return getParentIndex(i) >= 0; }
        int GetLeftChild(int i) { return items[getLeftChildIndex(i)]; }
        int GetRightChild(int i) { return items[getRightChildIndex(i)]; }
        int GetParent(int i) { return items[getParentIndex(i)]; }


        void swap(int indexOne, int indexTwo)
        {
            int temp = items[indexOne];
            items[indexOne] = items[indexTwo];
            items[indexTwo] = temp;
        }

        void EnsureExtraCapacity()
        {
            if (size == capacity)
            {
                int[] temp = new int[capacity * 2];
                Array.Copy(items, temp, capacity);
                items = temp;
                capacity = capacity * 2;
            }
        }

        /// <summary>
        /// it goes as the last element and then we bubble up until we restore the heap property
        /// </summary>
        /// <param name="x"></param>
        public void addElement(int x)
        {
            EnsureExtraCapacity();
            items[size] = x;
            size++;
            heapifyUp();
        }
        /// <summary>
        /// look at the min element , which is the root node
        /// </summary>
        /// <returns></returns>
        public int peak()
        {
            if (size == 0) throw new InvalidOperationException();
            return items[0];
        }


        /// <summary>
        /// remove the min element which is the root node
        /// </summary>
        public int poll()
        {
            if (size == 0) throw new InvalidOperationException();
            int root = items[0];
            items[0] = items[size - 1];
            size--;

            heapifyDown();
            return root;

        }


        /// <summary>
        /// called after removing the min element (root) and replacing it with the last element
        /// working on the root element which is at the top of the tree to put it in order and restore heap property
        /// </summary>
        public void heapifyDown()
        {
            int index = 0;
            while (hasLeftChild(index))
            {
                int minValue = GetLeftChild(index);
                int minValueIndex = getLeftChildIndex(index);
                if (hasRightChild(index) && GetRightChild(index) < minValue)
                {
                    minValue = GetRightChild(index);
                    minValueIndex = getRightChildIndex(index);
                }
                if (items[index] < minValue) break;  // heap property
                else
                {
                    swap(minValueIndex, index);
                }
                index = minValueIndex;
            }
        }

        /// <summary>
        /// heapify up after adding an element so we will work on it
        /// </summary>
        public void heapifyUp()
        {
            int index = size - 1;
            while (hasParent(index) && items[index] < GetParent(index))
            {
                swap(index, getParentIndex(index));
                index = getParentIndex(index);
            }
        }
    }
}
