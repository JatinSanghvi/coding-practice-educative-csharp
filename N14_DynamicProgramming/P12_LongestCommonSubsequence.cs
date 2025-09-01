// Longest Common Subsequence
// ==========================
//
// Suppose you are given two strings. You need to find the length of the longest common subsequence between these two
// strings.
//
// A subsequence is a string formed by removing some characters from the original string while maintaining the relative
// position of the remaining characters. For example, "abd" is a subsequence of "abcd", where the removed character is
// "c".
//
// If there is no common subsequence, then return 0.
//
// Constraints:
//
// - 1 ≤ `str1.length` ≤ 500
// - 1 ≤ `str2.length` ≤ 500
// - `str1` and `str2` contain only lowercase English characters.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N14_DynamicProgramming.P12_LongestCommonSubsequence;

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
