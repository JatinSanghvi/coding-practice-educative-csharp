// Swim in Rising Water
// ====================
//
// Given an n × n grid (2D matrix) where each cell `grid[i][j]` represents the elevation at position `(i, j)`.
//
// Once it starts to rain, the water level rises over time. At any given time `t`, the water depth across the grid
// equals `t`. A swimmer can move from one cell to an adjacent cell (up, down, left, or right) if both cells have
// elevations less than or equal to the current water level `t`.
//
// If the elevation condition is satisfied, a swimmer can swim any distance instantly. However, he cannot move outside
// the grid boundaries.
//
// Return the minimum time `t` at which it becomes possible to swim from the top-left cell (0, 0) to the bottom-right
// cell (n - 1, n - 1).
//
// Constraints:
//
// - n == `grid.length`
// - n == `grid[i].length`
// - 1 ≤ n ≤ 30
// - 0 ≤ `grid[i][j]` < n^2
// - Each value `grid[i][j]` is unique.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N18_Matrices.P16_SwimInRisingWater;

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
