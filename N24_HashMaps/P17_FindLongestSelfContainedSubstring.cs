// Find Longest Self-Contained Substring
// =====================================
//
// You are given a string, `s`, consisting of lowercase English letters. Your task is to find the length of the longest
// self-contained substring of `s`.
//
// A substring `t` of `s` is called self-contained if:
//
// - `t` is not equal to the entire string `s`.
// - Every character in `t` does not appear anywhere else in `s` (outside of `t`).
//
// In other words, all characters in `t` are completely unique to that substring within the string `s`.
//
// Return the length of the longest self-contained substring. If no such substring exists, return -1.
//
// Constraints:
//
// - 2 ≤ `s.length` ≤ 1000
// - `s` consists only of lowercase English letters.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N24_HashMaps.P17_FindLongestSelfContainedSubstring;

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
