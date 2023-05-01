using System;
using System.Collections.Generic;

public class SuffixTrieConstruction
{
    // Do not edit the class below except for the
    // PopulateSuffixTrieFrom and Contains methods.
    // Feel free to add new properties and methods
    // to the class.
    public class TrieNode
    {
        public Dictionary<char, TrieNode> Children = new Dictionary<char, TrieNode>();
    }

    public class SuffixTrie
    {
        public TrieNode root = new TrieNode();
        public char endSymbol = '*';

        public SuffixTrie(string str)
        {
            PopulateSuffixTrieFrom(str);
        }

        public void PopulateSuffixTrieFrom(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                InsertSubstringStartingAt(i, str);
            }
        }

        public void InsertSubstringStartingAt(int i, string str)
        {
            TrieNode node = root;
            for (int j = i; j < str.Length; j++)
            {
                char c = str[j];
                if (!node.Children.ContainsKey(c))
                {
                    node.Children[c] = new TrieNode();
                }
                node = node.Children[c];
            }
            node.Children[endSymbol] = null; // Mark end of the substring
        }

        public bool Contains(string str)
        {
            TrieNode node = root;
            foreach (char c in str)
            {
                if (!node.Children.ContainsKey(c))
                {
                    return false;
                }
                node = node.Children[c];
            }
            return node.Children.ContainsKey(endSymbol);
        }
    }
}
