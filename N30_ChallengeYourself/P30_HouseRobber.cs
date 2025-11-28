// House Robber
// ============
//
// As a skilled thief, you are planning to rob multiple houses on a street, each of which contains a substantial amount
// of money. However, you cannot rob the adjacent houses due to the connected security systems. Otherwise, the police
// will be contacted automatically.
//
// Given an array of integers, `nums`, representing the amount of money present in each house, return the maximum amount
// of money that you can successfully steal without notifying the police.
//
// Constraints
//
// - 1 ≤ `nums.length` ≤ 10^3
// - 0 ≤ `nums[i]` ≤ 1000

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N30_ChallengeYourself.P30_HouseRobber;

public class Solution
{
    // Time complexity: O(n), Space complexity: O(1).
    public static int Rob(int[] nums)
    {
        int withLast = 0, withoutLast = 0;

        foreach (int num in nums)
        {
            (withLast, withoutLast) = (withoutLast + num, Math.Max(withLast, withoutLast));
        }

        return Math.Max(withLast, withoutLast);
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([0, 10, 10, 0], 10);
        Run([0, 10, 0, 10], 20);
        Run([10, 0, 10, 0], 20);
        Run([10, 0, 0, 10], 20);
    }

    private static void Run(int[] nums, int expectedResult)
    {
        int result = Solution.Rob(nums);
        Utilities.PrintSolution(nums, result);
        Assert.AreEqual(expectedResult, result);
    }
}
