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

using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N18_Matrices.P02_RotateImage;

public class Solution
{
    // Time complexity: O(n^2), Space complexity: O(1).
    public static int[][] RotateImageMatrix(int[][] matrix)
    {
        int rows = matrix.Length;
        int cols = matrix[0].Length;

        for (int row = 0; row != rows / 2; row++)
        {
            for (int col = row; col != rows - 1 - row; col++)
            {
                int temp = matrix[row][col];
                matrix[row][col] = matrix[cols - 1 - col][row];
                matrix[cols - 1 - col][row] = matrix[rows - 1 - row][cols - 1 - col];
                matrix[rows - 1 - row][cols - 1 - col] = matrix[col][rows - 1 - row];
                matrix[col][rows - 1 - row] = temp;
            }
        }

        return matrix;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([
                [1, 2, 3, 4],
                [5, 6, 7, 8],
                [9, 10, 11, 12],
                [13, 14, 15, 16]
            ], [
                [13, 9, 5, 1],
                [14, 10, 6, 2],
                [15, 11, 7, 3],
                [16, 12, 8, 4]
            ]);

        Run([
                [1, 2, 3],
                [4, 5, 6],
                [7, 8, 9]
            ], [
                [7, 4, 1],
                [8, 5, 2],
                [9, 6, 3]
            ]);
    }

    private static void Run(int[][] matrix, int[][] expectedResult)
    {
        int[][] matrixCopy = matrix.Select(row => row.ToArray()).ToArray();
        int[][] result = Solution.RotateImageMatrix(matrix);
        Utilities.PrintSolution(matrixCopy, result);
        CollectionAssert.AreEqual(expectedResult, result);
    }
}
