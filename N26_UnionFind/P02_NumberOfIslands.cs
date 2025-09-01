// Number of Islands
// =================
//
// Let's consider a scenario with an (m×n) 2D grid containing binary numbers, where `'0'` represents water and `'1'`
// represents land. If any `'1'` cells are connected to each other horizontally or vertically (not diagonally), they
// form an island. Your task is to return the total number of islands in the grid.
//
// Constraints:
//
// - 1 ≤ `grid.length` ≤ 50
// - 1 ≤ `grid[i].length` ≤ 50
// - `grid[i][j]` is either `'0'` or `'1'`.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N26_UnionFind.P02_NumberOfIslands;

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
