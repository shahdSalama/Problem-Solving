using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.DataStructure.Trie
{
    public class TrieNodeDot
    {
        public Dictionary<char, TrieNodeDot> children;
        public bool isword;
        public TrieNodeDot()
        {
            children = new Dictionary<char, TrieNodeDot>();
            isword = false;
        }
    }


    public class WordDictionary
    {

        TrieNodeDot root;
        public WordDictionary()
        {
            root = new TrieNodeDot();
        }

        public void AddWord(string word)
        {
            var curr = root;
            foreach (var c in word)
            {
                if (!curr.children.Keys.Contains(c))
                    curr.children.Add(c, new TrieNodeDot());
                curr = curr.children[c];
            }
            curr.isword = true;
        }
        //..b    false
        //b..    true
        public bool Search(string word)
        {
            var s = new Stack<(TrieNodeDot, int)>();
            s.Push((root, 0));
            while (s.Count != 0)
            {
                (var currNode, int i) = s.Pop();
                if (i == word.Length - 1)
                {
                    if (currNode.children.Keys.Contains(word[i]) && currNode.children[word[i]].isword) return true;
                    if (word[i] == '.' && currNode.children.Keys.Count != 0 && currNode.children.Any(x => x.Value.isword == true)) return true;
                    continue;
           
                }
                if (word[i] == '.')
                    foreach (var child in currNode.children.Values)
                    {
                        s.Push((child, i + 1));
                    }
                else
                {
                    if (currNode.children.Keys.Contains(word[i]))
                        s.Push((currNode.children[word[i]], i + 1));
                    else return false;
                }
            }
            return false;
        }


        //public static void Main(string[] args)
        //{/*["","","","","","","","","","","search","search","search","search"]
        //   [,[""],[""],[""],[""],[""],[""],[""],[""],[""],["a.d."],["b."],["a.d"],["."]]*/
        //    var worddic = new WordDictionary();
        //    worddic.AddWord("at");
        //    worddic.AddWord("and");
        //    worddic.AddWord("an");
        //    worddic.AddWord("add");
        //    var x = worddic.Search("a"); // false
        //    var m = worddic.Search(".at"); // false
        //    worddic.AddWord("bat");
        //    var mm = worddic.Search(".at"); // true
        //    var mmm = worddic.Search(".an"); // f
        //    var mjm = worddic.Search("a.d."); // f
        //    var mjkkm = worddic.Search("b."); // f
        //    var xjjj = worddic.Search("a.d");  //true
        //    var l = worddic.Search(".");// f

        //   var c = worddic.Search("..b");// false
        //   var lojkojm = worddic.Search("..d");// true
        //}
    }

    /**
     * Your WordDictionary object will be instantiated and called as such:
     * WordDictionary obj = new WordDictionary();
     * obj.AddWord(word);
     * bool param_2 = obj.Search(word);
     */
}
