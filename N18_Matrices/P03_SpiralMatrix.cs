// Spiral Matrix
// =============
//
// Given an m × n matrix, return an array containing the matrix elements in spiral order, starting from the top-left
// cell.
//
// Constraints:
//
// - 1 ≤ `matrix.length` ≤ 10
// - 1 ≤ `matrix[i].length` ≤ 10
// - -100 ≤ `matrix[i][j]` ≤ 100

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N18_Matrices.P03_SpiralMatrix;

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
