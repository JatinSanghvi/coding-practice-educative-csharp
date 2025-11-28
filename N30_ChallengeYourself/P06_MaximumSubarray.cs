// Maximum Subarray
// ================
//
// Given an integer array, `nums`, find the contiguous subarray that has the largest sum and return its sum.
//
// > Note: A subarray is a contiguous part of an array that contains at least one number.
//
// Constraints:
//
// - 1 ≤ `nums.length` ≤ 10^5
// - -10^4 ≤ `nums[i]` ≤ 10^4

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N30_ChallengeYourself.P06_MaximumSubarray;

public class Solution
{
    // Time complexity: O(n), Space complexity: O(1).
    public static int MaxSubArray(int[] nums)
    {
        int maxSum = nums[0], maxTill = nums[0];

        for (int i = 1; i != nums.Length; i++)
        {
            maxTill = Math.Max(maxTill, 0) + nums[i];
            maxSum = Math.Max(maxSum, maxTill);
        }

        return maxSum;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([0, -2, 1, -3], 1);
        Run([-0, 2, -1, 3], 4);
    }

    private static void Run(int[] nums, int expectedResult)
    {
        int result = Solution.MaxSubArray(nums);
        Utilities.PrintSolution(nums, result);
        Assert.AreEqual(expectedResult, result);
    }
}
