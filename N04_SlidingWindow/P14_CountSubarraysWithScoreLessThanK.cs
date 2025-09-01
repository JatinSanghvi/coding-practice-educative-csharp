// Count Subarrays With Score Less Than K
// ======================================
//
// An array score is defined as the sum of the array elements multiplied by its length. For example, if the array is
// [2,1,5], then its score is (2+1+5)×3 = 24.
//
// Given an array of positive integers, `nums`, and a positive integer `k`, count and return the number of non-empty
// subarrays of `nums` whose score is strictly less than `k`.
//
// > Note: A subarray is a contiguous sequence of elements within an array.
//
// Constraints:
//
// - 1 ≤ `nums.length` ≤ 10^3
// - 1 ≤ `nums[i]` ≤ 10^3
// - 1 ≤ `k` ≤ 10^5

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N04_SlidingWindow.P14_CountSubarraysWithScoreLessThanK;

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
