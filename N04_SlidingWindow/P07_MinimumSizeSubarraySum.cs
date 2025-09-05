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

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N04_SlidingWindow.P07_MinimumSizeSubarraySum;

public class Solution
{
    public static int MinSubArrayLen(int target, int[] nums)
    {
        int minLength = int.MaxValue;

        int sum = 0;
        int start = 0;
        for (int end = 0; end < nums.Length; end++)
        {
            sum += nums[end];

            while (sum >= target)
            {
                minLength = Math.Min(minLength, (end + 1) - start);
                sum -= nums[start];
                start++;
            }
        }

        return minLength == int.MaxValue ? 0 : minLength;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run(7, new int[] { 1, 2, 3, 2, 1 }, 3);
        Run(9, new int[] { 1, 2, 3, 2, 1 }, 5);
        Run(10, new int[] { 1, 2, 3, 2, 1 }, 0);
    }

    private static void Run(int target, int[] nums, int expectedResult)
    {
        int result = Solution.MinSubArrayLen(target, nums);
        Utilities.PrintSolution((nums, target), result);
        Assert.AreEqual(expectedResult, result);
    }
}
