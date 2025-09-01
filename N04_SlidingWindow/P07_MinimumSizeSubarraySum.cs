// Minimum Size Subarray Sum
// =========================
//
// Given an array of positive integers, `nums`, and a positive integer, `target`, find the minimum length of a
// contiguous subarray whose sum is greater than or equal to the `target`. If no such subarray is found, return `0`.
//
// Constraints:
//
// - 1 ≤ `target` ≤ 10^9
// - 1 ≤ `nums.length` ≤ 10^5
// - 1 ≤ `nums[i]` ≤ 10^4

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N04_SlidingWindow.P07_MinimumSizeSubarraySum;

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
