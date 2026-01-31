// Longest Common Suffix Queries
// =============================
//
// You are given two arrays of strings, `wordsContainer` and `wordsQuery`.
//
// For each string `wordsQuery[i]`, find the string in `wordsContainer` that shares the longest common suffix with it.
//
// - If multiple strings in `wordsContainer` share the same longest suffix, choose the one with the smallest length.
//
// - If two or more such strings have the same smallest length, choose the string that appears earliest in
//   `wordsContainer`.
//
// Return an array of integers `ans`, where `ans[i]` is the index of the chosen string in `wordsContainer` for the query
// `wordsQuery[i]`.
//
// Constraints:
//
// - 1 ≤ `wordsContainer.length, wordsQuery.length` ≤ 10^4
// - 1 ≤ `wordsContainer[i].length` ≤ 5∗10^3
// - 1 ≤ `wordsQuery[i].length` ≤ 5∗10^3
// - `wordsContainer[i]` consists only of lowercase English letters.
// - `wordsQuery[i]` consists only of lowercase English letters.
// - Sum of `wordsContainer[i].length` is, at most 5∗10^5.
// - Sum of `wordsQuery[i].length` is, at most 5∗10^5.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N23_Trie.P11_LongestCommonSuffixQueries;

public class Solution
{
    private class TrieNode(int wordIndex)
    {
        public TrieNode[] children = new TrieNode[26];
        public int wordIndex = wordIndex;
    }

    // Time complexity: O(c+q), Space complexity: O(c) where c, q are total char lengths of container and query.
    public static int[] StringIndices(string[] wordsContainer, string[] wordsQuery)
    {
        // Construct Trie.
        var root = new TrieNode(0);

        for (int i = 0; i != wordsContainer.Length; i++)
        {
            string word = wordsContainer[i];
            int len = word.Length;

            TrieNode node = root;
            if (len < wordsContainer[node.wordIndex].Length)
            {
                node.wordIndex = i;
            }

            for (int j = len - 1; j != -1; j--)
            {
                node = node.children[word[j] - 'a'] ??= new TrieNode(-1);
                if (node.wordIndex == -1 || len < wordsContainer[node.wordIndex].Length)
                {
                    node.wordIndex = i;
                }
            }
        }

        // Search within Trie.
        var indices = new int[wordsQuery.Length];

        for (int i = 0; i != wordsQuery.Length; i++)
        {
            string word = wordsQuery[i];
            int len = word.Length;

            TrieNode node = root;
            indices[i] = node.wordIndex;

            for (int j = len - 1; j != -1; j--)
            {
                node = node.children[word[j] - 'a'];
                if (node == null) { break; }
                indices[i] = node.wordIndex;
            }
        }

        return indices;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run(["cba", "ba", "a"], ["a", "ca", "cba", "dba", "e"], [2, 2, 0, 1, 2]);
    }

    private static void Run(string[] wordsContainer, string[] wordsQuery, int[] expectedResult)
    {
        int[] result = Solution.StringIndices(wordsContainer, wordsQuery);
        Utilities.PrintSolution((wordsContainer, wordsQuery), result);
        CollectionAssert.AreEqual(expectedResult, result);
    }
}
