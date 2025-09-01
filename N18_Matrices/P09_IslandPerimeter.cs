// Island Perimeter
// ================
//
// You are given a `grid` with dimensions `row x col`, where each cell represents either land (`grid[i][j] = 1`) or
// water (`grid[i][j] = 0`). The grid satisfies the following conditions:
//
// - Cells are connected only horizontally or vertically (not diagonally).
// - The grid is surrounded by water and contains exactly one island, consisting of one or more connected land cells.
// - The island has no lakes, meaning no water is enclosed within the island that connects to the surrounding water.
// - The grid is rectangular, and each cell is a square with a side length 1.
//
// Your task is to calculate the perimeter of the island.
//
// Constraints:
//
// - `row` == `grid.length`
// - `col` == `grid[i].length`
// - 1 ≤ `row`, `col` ≤ 100
// - `grid[i][j]` is 0 or 1.
// - There is exactly one island in `grid`.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N18_Matrices.P09_IslandPerimeter;

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
