// Rotate Image
// ============
//
// Given an n × n matrix, rotate the matrix 90 degrees clockwise. The performed rotation should be in place, i.e., the
// given matrix is modified directly without allocating another matrix.
//
// > Note: The function should only return the modified input matrix.
//
// Constraints:
//
// - `matrix.length` == `matrix[i].length`
// - 1 ≤ `matrix.length` ≤ 20
// - -10^3 ≤ `matrix[i][j]` ≤ 10^3

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N18_Matrices.P02_RotateImage;

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
