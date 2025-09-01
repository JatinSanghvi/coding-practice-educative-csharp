// Minimum Window Substring
// ========================
//
// Given two strings, `s`, and `t`, find the minimum window substring in `s`, which has the following properties:
//
// 1. It is the shortest substring of `s` that includes all of the characters present in `t`.
// 2. It must contain at least the same frequency of each character as in `t`.
// 3. The order of the characters does not matter here.
//
// > Note: If there are multiple valid minimum window substrings, return any one of them.
//
// Constraints:
//
// - Strings `s` and `t` consist of uppercase and lowercase English characters.
// - 1 ≤ `s.length`, `t.length` ≤ 10^3

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N04_SlidingWindow.P05_MinimumWindowSubstring;

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
