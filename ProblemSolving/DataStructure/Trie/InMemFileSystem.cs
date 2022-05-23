using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank.DataStructure.Trie
{
    class InMemFileSystem
    {
        public class TrieNode
        {
            public Dictionary<string, TrieNode> children;
            public bool isFile;
            public string fileContent;
            public TrieNode()
            {
                children = new Dictionary<string, TrieNode>();
                isFile = false;
                fileContent = "";
            }
        }
        public class Trie
        {
            TrieNode root;
            public Trie()
            {
                root = new TrieNode();
            }

            public List<string> ls(string path)
            {
                var res = new List<string>();
                var curr = root;
                var nodesInPath = path.Split('/');
                foreach (var node in nodesInPath)
                {
                    if (node == "") continue;
                    curr = curr.children[node];
                }
                if (curr.isFile)
                {
                    res.Add(nodesInPath[nodesInPath.Length - 1]);
                    return res;
                }
                else
                {
                    var childrenNodes = curr.children.Select(
                x => x.Key).OrderBy(x => x).ToList();
                    foreach (var child in childrenNodes)
                        res.Add(child);
                }
                return res;
            }
            public void mkdir(string path)
            {
                var curr = root;
                var pathNode = path.Split('/');
                foreach (var node in pathNode)
                {
                    if (node == "") continue;
                    if (!curr.children.Keys.Contains(node))
                        curr.children.Add(node, new TrieNode());
                    curr = curr.children[node];

                }

            }
            public void addContentToFile(string path, string content)
            {
                var curr = root;
                var nodesInPath = path.Split('/');
                var n = nodesInPath.Length;

                for (int i = 0; i < n - 1; i++)
                {
                    if (nodesInPath[i] == "") continue;
                    curr = curr.children[nodesInPath[i]];
                }
                if (!curr.children.Keys.Contains(nodesInPath[n - 1]))
                {
                    curr.children.Add(nodesInPath[n - 1], new TrieNode());
                }
                curr = curr.children[nodesInPath[n - 1]];
                curr.fileContent = content;

            }
            public string readContent(string path)
            {
                var curr = root;
                var nodesInPath = path.Split('/');
                foreach (var node in nodesInPath)
                {
                    if (node == "") continue;
                    curr = curr.children[node];

                }
                return curr.fileContent;
            }
        }
        //public static void Main(string[] args)
        //{// [[1,4],[2,3]]
        //    var trie = new Trie();
        //    trie.ls("/");
        //    trie.mkdir("/a/b/c");
        //    trie.addContentToFile("/a/b/c/d", "hello");
        //    var a = trie.ls("/");
        //    var hello = trie.readContent("/a/b/c/d");
        //}
    }
}
