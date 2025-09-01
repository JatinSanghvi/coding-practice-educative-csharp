// Longest Happy Prefix
// ====================
//
// Given a string, `s`, find the longest happy prefix. If no such prefix exists, return an empty string `""`.
//
// > Note: A happy prefix of a string is a non-empty substring at the beginning that also appears at the end (but not
// > the entire string itself).
//
// Constraints:
//
// - 1 ≤ `s.length` ≤ 10^5
// - `s` contains only lowercase English letters.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N24_HashMaps.P16_LongestHappyPrefix;

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
