// Total Appeal of a String
// ========================
//
// Given a string `s`, return its total appeal, which is calculated by summing the appeals of all its substrings.
//
// > The appeal of a string is defined as the count of unique characters present in that string.
//
// For instance, the appeal of "xyzxz" is 3, as it contains three distinct characters: 'x', 'y', and 'z'.
//
// Constraints:
//
// - 1 ≤ `s.length` ≤ 10^3
// - `s` consists of only lowercase English letters.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N24_HashMaps.P13_TotalAppealOfAString;

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
