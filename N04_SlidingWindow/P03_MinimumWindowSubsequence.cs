// Minimum Window Subsequence
// ==========================
//
// Given two strings, `s1` and `s2`, find and return the shortest substring of `s1` in which all the characters
// of `s2` appear in the same order, but not necessarily next to each other (i.e., `s2` should be a subsequence of
// the substring).
//
// If no such substring exists, return an empty string `""`. If there are multiple shortest substrings, return the
// one that appears first in `s1` (i.e., with the left-most starting index).
//
// > Note: A substring is a contiguous sequence of characters within a string. A subsequence is a sequence of
// characters that can be derived from a string by deleting some characters without changing the order of the
// remaining characters. For example, "edu" is a substring and "cave" is a subsequence of "educative."
//
// Constraints:
//
// - 1 ≤ `s1.length` ≤ 2×10^3
// - 1 ≤ `s2.length` ≤ 100
// - `s1` and `s2` consist of uppercase and lowercase English letters.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N04_SlidingWindow.P03_MinimumWindowSubsequence;

public class Solution
{
    public static bool Function()
    {
        return true;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run(true);
    }

    private static void Run(bool expectedResult)
    {
        bool result = Solution.Function();
        Utilities.PrintSolution(true, result);
        Assert.AreEqual(expectedResult, result);
    }
}
