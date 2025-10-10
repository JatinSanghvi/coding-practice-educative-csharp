// Valid Anagram
// =============
//
// Given two strings, `str1` and `str2`, check whether `str2` is an anagram of `str1`.
//
// An anagram is a word or phrase created by rearranging the letters of another word or phrase while utilizing each of
// the original letters exactly once.
//
// Constraints:
//
// - 1 ≤ `str1.length`, `str2.length` ≤ 10^3
// - `str1` and `str2` consist of only lowercase English letters.

using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N25_KnowingWhatToTrack.P02_ValidAnagram;

public class Solution
{
    // Time complexity: O(n), Space complexity: O(1).
    public static bool IsAnagram(string str1, string str2)
    {
        if (str1.Length != str2.Length)
        {
            return false;
        }

        var counts = new Dictionary<char, int>();
        foreach (char ch in str1)
        {
            counts.TryAdd(ch, 0);
            counts[ch]++;
        }

        foreach (char ch in str2)
        {
            counts.TryAdd(ch, 0);
            counts[ch]--;
        }

        foreach (int count in counts.Values)
        {
            if (count != 0) { return false; }
        }

        return true;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run("astronomer", "moonstarer", true);
        Run("astronomer", "amonster", false);
    }

    private static void Run(string str1, string str2, bool expectedResult)
    {
        bool result = Solution.IsAnagram(str1, str2);
        Utilities.PrintSolution((str1, str2), result);
        Assert.AreEqual(expectedResult, result);
    }
}
