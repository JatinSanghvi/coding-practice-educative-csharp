// Longest Substring without Repeating Characters
// ==============================================
//
// Given a string, `str`, return the length of the longest substring without repeating characters.
//
// Constraints:
//
// - 1 ≤ `str.length` ≤ 1000
// - `str` consists of English letters, digits, and spaces.

using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N04_SlidingWindow.P06_LongestSubstringWithoutRepeatingCharacters;

public class Solution
{
    public static int FindLongestSubstring(string str)
    {
        var chars = new HashSet<char>();
        int longest = 0;

        int start = 0;
        for (int end = 0; end < str.Length; end++)
        {
            while (chars.Contains(str[end]))
            {
                chars.Remove(str[start]);
                start++;
            }

            chars.Add(str[end]);
            longest = Math.Max(longest, (end + 1) - start);
        }

        return longest;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run("a", 1);
        Run("aa", 1);
        Run("ababcabdab", 4);
    }

    private static void Run(string str, int expectedResult)
    {
        int result = Solution.FindLongestSubstring(str);
        Utilities.PrintSolution(str, result);
        Assert.AreEqual(expectedResult, result);
    }
}
