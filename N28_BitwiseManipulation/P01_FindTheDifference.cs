// Find the Difference
// ===================
//
// Given two strings, `str1` and `str2`, find the index of the extra character that is present in only one of the
// strings.
//
// > Note: If multiple instances of the extra character exist, return the index of the first occurrence of the character
// > in the longer string.
//
// Constraints:
//
// - 0 ≤ `str1.length`, `str2.length` ≤ 1000
// - Either `str2.length` = `str1.length + 1`, or, `str1.length` = `str2.length + 1`
// - The strings consist of lowercase English letters.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N28_BitwiseManipulation.P01_FindTheDifference;

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
