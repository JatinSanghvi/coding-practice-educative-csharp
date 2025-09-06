// Find the Lexicographically Largest String From Box II
// =====================================================
//
// You are given a string, `word`, and an integer `numFriends`, representing the number of friends participating in a
// game organized by Alice.
//
// The game consists of multiple rounds, and in each round:
//
// - The string `word` is split into exactly `numFriends` non-empty substrings.
// - The split must be unique; no previous round has produced the same sequence of splits.
// - All resulting substrings from the split are placed into a box.
//
// When all rounds are over and all possible unique splits have been performed, determine the lexicographically largest
// string among all the substrings in the box.
//
// > A string a is considered lexicographically larger than a string b if:
// > - At the first position where a and b differ, the character in a comes later than the corresponding character in b
// >   in the alphabet.
// > - If a is a prefix of b, the longer string is considered larger.
//
// Constraints:
//
// - 1 ≤ `word.length` ≤ 10^3
// - `word` consists only of lowercase English letters.
// - 1 ≤ `numFriends` ≤ `word.length`

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N02_TwoPointers.P14_FindTheLexicographicallyLargestStringFromBoxII;

public class Solution
{
    // Time complexity: O(n^2), Space complexity: O(1).
    // There is another algorithm with theoretically better time complexity, but it's too complex.
    public static string AnswerString(string word, int numFriends)
    {
        if (numFriends == 1)
        {
            return word;
        }

        int maxLength = word.Length - numFriends + 1;
        string maxSplit = string.Empty;

        for (int start = 0; start < word.Length; start++)
        {
            int end = Math.Min(start + maxLength, word.Length);
            string split = word[start..end]; // Consumes fixed amount of memory.

            if (string.CompareOrdinal(maxSplit, split) < 0)
            {
                maxSplit = split;
            }
        }

        return maxSplit;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run("abc", 1, "abc");
        Run("abc", 2, "c");
        Run("cacbca", 3, "cbca");
        Run("cacbca", 4, "cbc");
    }

    private static void Run(string word, int numFriends, string expectedResult)
    {
        string result = Solution.AnswerString(word, numFriends);
        Utilities.PrintSolution((word, numFriends), result);
        Assert.AreEqual(expectedResult, result);
    }
}
