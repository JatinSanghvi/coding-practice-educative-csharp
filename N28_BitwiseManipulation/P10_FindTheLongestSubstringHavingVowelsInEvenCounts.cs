// Find the Longest Substring Having Vowels in Even Counts
// =======================================================
//
// Given the string `s`, return the length of the longest substring in which each vowel — a, e, i, o, and u — appears an
// even number of times.
//
// Constraints:
//
// - 1 ≤ `s.length` ≤ 5 × 10^3
// - `s` contains only lowercase English letters.

using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N28_BitwiseManipulation.P10_FindTheLongestSubstringHavingVowelsInEvenCounts;

public class Solution
{
    // Time complexity: O(n), Space complexity: O(1) since there can be at most 32 elements in dictionary.
    public static int FindLongestSubstring(string s)
    {
        var minIndexes = new Dictionary<int, int> { [0] = -1 };
        int longest = 0;
        int hash = 0;

        for (int index = 0; index != s.Length; index++)
        {
            char ch = s[index];

            int bit = ch switch
            {
                'a' => 0x01,
                'e' => 0x02,
                'i' => 0x04,
                'o' => 0x08,
                'u' => 0x10,
                _ => 0x00,
            };

            hash ^= bit;
            if (minIndexes.TryGetValue(hash, out int minIndex))
            {
                longest = Math.Max(longest, index - minIndex);
            }
            else
            {
                minIndexes[hash] = index;
            }
        }

        return longest;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run("bababebeb", 9);
        Run("babababebebeb", 9);
    }

    private static void Run(string s, int expectedResult)
    {
        int result = Solution.FindLongestSubstring(s);
        Utilities.PrintSolution(s, result);
        Assert.AreEqual(expectedResult, result);
    }
}
