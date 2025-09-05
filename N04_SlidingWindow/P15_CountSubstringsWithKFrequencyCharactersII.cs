// Count Substrings With K-Frequency Characters II
// ==============================================
//
// Given a string `s` and an integer `k`, return the total number of substrings of `s` where at least one character
// appears at least `k` times.
//
// > Note: A substring is a contiguous sequence of characters within a string. For example, "edu" is a substring of
// "educative".
//
// Constraints:
//
// - 1 ≤ `s.length` ≤ 3×10^3
// - 1 ≤ `k` ≤ `s.length`
// - `s` consists only of lowercase English letters.

using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N04_SlidingWindow.P15_CountSubstringsWithKFrequencyCharactersII;

public class Solution
{
    public long NumberOfSubstrings(string s, int k)
    {
        int substrings = 0;

        var charCounts = new Dictionary<char, int>();

        int start = 0;
        for (int end = 0; end < s.Length; end++)
        {
            char ch = s[end];
            charCounts.TryAdd(ch, 0);
            charCounts[ch]++;

            if (charCounts[ch] == k)
            {
                while (charCounts[ch] == k)
                {
                    charCounts[s[start]]--;
                    start++;
                }
            }

            // All substrings starting from index 0 to 'start-1', and ending at index 'end'.
            substrings += start;
        }

        return substrings;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run("abcba", 1, 15);
        Run("abcba", 2, 4);
        Run("abcba", 3, 0);
    }

    private static void Run(string s, int k, long expectedResult)
    {
        long result = new Solution().NumberOfSubstrings(s, k);
        Utilities.PrintSolution((s, k), result);
        Assert.AreEqual(expectedResult, result);
    }
}
