// Longest Increasing Subsequence
// ==============================
//
// The Longest Increasing Subsequence (LIS) is the longest subsequence from a given array in which the subsequence
// elements are sorted in a strictly increasing order. Given an integer array, `nums`, find the length of the LIS in
// this array.
//
// Constraints:
//
// - 1 ≤ `nums.length` ≤ 1000
// - -10^4 ≤ `nums[i]` ≤ 10^4

using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N30_ChallengeYourself.P20_LongestIncreasingSubsequence;

public class Solution
{
    public static int LengthOfLIS(int[] nums)
    {
        // Smallest number found at the end of subsequences of particular length.
        var minimums = new List<int> { int.MinValue };

        foreach (int num in nums)
        {
            int i = minimums.Count - 1;
            for (; i != -1 && num <= minimums[i]; i--) { }

            if (minimums.Count == i + 1)
            {
                minimums.Add(int.MaxValue);
            }

            minimums[i + 1] = Math.Min(minimums[i + 1], num);
        }

        return minimums.Count - 1;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([0, 4, 2, 6, 1, 5, 3, 7], 4);
        Run([7, 3, 5, 1, 6, 2, 4, 0], 3);
    }

    private static void Run(int[] nums, int expectedResult)
    {
        int result = Solution.LengthOfLIS(nums);
        Utilities.PrintSolution(nums, result);
        Assert.AreEqual(expectedResult, result);
    }
}
