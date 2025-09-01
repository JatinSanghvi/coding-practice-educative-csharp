// Count Substrings With K-Frequency Characters II
// ==============================================
//
// Given a string `s` and an integer `k`, return the total number of substrings of `s` where at least one character
// appears at least `k` times.
//
// > Note: A substring is a contiguous sequence of characters within a string. For example, "edu" is a substring of
// "educative".
//
// Constraints:
//
// - 1 ≤ `s.length` ≤ 3×10^3
// - 1 ≤ `k` ≤ `s.length`
// - `s` consists only of lowercase English letters.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N04_SlidingWindow.P15_CountSubstringsWithKFrequencyCharactersII;

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
