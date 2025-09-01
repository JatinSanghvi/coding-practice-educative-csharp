// Set Matrix Zeroes
// =================
//
// Given a matrix, `mat`, if any element within the matrix is zero, set that row and column to zero. The performed
// operations should be in place, i.e., the given matrix is modified directly without allocating another matrix.
//
// Constraints:
//
// - 1 ≤ `mat.row`, `mat.col` ≤ 20
// - -2^31 ≤ `mat[i][j]` ≤ 2^31 - 1

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N18_Matrices.P01_SetMatrixZeroes;

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
