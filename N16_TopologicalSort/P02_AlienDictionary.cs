// Alien Dictionary
// ================
//
// You are given a list of `words` written in an alien language, where the words are sorted lexicographically by the
// rules of this language. Surprisingly, the aliens also use English lowercase letters, but possibly in a different
// order.
//
// Given a list of `words` written in the alien language, return a string of unique letters sorted in the
// lexicographical order of the alien language as derived from the list of words.
//
// If there's no solution, that is, no valid lexicographical ordering, you can return an empty string `""`.
//
// If multiple valid orderings exist, you may return any of them.
//
// > Note: A string, `a`, is considered lexicographically smaller than string `b` if:
//
// > 1. At the first position where they differ, the character in `a` comes before the character in `b` in the alien
// >    alphabet.
//
// > 2. If one string is a prefix of the other, the shorter string is considered smaller.
//
// Constraints:
//
// - 1 ≤ `words.length` ≤ 10^3
// - 1 ≤ `words[i].length` ≤ 20
// - All characters in `words[i]` are English lowercase letters.

using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N16_TopologicalSort.P02_AlienDictionary;

public class Solution
{
    public static string AlienOrder(string[] words)
    {
        var graph = new Dictionary<char, HashSet<char>>();
        var inDegrees = new Dictionary<char, int>();

        foreach (string word in words)
        {
            foreach (char ch in word)
            {
                graph.TryAdd(ch, new HashSet<char>());
                inDegrees.TryAdd(ch, 0);
            }
        }

        for (int i = 0; i != words.Length - 1; i++)
        {
            string word1 = words[i];
            string word2 = words[i + 1];

            int j;
            for (j = 0; j != word1.Length; j++)
            {
                char ch1 = word1[j];
                char ch2 = word2[j];

                if (ch1 != ch2)
                {
                    if (graph[ch1].Add(ch2))
                    {
                        inDegrees[ch2]++;
                    }

                    break;
                }
                else if (j == word2.Length - 1) // Word followed by its prefix.
                {
                    return "";
                }
            }
        }

        var queue = new Queue<char>();
        foreach ((char ch, int degree) in inDegrees)
        {
            if (degree == 0)
            {
                queue.Enqueue(ch);
            }
        }

        var order = new List<char>();
        while (queue.Count != 0)
        {
            char ch1 = queue.Dequeue();
            order.Add(ch1);

            foreach (char ch2 in graph[ch1])
            {
                inDegrees[ch2]--;
                if (inDegrees[ch2] == 0)
                {
                    queue.Enqueue(ch2);
                }
            }
        }

        return order.Count == inDegrees.Count ? new string(order.ToArray()) : "";
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run(["ab", "bc", "cd"], "adbc"); // Multiple valid orders.
        Run(["ab", "abc", "abd", "bc", "cb", "da"], "abcd"); // Single valid order.
        Run(["ab", "ac", "cb", "bc"], ""); // No valid order.
    }

    private static void Run(string[] words, string expectedResult)
    {
        string result = Solution.AlienOrder(words);
        Utilities.PrintSolution(words, result);
        Assert.AreEqual(expectedResult, result);
    }
}
