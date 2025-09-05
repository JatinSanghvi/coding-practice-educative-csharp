// Maximum Average Subarray I
// ==========================
//
// Given an array of integers `nums`, and an integer `k`, return the maximum average of a contiguous subarray of length
// `k`.
//
// Constraints:
//
// - 1 ≤ `k` ≤ `nums.length` ≤ 10^5
// - -10^4 ≤ `nums[i]` ≤ 10^4

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N04_SlidingWindow.P08_MaximumAverageSubarrayI;

public class Solution
{
    public static double FindMaxAverage(int[] nums, int k)
    {
        int maxSum = int.MinValue;
        int sum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];

            if (i >= k - 1)
            {
                maxSum = Math.Max(maxSum, sum);
                sum -= nums[i - (k - 1)];
            }
        }

        return (double)maxSum / k;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run(new int[] { 0, -2, 1, -3 }, 1, 1.0 / 1);
        Run(new int[] { 0, -2, 1, -3 }, 2, -1.0 / 2);
        Run(new int[] { 0, -2, 1, -3 }, 3, -1.0 / 3);
        Run(new int[] { 0, -2, 1, -3 }, 4, -4.0 / 4);
    }

    private static void Run(int[] nums, int k, double expectedResult)
    {
        double result = Solution.FindMaxAverage(nums, k);
        Utilities.PrintSolution((nums, k), result);
        Assert.AreEqual(expectedResult, result);
    }
}
