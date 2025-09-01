// Largest Palindromic Number
// ==========================
//
// You are given a string `num` consisting of digits from 0 to 9. Your task is to return the largest possible
// palindromic number as a string by using some or all of the digits in `num`. The resulting palindromic number must not
// have leading zeros.
//
// Note: You may reorder the digits freely, and you must use at least one digit from the `num` string.
//
// Constraints:
//
// - 1 ≤ `num.length` ≤ 1000
// - `num` consists of digits

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N12_GreedyTechniques.P06_LargestPalindromicNumber;

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
