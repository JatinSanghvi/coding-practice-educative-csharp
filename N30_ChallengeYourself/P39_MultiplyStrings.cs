// Multiply Strings
// ================
//
// Given two non-negative integers, `str1` and `str2`, represented as strings, return the product of these integers,
// `result`, which is also represented as strings.
//
// Constraints:
//
// - `str1` and `str2` consist of digits only.
// - 1≤ `str1.length`, `str2.length` ≤200
// - No leading 0 in `str1` or `str2`

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N30_ChallengeYourself.P39_MultiplyStrings;

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
