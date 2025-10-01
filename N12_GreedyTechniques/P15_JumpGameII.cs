// Jump Game II
// ============
//
// In a single player jump game, the player starts at one end of a series of squares and aims to reach the last square.
//
// At each turn, the player can take up to s steps toward the last square, where s is the value of the current square.
//
// For example, if the value of the current square is 3, the player can take either 3 steps, 2 steps, or 1 step in the
// direction of the last square. The player cannot move in the opposite direction, away from the last square.
//
// You've been provided with the `nums` integer array, representing the series of squares.
//
// You're initially positioned at the first index of the array. Find the minimum number of jumps needed to reach the
// last index of the array.
//
// You may assume that you can always reach the last index.
//
// Constraints
//
// - 1 ≤ `nums.length` ≤ 10^3
// - 0 ≤ `nums[i]` ≤ 10^3

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N12_GreedyTechniques.P15_JumpGameII;

public class Solution
{
    // Time complexity: O(n), Space complexity: O(1).
    public static int JumpGame2(int[] nums)
    {
        int range = 0;
        int jumps = 0;
        int i = 0;

        while (range < nums.Length - 1)
        {
            int newRange = range;
            while (i <= range)
            {
                newRange = Math.Max(newRange, i + nums[i]);
                i++;
            }

            jumps++;
            range = newRange;
        }

        return jumps;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([2, 1, 1, 1, 4], 3);
        Run([2, 3, 1, 1, 4], 2);
    }

    private static void Run(int[] nums, int expectedResult)
    {
        int result = Solution.JumpGame2(nums);
        Utilities.PrintSolution(nums, result);
        Assert.AreEqual(expectedResult, result);
    }
}
