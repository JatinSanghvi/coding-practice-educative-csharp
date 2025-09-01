// Palindromic Substrings
// ======================
//
// Given a string, `s`, return the number of palindromic substrings contained in it. A substring is a contiguous
// sequence of characters in a string. A palindrome is a phrase, word, or sequence that reads the same forward and
// backward.
//
// Constraints:
//
// - 1 ≤ `s.length` ≤ 1000
// - `s` consists of only lowercase English characters.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N14_DynamicProgramming.P11_PalindromicSubstrings;

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
