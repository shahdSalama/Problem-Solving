using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.DataStructure.Trie
{
    public class TrieNode
    {
        public bool endOfWord;
        public Dictionary<char, TrieNode> children;
        public TrieNode()
        {
            children = new Dictionary<char, TrieNode>();
        }

    }




    public class Trie
    {

        TrieNode root;
        public Trie()
        {
            root = new TrieNode();

        }
        public List<string> Autocomplete(string word)
        {
            var res = new List<string>();
            var curr = root;
            foreach (var c in word)
            {   // current letter is not a child
                if (!curr.children.TryGetValue(c, out var val))
                    return res;
                curr = curr.children[c];
            }
            var s = new Stack<(string, TrieNode)>();
            s.Push((word, curr));
            while (s.Count != 0)
            {
                (string currPrefix, TrieNode currNode) = s.Pop();
                if (currNode.endOfWord) res.Add(currPrefix);

                foreach (var child in currNode.children)
                    s.Push((currPrefix + child.Key, child.Value));
            }
            return res;
        }


        public void Insert(string word)
        {
            var curr = root;
            foreach (var c in word)
            {
                if (!curr.children.TryGetValue(c, out TrieNode val))
                    curr.children.Add(c, new TrieNode());

                curr = curr.children[c];
            }
            curr.endOfWord = true;
        }
        public bool Search(string word)
        {
            var curr = root;
            foreach (var c in word)
            {
                if (!curr.children.TryGetValue(c, out TrieNode val))
                    return false;
                else curr = curr.children[c];
            }
            if (!curr.endOfWord) return false;
            return true;
        }
        public bool StartsWith(string word)
        {
            var curr = root;
            foreach (var c in word)
            {
                if (!curr.children.TryGetValue(c, out var val)) return false;
                else curr = curr.children[c];
            }
            return true;

        }

        /*["Trie","insert","search","search","startsWith","insert","search"]
          [[],    ["apple"],["apple"],["app"],["app"]     ,["app"],["app"]]*/

        
    }
}
