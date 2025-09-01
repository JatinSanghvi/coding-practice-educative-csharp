// Shortest Bridge
// ===============
//
// We are given an n×n binary matrix grid containing `0`s and `1`s. Each cell in the grid represents either land or
// water. A cell with a value of `1` represents land, while a cell with a value of `0` represents water. A group of
// adjacent cells with a value of `1` constitutes an island. Two cells are considered adjacent if one is above, below,
// to the left, or to the right of the other. Our task is to return the smallest number of `0`s we must flip to connect
// the two islands.
//
// > Note: We may assume all four edges of the grid are surrounded by water.
//
// Constraints:
//
// - 2 ≤ `n` ≤ 20
// - n == `grid.length` == `grid[i].length`.
// - `grid[i][j]` is either `0` or `1`.
// - There are exactly two islands in the `grid`.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N30_ChallengeYourself.P01_ShortestBridge;

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
