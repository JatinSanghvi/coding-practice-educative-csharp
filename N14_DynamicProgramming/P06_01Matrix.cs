// 01 Matrix
// =========
//
// Given an m×n binary matrix, `mat`, find the distance from each cell to the nearest 0. The distance between two
// adjacent cells is 1. Cells to the left, right, above, and below the current cell will be considered adjacent.
//
// Constraints:
//
// - 1 ≤ `mat.row`, `mat.col` ≤ 10^2
// - 1 ≤ `mat.row * mat.col` ≤ 10^4
// - `mat[i][j]` ∈ {0,1}
// - There is at least one 0 in `mat`.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N14_DynamicProgramming.P06_01Matrix;

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
