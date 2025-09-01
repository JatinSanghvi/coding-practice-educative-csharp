// Add Binary
// ==========
//
// Given two binary strings `str1` and `str2`, return their sum as a binary string.
//
// Constraints:
//
// - 1≤ `str1.length` , `str2.length` ≤ 500
//
// - `str1` and `str2` consist of `0` or `1` characters only.
//
// - Any string must not contain leading zeros except the string representing the binary form of 0.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N30_ChallengeYourself.P38_AddBinary;

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
