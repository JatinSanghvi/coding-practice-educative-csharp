// Jump Game
// =========
//
// You are given an integer array `nums`, where each element represents the maximum number of steps you can move forward
// from that position. You always start at index 0 (the first element), and at each step, you may jump to any of the
// next positions within the range allowed by the current element's value. Return TRUE if you can reach the last index,
// or FALSE otherwise.
//
// Constraints:
//
// - 1 ≤ `nums.length` ≤ 10^3
// - 0 ≤ `nums[i]` ≤ 10^3

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N12_GreedyTechniques.P01_JumpGame;

public class Solution
{
    // Time complexity: O(n), Space complexity: O(1).
    public static bool JumpGame(int[] nums)
    {
        int max = 0;
        for (int i = 0; i <= max && max < nums.Length - 1; i++)
        {
            max = Math.Max(max, i + nums[i]);
        }

        return max >= nums.Length - 1;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([2, 0, 1, 0], true);
        Run([1, 0, 2, 0], false);
    }

    private static void Run(int[] nums, bool expectedResult)
    {
        bool result = Solution.JumpGame(nums);
        Utilities.PrintSolution(nums, result);
        Assert.AreEqual(expectedResult, result);
    }
}
