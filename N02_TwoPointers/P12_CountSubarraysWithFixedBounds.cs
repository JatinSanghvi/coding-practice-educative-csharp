// Count Subarrays With Fixed Bounds
// =================================
// 
// Given an integer array, `nums`, and two integers `minK` and `maxK`, return the number of fixed-bound subarrays.
// 
// A subarray in `nums` is called a fixed-bound subarray if it satisfies the following conditions:
// 1. The smallest value in the subarray equals `minK`.
// 2. The largest value in the subarray equals `maxK`.
// 
// > Note: A subarray is a contiguous sequence of elements within an array.
// 
// Constraints:
// 
// - 2 ≤ `nums.length` ≤ 10^3
// - 1 ≤ `nums[i], minK, maxK` ≤ 10^3

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N02_TwoPointers.P12_CountSubarraysWithFixedBounds;

public class Solution
{
    public long CountSubarrays(int[] nums, int minK, int maxK)
    {
        long count = 0;
        int start = 0;
        int lastMin = -1, lastMax = -1;

        for (int end = 0; end < nums.Length; end++)
        {
            if (nums[end] < minK || nums[end] > maxK)
            {
                start = end + 1;
                lastMin = lastMax = end;
            }
            else
            {
                if (nums[end] == minK) { lastMin = end; }
                if (nums[end] == maxK) { lastMax = end; }

                count += Math.Min(lastMin, lastMax) - start + 1;
            }
        }

        return count;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run(new[] { 1, 2, 3, 2, 1 }, 1, 3, 5);
        Run(new[] { 1, 2, 3, 4, 1 }, 1, 3, 1);
        Run(new[] { 1, 4, 3, 4, 1 }, 1, 3, 0);
        Run(new[] { 1, 1, 1, 1, 1 }, 1, 1, 15);
    }

    private static void Run(int[] nums, int minK, int maxK, long expectedCount)
    {
        long count = new Solution().CountSubarrays(nums, minK, maxK);
        Utilities.PrintSolution((nums, minK, maxK), count);
        Assert.AreEqual(expectedCount, count);
    }
}