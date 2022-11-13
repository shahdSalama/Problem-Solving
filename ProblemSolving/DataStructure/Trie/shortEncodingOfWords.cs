using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.DataStructure.Trie
{
    public class node
    {
        public Dictionary<char, node> children;
        public bool isWord;
        public node()
        {

            children = new Dictionary<char, node>();
        }
    }
    public class trie
    {
        public node root;
        public trie()
        {
            root = new node();
        }
        public void add(string s)
        {

            var curr = root;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (!curr.children.Keys.Contains(s[i]))
                {
                    curr.children.Add(s[i], new node());
                }
                curr = curr.children[s[i]];
            }
            curr.isWord = true;
        }

    }


    public class Solution
    {
        public static int MinimumLengthEncoding(string[] words)
        {
            var trietree = new trie();
            foreach (var word in words)
                trietree.add(word);

            int count = 0;
            count += trietree.root.children.Keys.Count;

            var s = new Stack<node>();
            foreach (var node in trietree.root.children.Values)
                s.Push(node);
            while (s.Count != 0)
            {
                var curr = s.Pop();
                count++;
                foreach (var child in curr.children.Values)
                {
                    s.Push(child);
                }
            }
            return count;
        }

    }
   


}
