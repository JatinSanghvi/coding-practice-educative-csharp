// Unique Paths III
// ================
//
// You are given a  m × n  integer array, `grid`, where each cell, `grid[i][j]`, can have one of the following values:
//
// - `1` indicates the starting point. There is exactly one such square.
// - `2` marks the ending point. There is exactly one such square.
// - `0` represents empty squares that can be walked over.
// - `-1` represents obstacles that cannot be crossed.
//
// Your task is to return the total number of unique four-directional paths from the starting square (`1`) to the ending
// square (`2`), such that every empty square is visited exactly once during the walk.
//
// Constraints:
//
// - m == `grid.length`
// - n == `grid[i].length`
// - 1 ≤ m, n ≤ 20
// - 1 ≤ m × n ≤ 20
// - -1 ≤ `grid[i][j]` ≤ 2
// - There is exactly one starting cell and one ending cell.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N13_Backtracking.P14_UniquePathsIII;

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
