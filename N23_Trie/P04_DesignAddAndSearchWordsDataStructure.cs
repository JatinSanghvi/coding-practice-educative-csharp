// Design Add and Search Words Data Structure
// ==========================================
//
// Design a data structure called WordDictionary that supports the following functionalities:
//
// - Constructor: This function will initialize the object.
//
// - Add Word(word): This function will store the provided word in the data structure.
//
// - Search Word(word): This function will return TRUE if any string in the WordDictionary object matches the query
//   word. Otherwise, it will return FALSE. If the query word contains dots, `.`, each dot is free to match any letter
//   of the alphabet.
//
//     For example, the dot in the string ".ad" can have 26 possible search results like "aad", "bad", "cad", and so on.
//
// - Get Words(): This function will return all the words in the WordDictionary class.
//
// Constraints:
//
// - 1 ≤ `word.length` ≤ 25
// - Words passed to Add Word() consist of lowercase English letters.
// - Words passed to Search Word() consist of `.` or lowercase English letters.
// - There will be, at most, three dots in a word passed to Search Word().
// - At most, 10^3 calls will be made to Add Word() and Search Word().

using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N23_Trie.P04_DesignAddAndSearchWordsDataStructure;

// Space complexity: O(w*l) where l = average lengths of words.
public class WordDictionary
{
    private TrieNode2 root = new TrieNode2();

    // Time complexity: O(l).
    public void AddWord(string word)
    {
        TrieNode2 node = root;
        foreach (char letter in word)
        {
            node = (node.children[letter - 'a'] ??= new TrieNode2());
        }

        node.isLeaf = true;
    }

    // Time complexity: O(w*l)).
    public List<string> GetWords()
    {
        var words = new List<string>();
        var letters = new char[25];
        Visit(root, 0);
        return words;

        void Visit(TrieNode2 node, int len)
        {
            if (node.isLeaf)
            {
                words.Add(new string(letters[..len]));
            }

            for (int i = 0; i != 26; i++)
            {
                if (node.children[i] != null)
                {
                    letters[len] = (char)(i + 'a');
                    Visit(node.children[i], len + 1);
                }
            }
        }
    }

    // Time complexity: O(26^l).
    public bool Search(string word)
    {
        return Search(root, 0);

        bool Search(TrieNode2 node, int i)
        {
            if (i == word.Length) { return node.isLeaf; }

            var children = new List<TrieNode2>();
            for (int j = 0; j != 26; j++)
            {
                int letter = (char)(j + 'a');
                if (node.children[j] != null && (word[i] == '.' || word[i] == letter) && Search(node.children[j], i + 1))
                {
                    return true;
                }
            }

            return false;
        }
    }
}

public class TrieNode2
{
    public bool isLeaf;
    public TrieNode2[] children = new TrieNode2[26];
}

internal static class Tests
{
    public static void Run()
    {
        Run(
            ["Search .nd", "Add and", "Search .nd", "Search an", "Add an", "Search an", "Search ....", "Add end", "Add add", "Get"],
            [false, null, true, false, null, true, false, null, null, new[] { "add", "an", "and", "end" }]);
    }

    private static void Run(string[] operations, object[] expectedResult)
    {
        var dictionary = new WordDictionary();

        for (int i = 0; i != operations.Length; i++)
        {
            string[] tokens = operations[i].Split(' ');
            switch (tokens[0])
            {
                case "Add":
                    dictionary.AddWord(tokens[1]);
                    break;
                case "Get":
                    List<string> result = dictionary.GetWords();
                    Utilities.PrintSolution(operations[i], result);
                    CollectionAssert.AreEqual((string[])expectedResult[i], result);
                    break;
                case "Search":
                    bool result1 = dictionary.Search(tokens[1]);
                    Utilities.PrintSolution(operations[i], result1);
                    Assert.AreEqual((bool)expectedResult[i], result1);
                    break;
            }
        }
    }
}
