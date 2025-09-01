// Minimum Cost to Make At Least One Valid Path in a Grid
// ======================================================
//
// You are given an m × n grid, where each cell contains a directional sign indicating which neighboring cell to move to
// next. The sign in a cell `grid[i][j]` can be:
//
// - `1`: Move right, i.e., from `grid[i][j]` to `grid[i][j + 1]`.
// - `2`: Move left, i.e., from `grid[i][j]` to `grid[i][j - 1]`.
// - `3`: Move down, i.e., from `grid[i][j]` to `grid[i + 1][j]`.
// - `4`: Move up, i.e., from `grid[i][j]` to `grid[i - 1][j]`.
//
// > Note: Some signs may point outside the boundaries of the grid.
//
// Your starting position is the top-left cell (0, 0). A valid path is any sequence of moves beginning at (0, 0) and
// ending at the bottom-right cell (m - 1, n - 1), where each move follows the direction of the sign in the current
// cell.
//
// You are allowed to change the direction of a sign in any cell, but each modification incurs a cost of `1`, and each
// sign can be modified only once.
//
// Your task is to determine the minimum total cost required to ensure that at least one valid path exists from the top
// left to the bottom right cell.
//
// Constraints:
//
// - n == `grid.length`
// - m == `grid[i].length`
// - 1 ≤ m, n ≤ 50
// - 1 ≤ `grid[i][j]` ≤ 4

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N20_Graphs.P13_MinimumCostToMakeAtLeastOneValidPathInAGrid;

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
