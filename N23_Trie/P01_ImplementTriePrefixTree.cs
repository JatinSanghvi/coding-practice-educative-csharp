// Implement Trie (Prefix Tree)
// ============================
//
// Trie is a tree-like data structure used to store strings. The tries are also called prefix trees because they provide
// very efficient prefix-matching operations. Implement a [trie](https://www.educative.io/answers/what-is-a-prefix-tree)
// data structure with three functions that perform the following tasks:
//
// - Insert (word): This inserts a word into the trie.
// - Search (word): This searches the given word in the trie and returns TRUE, if found. Otherwise, return FALSE.
// - Search prefix (prefix): This searches the given prefix in the trie and returns TRUE, if found. Otherwise, return
//   FALSE.
//
// Constraints:
//
// - 1 ≤ `word.length`, `prefix.length` ≤ 500
// - The strings consist only of lowercase English letters.
// - At most, 10^3 calls in total will be made to the functions.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N23_Trie.P01_ImplementTriePrefixTree;

public class TrieNode(bool isWord)
{
    public bool isWord = isWord;
    public TrieNode[] children = new TrieNode[26];
}

// Space complexity: O(n).
public class Trie()
{
    private readonly TrieNode _root = new TrieNode(false);

    // Time complexity: O(n).
    public void Insert(string word)
    {
        TrieNode node = _root;
        foreach (char ch in word)
        {
            node.children[ch - 'a'] ??= new TrieNode(false);
            node = node.children[ch - 'a'];
        }

        node.isWord = true;
    }

    // Time complexity: O(n).
    public bool Search(string word)
    {
        TrieNode node = _root;

        foreach (char ch in word)
        {
            if (node.children[ch - 'a'] == null) { return false; }
            node = node.children[ch - 'a'];
        }

        return node.isWord;
    }

    // Time complexity: O(n).
    public bool SearchPrefix(string prefix)
    {
        TrieNode node = _root;

        foreach (char ch in prefix)
        {
            if (node.children[ch - 'a'] == null) { return false; }
            node = node.children[ch - 'a'];
        }

        return true;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run(
            ["Insert and", "Search and", "Search an", "SearchPrefix an", "Insert an", "Search an"],
            [null, true, false, true, null, true]);
    }

    private static void Run(string[] operations, bool?[] expectedResult)
    {
        var trie = new Trie();

        for (int i = 0; i != operations.Length; i++)
        {
            string[] operation = operations[i].Split();
            string method = operation[0];
            string argument = operation[1];

            bool? result = null;
            switch (method)
            {
                case "Insert": trie.Insert(argument); break;
                case "Search": result = trie.Search(argument); break;
                case "SearchPrefix": result = trie.SearchPrefix(argument); break;
            }

            Utilities.PrintSolution(operations[i], result);
            Assert.AreEqual(expectedResult[i], result);
        }
    }
}
