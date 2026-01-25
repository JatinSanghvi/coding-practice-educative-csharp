// Longest Happy Prefix
// ====================
//
// Given a string, `s`, find the longest happy prefix. If no such prefix exists, return an empty string `""`.
//
// > Note: A happy prefix of a string is a non-empty substring at the beginning that also appears at the end (but not
// > the entire string itself).
//
// Constraints:
//
// - 1 ≤ `s.length` ≤ 10^5
// - `s` contains only lowercase English letters.

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N24_HashMaps.P16_LongestHappyPrefix;

public class Solution
{
    // Time complexity: O(n), Space complexity: O(1).
    public string LongestPrefix(string s)
    {
        uint mod = 100_000_007;
        uint basePower = 1;
        uint prefixHash = 0;
        uint suffixHash = 0;

        int len = s.Length;
        int longestLen = 0;

        for (int i = 0, j = len - 1; i != len - 1; i++, j--)
        {
            uint iVal = (uint)(s[i] - 'a');
            uint jVal = (uint)(s[j] - 'a');

            prefixHash = (prefixHash * 26 + iVal) % mod;
            suffixHash = (jVal * basePower + suffixHash) % mod;
            basePower = (basePower * 26) % mod;

            // Can return a false-positive 1 in 100 million times.
            if (prefixHash == suffixHash)
            {
                longestLen = i + 1;
            }
        }

        return s[..longestLen];
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run("ab", "");
        Run("aba", "a");
        Run("abab", "ab");
        Run("ababa", "aba");
        Run("aaabbbaaabbbaaa", "aaabbbaaa");
    }

    private static void Run(string s, string expectedResult)
    {
        string result = new Solution().LongestPrefix(s);
        Utilities.PrintSolution(s, result);
        Assert.AreEqual(expectedResult, result);
    }
}
