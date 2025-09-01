// Subarrays with K Different Integers
// ===================================
//
// You are given an integer array `nums` and an integer `k`. Your task is to return the number of good subarrays of
// `nums`.
//
// > A good subarray is a contiguous subarray that contains exactly k distinct integers. For example, in the array
// [1,2,3,1,2], the subarray [1,2,3] contains 3 distinct integers: 1, 2, and 3.
//
// Constraints:
//
// - 1 ≤ `nums.length` ≤ 2∗10^4
// - 1 ≤ `nums[i]`, `k` ≤ `nums.length`

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N04_SlidingWindow.P13_SubarraysWithKDifferentIntegers;

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
