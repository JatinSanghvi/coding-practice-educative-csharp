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

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N28_BitwiseManipulation.P10_FindTheLongestSubstringHavingVowelsInEvenCounts;

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
