// Split Array Into Two Arrays to Minimize Sum Difference
// ======================================================
//
// You are given an integer array, `nums`, consisting of 2 ∗ n elements.
//
// Your task is to divide the array into two subarrays of length n, such that each element in `nums` belongs to exactly
// one of the two subarrays, and the absolute difference between their sum is minimized.
//
// Return the minimum possible absolute difference between the sum of the two subarrays.
//
// Constraints:
//
// - 1 ≤ n ≤ 15
// - `nums.length` == 2 ∗ n
// - -10^7 ≤ `nums[i]` ≤ 10^7

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N10_ModifiedBinarySearch.P14_SplitArrayIntoTwoArraysToMinimizeSumDifference;

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
