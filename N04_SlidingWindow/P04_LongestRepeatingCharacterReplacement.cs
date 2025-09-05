// Longest Repeating Character Replacement
// =======================================
//
// Given a string, `s`, and an integer, `k`, find the length of the longest substring in `s`, where all characters are
// identical, after replacing, at most, `k` characters with any other uppercase English character.
//
// Constraints:
//
// - 1 ≤ `s.length` ≤ 10^3
// - `s` consists of only uppercase English characters.
// - 0 ≤ `k` ≤ `s.length`

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N04_SlidingWindow.P04_LongestRepeatingCharacterReplacement;

public class Solution
{
    public static int LongestRepeatingCharacterReplacement(string s, int k)
    {
        var charCounts = new Dictionary<char, int>();
        int maxCount = 0;
        int longestLen = 0;
        int currentLen = 0;

        for (int i = 0; i < s.Length; i++)
        {
            charCounts.TryAdd(s[i], 0);
            charCounts[s[i]]++;
            currentLen++;

            // Unintuitive optimization: Maximum count of character across all windows seen so far.
            maxCount = Math.Max(maxCount, charCounts[s[i]]);
            if (currentLen - maxCount > k)
            {
                currentLen--;
                charCounts[s[i - currentLen]]--;
            }

            longestLen = Math.Max(longestLen, currentLen);
        }

        return longestLen;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run("A", 0, 1);
        Run("ABBAAABBBB", 0, 4);
        Run("ABBAAABBBB", 2, 6);
        Run("ABBAAABBBB", 3, 9);
    }

    private static void Run(string s, int k, int expectedResult)
    {
        int result = Solution.LongestRepeatingCharacterReplacement(s, k);
        Utilities.PrintSolution((s, k), result);
        Assert.AreEqual(expectedResult, result);
    }
}
