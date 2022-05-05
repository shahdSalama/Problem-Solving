using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.MeduimChallenges
{
    public class Node
    {
        public int data;
        public int _key;
        public Node prev;
        public Node next;
 
        public Node(int key, int value)
        {
            _key = key;
            data = value;
            prev = null; next = null;
        }
    }
    public class LRUCache
    {
        Dictionary<int, Node> dic;
        int capacity;
        int count;
        Node left; Node right;

        public LRUCache(int size)
        {
            dic = new Dictionary<int, Node>();
            capacity = size;
            count = 0;
            left = new Node(0, 0);
            right = new Node(0, 0);
            left.next = right;
            right.prev = left;
        }

        public int Get(int key)
        {
            if (!dic.TryGetValue(key, out var _)) return -1;
            var resultNode = dic[key];

            // make sure to mark it as used
            Remove(resultNode);
            Add(resultNode);

            return resultNode.data;
        }

        public void Put(int key, int value)
        {
            // if key exists
            if (dic.TryGetValue(key, out Node node))
            {
                node.data = value;
                Remove(node);
                Add(node);
            }
            else // new key
            {
                var newNode = new Node(key, value);
                Add(newNode);
                dic.Add(key, newNode);
                count++;
            }
            if (count > capacity)
            {
                Evict();
                count--;
            }
        }

        private void Add(Node node)
        {
            var prev = right.prev;
            right.prev = node;
            node.next = right;
            node.prev = prev;
            prev.next = node;
        }

        private void Remove(Node node)
        {   // -  x =  x =  x -

            node.prev.next = node.next;
            node.next.prev = node.prev;

        }

        private void Evict()
        {
            var first = left.next;
            Remove(first);
            dic.Remove(first._key);
        }
    }
        

    }



