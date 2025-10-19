// Replace Words
// =============
//
// In this problem, we are considering the words that are composed of a prefix and a postfix. For example, if we append
// a postfix "happy" to a prefix "un", it forms the word "unhappy". Similarly, "disagree" is formed from a prefix, "dis"
// followed by a postfix, "agree".
//
// You're given a dictionary, `dictionary`, consisting of prefixes, and a sentence, `sentence`, which has words
// separated by spaces only. Your task is to replace the postfix in `sentence` with their prefixes given in `dictionary`
// (if found) and return the modified sentence.
//
// A couple of points to keep in mind:
//
// - If a postfix in the sentence matches more than one prefix in the dictionary, replace it with the prefix that has
//   the shortest length. For example, if we have the sentence "iphone is amazing", and the dictionary {"i", "ip",
//   "hone"}, then the word "iphone" has two prefixes in the dictionary "i" and "ip", but we will replace it with the
//   one that is shorter among the two, that is, "i".
//
// - If there is no root word against any word in the sentence, leave it unchanged.
//
// Constraints:
//
// - 1 ≤ `dictionary.length` ≤ 1000
// - 1 ≤ `dictionary[i].length` ≤ 100
// - `dictionary[i]` consists of only lowercase letters.
// - 1 ≤ `sentence.length` ≤ 10^3
// - The number of words in `sentence` is in the range [1,100].
// - The length of each word in `sentence` is in the range [1,100].
// - Two consecutive words in `sentence` should be separated by exactly one space.
// - All words in `sentence` are lowercase.
// - For a word in `sentence`, the length of a prefix can be [1,100], and the length of a postfix can be [0,100].

using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N23_Trie.P03_ReplaceWords;

public class Solution
{
    // Time complexity: O(d+s), Space complexity: O(d+s) where l = average word length;
    public string ReplaceWords(string sentence, IList<string> dictionary)
    {
        var trie = new TrieNode();

        // Construct trie from dictionary.
        foreach (string word in dictionary)
        {
            TrieNode node = trie;
            foreach (char letter in word)
            {
                node = (node.children[letter - 'a'] ??= new TrieNode());
            }

            node.isPrefix = true;
        }

        // Use tried to construct string with replaced words.
        var replacedWords = new List<string>();
        string[] words = sentence.Split(' ');
        foreach (string word in words)
        {
            TrieNode node = trie;
            int length = 0;

            foreach (char letter in word)
            {
                node = node.children[letter - 'a'];
                length++;

                if (node == null)
                {
                    replacedWords.Add(word);
                    break;
                }
                else if (node.isPrefix)
                {
                    replacedWords.Add(word[..length]);
                    break;
                }
            }
        }

        return string.Join(' ', replacedWords);
    }
}

public class TrieNode
{
    public bool isPrefix;
    public TrieNode[] children = new TrieNode[26];
}

internal static class Tests
{
    public static void Run()
    {
        Run("the quick brown fox", ["the", "quic", "qui", "f"], "the qui brown f");
    }

    private static void Run(string sentence, IList<string> dictionary, string expectedResult)
    {
        string result = new Solution().ReplaceWords(sentence, dictionary);
        Utilities.PrintSolution((sentence, dictionary), result);
        Assert.AreEqual(expectedResult, result);
    }
}
