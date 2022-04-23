using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.DataStructure.Trie
{

    public class TrieNodeAmazon
    {
        public bool endOfWord;
        public Dictionary<char, TrieNodeAmazon> children;
        public TrieNodeAmazon()
        {

            children = new Dictionary<char, TrieNodeAmazon>();

        }

    }
    public class TrieAmazon
    {
        TrieNodeAmazon root;
        public TrieAmazon()
        {
            root = new TrieNodeAmazon();
        }
        public void Insert(string word)
        {
            var curr = root;
            foreach (var c in word)
            {
                if (!curr.children.TryGetValue(c, out var val))
                    curr.children.Add(c, new TrieNodeAmazon());
                curr = curr.children[c];
            }
            curr.endOfWord = true;
        }
        public List<string> AutoComplete(string word)
        {
            if (word.Length < 2) return null;
            var curr = root;
            var res = new List<string>();
            foreach (var c in word)
            {
                if (!curr.children.TryGetValue(c, out var val))
                    return res;
                curr = curr.children[c];
            }
            var s = new Stack<(string, TrieNodeAmazon)>();
            s.Push((word, curr));
            while (s.Count != 0)
            {
                (string currWord, TrieNodeAmazon currNode) = s.Pop();
                if (currNode.endOfWord) res.Add(currWord);
                foreach (var child in currNode.children)
                {
                    // child is key value pair <char, TrieNodeAmazon>
                    s.Push((currWord + child.Key, child.Value));

                }


            }
            return res;

        }
    

    }

   

}
