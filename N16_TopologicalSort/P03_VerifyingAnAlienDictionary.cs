// Verifying an Alien Dictionary
// =============================
//
// In an alien language, the alphabet consists of the same lowercase English letters but arranged in a different order.
//
// Given a list of words, `words`, written in this alien language, and a string `order` representing the order of the
// alien alphabet (as a permutation of lowercase letters), return TRUE if the words are sorted lexicographically
// according to `order`; otherwise, return FALSE.
//
// > Note: A word `a` is considered lexicographically smaller than word `b` if:
//
// > - At the first position where the two words differ, the character in `a` comes before the character in `b` in the
// >   given `order` string.
//
// > - If one word is a prefix of the other (and all compared characters are the same), then the shorter word is
// >   considered smaller.
//
// Constraints:
//
// - 1 ≤ `words.length` ≤ 10^3
// - 1 ≤ `words[i].length` ≤ 20
// - `order.length` == 26
// - All the characters in `words[i]` and `order` are lowercase English letters.

using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N16_TopologicalSort.P03_VerifyingAnAlienDictionary;

public class Solution
{
    // Time complexity: O(w*m), Space complexity: O(1) where m = word-size limit.
    public static bool VerifyAlienDictionary(string[] words, string order)
    {
        var ranks = new Dictionary<char, int>();
        for (int i = 0; i != 26; i++)
        {
            ranks[order[i]] = i;
        }

        for (int i = 0; i != words.Length - 1; i++)
        {
            for (int j = 0; j != words[i].Length; j++)
            {
                if (j == words[i + 1].Length) { return false; }

                char ch1 = words[i][j], ch2 = words[i + 1][j];
                if (ch1 != ch2)
                {
                    if (ranks[ch1] >= ranks[ch2]) { return false; }
                    break;
                }
            }
        }

        return true;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run(["bad", "bcd", "ca", "cab"], "abcdefghijklmnopqrstuvwxyz", true);
        Run(["bad", "bcd", "cab", "ca"], "abcdefghijklmnopqrstuvwxyz", false);
        Run(["bcd", "bad", "ca", "cab"], "abcdefghijklmnopqrstuvwxyz", false);
    }

    private static void Run(string[] words, string order, bool expectedResult)
    {
        bool result = Solution.VerifyAlienDictionary(words, order);
        Utilities.PrintSolution((words, order), result);
        Assert.AreEqual(expectedResult, result);
    }
}
