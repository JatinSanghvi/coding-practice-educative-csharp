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

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N12_GreedyTechniques.P15_JumpGameII;

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
