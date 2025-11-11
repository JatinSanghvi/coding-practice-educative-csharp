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

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N14_DynamicProgramming.P12_LongestCommonSubsequence;

public class Solution
{
    // Time complexity: O(m * n), Space complexity: O(2n).
    public static int LongestCommonSubsequence(string str1, string str2)
    {
        var row = new int[str2.Length + 1];

        foreach (char ch1 in str1)
        {
            var newRow = new int[str2.Length + 1];
            for (int i = 0; i != str2.Length; i++)
            {
                char ch2 = str2[i];
                newRow[i + 1] = ch1 == ch2 ? row[i] + 1 : Math.Max(newRow[i], row[i + 1]);
            }

            row = newRow;
        }

        return row[str2.Length];
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run("baba", "aaaa", 2);
        Run("baba", "abab", 3);
        Run("aaaaaa", "bb", 0);
    }

    private static void Run(string str1, string str2, int expectedResult)
    {
        int result = Solution.LongestCommonSubsequence(str1, str2);
        Utilities.PrintSolution((str1, str2), result);
        Assert.AreEqual(expectedResult, result);
    }
}
