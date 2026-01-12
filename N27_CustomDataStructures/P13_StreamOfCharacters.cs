// Stream of Characters
// ====================
//
// Design a data structure that processes a stream of characters and, after each character is received, determines if a
// suffix of these characters is a string in a given array of strings `words`.
//
// For example, if `words` = ["cat", "dog"] and the stream adds the characters 'd', 'c', 'a', and 't' in sequence, the
// algorithm should detect that the suffix "cat" of the stream "dcat" matches the word "cat" from the list.
//
// So, for `words`, the goal is to detect if any of these words appear as a suffix of the stream built so far. To
// accomplish this, implement a class `StreamChecker`:
//
// - Constructor: Initializes the object with the list of target `words`.
//
// - boolean query(char letter): Appends a character to the stream and returns TRUE if any suffix of the stream matches
//   a word in the list `words`.
//
// Constraints:
//
// - 1 ≤ `words.length` ≤ 1000
// - 1 ≤ `words[i].length` ≤ 200
// - `words[i]` consists of lowercase English letters.
// - `letter` is a lowercase English letter.
// - At most 4 × 10^2 calls will be made to query.

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N27_CustomDataStructures.P13_StreamOfCharacters;

// Space complexity: O(w*l + s) where w = word count, l = average word length, s = stream length.
public class StreamChecker
{
    private class TrieNode
    {
        public bool isWord = false;
        public TrieNode[] children = new TrieNode[26];
    }

    private readonly TrieNode root = new();
    private readonly Stack<char> stream = new();

    // Time complexity: O(w*l).
    public StreamChecker(string[] words)
    {
        // Prepare a trie by inserting each word in reversed letter order. 
        foreach (string word in words)
        {
            TrieNode node = root;
            foreach (char ch in word.Reverse())
            {
                node = node.children[ch - 'a'] ??= new TrieNode();
            }

            node.isWord = true;
        }
    }

    // Time complexity: O(l) where l = maximum word length.
    public bool Query(char letter)
    {
        stream.Push(letter);

        TrieNode node = root;
        foreach (char ch in stream)
        {
            node = node.children[ch - 'a'];
            if (node == null) { return false; }
            if (node.isWord) { return true; }
        }

        return false;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run(["ab", "abc", "cde"], "abcde", [false, true, true, false, true]);
    }

    private static void Run(string[] words, string letters, bool[] expectedResults)
    {
        var streamChecker = new StreamChecker(words);

        for (int i = 0; i != letters.Length; i++)
        {
            bool result = streamChecker.Query(letters[i]);
            Utilities.PrintSolution(letters[i], result);
            Assert.AreEqual(expectedResults[i], result);
        }
    }
}
