// Single Number
// =============
//
// Given an array of integers, where every element appears twice except for one, find the element that occurs only once.
//
// > Note: The solution must have linear runtime and constant space complexity.
//
// Constraints:
//
// - 1 ≤ `nums.length` ≤ 10^3
// - -3 × 10^3 ≤ `nums[i]` ≤ 3 × 10^3

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N28_BitwiseManipulation.P04_SingleNumber;

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
