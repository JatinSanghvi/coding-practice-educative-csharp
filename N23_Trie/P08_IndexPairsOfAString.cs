// Index Pairs of a String
// =======================
//
// Given a string `text` and an array of strings `words`, return a list of all index pairs `[i, j]` such that the
// substring `text[i...j]` is present in `words`.
//
// Return the pairs `[i, j]` in a sorted order, first by the value of `i`, and if two pairs have the same `i`, by the
// value of `j`.
//
// Constraints:
//
// - 1 ≤ `text.length` ≤ 100
// - 1 ≤ `words.length` ≤ 20
// - 1 ≤ `words[i].length` ≤ 50
// - `text` and `words[i]` consist of lowercase English letters.
// - All the strings of `words` are unique.

using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N23_Trie.P08_IndexPairsOfAString;

public class Solution
{
    private class TrieNode
    {
        public bool isLeaf;
        public TrieNode[] children = new TrieNode[26];
    }

    // Time complexity: O(t*l), Space complexity: O(w*l)
    // , where t = text length, w = number of words, l = average word length. 
    public static int[][] IndexPairs(string text, string[] words)
    {
        var root = new TrieNode();

        foreach (string word in words)
        {
            TrieNode node = root;
            foreach (char ch in word)
            {
                node = node.children[ch - 'a'] ??= new TrieNode();
            }

            node.isLeaf = true;
        }

        var indexes = new List<int[]>();
        for (int i = 0; i != text.Length; i++)
        {
            TrieNode node = root;
            for (int j = i; j != text.Length; j++)
            {
                node = node.children[text[j] - 'a'];
                if (node == null) { break; }
                if (node.isLeaf) { indexes.Add([i, j]); }
            }
        }

        return indexes.ToArray();
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run("ababab", ["ab", "aba", "abb"], [[0, 1], [0, 2], [2, 3], [2, 4], [4, 5]]);
    }

    private static void Run(string text, string[] words, int[][] expectedResult)
    {
        int[][] result = Solution.IndexPairs(text, words);
        Utilities.PrintSolution((text, words), result);
        CollectionAssert.AreEqual(expectedResult, result);
    }
}
