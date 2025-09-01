// Longest Palindromic Substring
// =============================
//
// Given a string `s`, return the longest palindromic substring in `s`.
//
// > Note: If there are multiple valid palindromic substrings of the same length, return any of them.
//
// Constraints
//
// - 1 ≤ `s.length` ≤ 1000
// - `s` consist of only digits and English letters.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N30_ChallengeYourself.P24_LongestPalindromicSubstring;

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
