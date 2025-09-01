// Single Number II
// ================
//
// Given a non-empty array `arr`, in which exactly two elements appear once, and all the other elements appear twice,
// return the two elements that appeared only once.
//
// > Note: The result can be returned in any order. The solution should use only constant extra space.
//
// Constraints:
//
// - 2 ≤ `arr.length` ≤ 10^3
// - -2^31 ≤ `arr[i]` ≤ 2^31 - 1

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N28_BitwiseManipulation.P05_SingleNumberII;

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
