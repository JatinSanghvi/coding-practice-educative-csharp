// Search Suggestions System
// =========================
//
// Given an array of strings called `products` and a word to search, design a system that, when each character of the
// searched word is typed, suggests at most three product names from `products`. Suggested products should share a
// common prefix with the searched word. If more than three products exist with a common prefix, return the three
// product names that appear first in lexicographical order.
//
// Return the suggested products, which will be a list of lists after each character of searched word is typed.
//
// Constraints:
//
// - 1 ≤ `products.length` ≤ 1000
// - 1 ≤ `products[i].length` ≤ 3000
// - 1 ≤ `sum(products[i].length)` ≤ 2×10^3
// - All the strings of products are unique.
// - `products[i]` consists of lowercase English letters.
// - 1 ≤ `searched word.length` ≤ 1000
// - The searched word consists of lowercase English letters.

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N23_Trie.P02_SearchSuggestionsSystem;

public class Solution
{
    // Time complexity: O(n*l*logn + s), Space complexity: O(n*l).
     // where n:product-count, l:avg-word-length, s:search-word-length.
    public static IList<IList<string>> SuggestedProducts(string[] products, string searchWord)
    {
        var root = new TrieNode();

        Array.Sort(products);
        foreach (string product in products)
        {
            TrieNode node = root;
            foreach (char ch in product)
            {
                node = node.children[ch - 'a'] ??= new TrieNode();
                if (node.words.Count != 3)
                {
                    node.words.Add(product);
                }
            }
        }

        var suggested = new List<IList<string>>();
        TrieNode node2 = root;
        foreach (char ch in searchWord)
        {
            node2 = node2?.children[ch - 'a'];
            suggested.Add(node2?.words ?? new List<string>());
        }

        return suggested;
    }
}

internal class TrieNode()
{
    public TrieNode[] children = new TrieNode[26];
    public List<string> words = new List<string>();
}

internal static class Tests
{
    public static void Run()
    {
        Run(["bib", "bag", "ball", "bill", "balm", "bat", "bow"], "bone", [["bag", "ball", "balm"], ["bow"], [], []]);
    }

    private static void Run(string[] products, string searchWord, string[][] expectedResult)
    {
        string[][] result = Solution.SuggestedProducts(products, searchWord)
            .Select(res => res.ToArray())
            .ToArray();

        Utilities.PrintSolution((products, searchWord), result);
        CollectionAssert.AreEqual(expectedResult, result);
    }
}
