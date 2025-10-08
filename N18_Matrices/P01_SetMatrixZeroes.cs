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

using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N18_Matrices.P01_SetMatrixZeroes;

public class Solution
{
    // Time complexity: O(rc), Space complexity: O(1).
    public static int[][] SetMatrixZeros(int[][] mat)
    {
        int rows = mat.Length, cols = mat[0].Length;

        bool firstRowZero = false, firstColZero = false;

        for (int col = 0; col != cols; col++)
        {
            if (mat[0][col] == 0) { firstRowZero = true; }
        }

        for (int row = 0; row != rows; row++)
        {
            if (mat[row][0] == 0) { firstColZero = true; }
        }

        for (int row = 1; row != rows; row++)
        {
            for (int col = 1; col != cols; col++)
            {
                if (mat[row][col] == 0)
                {
                    mat[0][col] = 0;
                    mat[row][0] = 0;
                }
            }
        }

        for (int row = 1; row != rows; row++)
        {
            for (int col = 1; col != cols; col++)
            {
                if (mat[0][col] == 0 || mat[row][0] == 0)
                {
                    mat[row][col] = 0;
                }
            }
        }

        if (firstRowZero)
        {
            for (int col = 0; col != cols; col++) { mat[0][col] = 0; }
        }

        if (firstColZero)
        {
            for (int row = 0; row != rows; row++) { mat[row][0] = 0; }
        }

        return mat;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([[1, 1, 1], [0, 1, 0], [1, 1, 1]], [[0, 1, 0], [0, 0, 0], [0, 1, 0]]);
    }

    private static void Run(int[][] mat, int[][] expectedResult)
    {
        int[][] matCopy = mat.Select(row => row.ToArray()).ToArray();
        int[][] result = Solution.SetMatrixZeros(mat);
        Utilities.PrintSolution(matCopy, result);
        CollectionAssert.AreEqual(expectedResult, result);
    }
}
