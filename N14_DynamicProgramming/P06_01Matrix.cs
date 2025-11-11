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

using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N14_DynamicProgramming.P06_01Matrix;

public class Solution
{
    // Time complexity: O(r*c), Space complexity: O(1).
    public static int[][] UpdateMatrix(int[][] mat)
    {
        int rows = mat.Length, cols = mat[0].Length;
        int maxValue = 10000;

        // Traverse from top left to bottom right.
        for (int r = 0; r != rows; r++)
        {
            for (int c = 0; c != cols; c++)
            {
                if (mat[r][c] != 0)
                {
                    mat[r][c] = Math.Min(
                        r == 0 ? maxValue : mat[r - 1][c],
                        c == 0 ? maxValue : mat[r][c - 1]) + 1;
                }
            }
        }

        // Traverse from bottom right to top left.
        for (int r = rows - 1; r != -1; r--)
        {
            for (int c = cols - 1; c != -1; c--)
            {
                if (mat[r][c] != 0)
                {
                    mat[r][c] = Math.Min(mat[r][c], Math.Min(
                        r == rows - 1 ? maxValue : mat[r + 1][c],
                        c == cols - 1 ? maxValue : mat[r][c + 1]) + 1);
                }
            }
        }

        return mat;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([[0, 1, 1], [1, 1, 1]], [[0, 1, 2], [1, 2, 3]]);
        Run([[1, 0, 1], [1, 1, 1]], [[1, 0, 1], [2, 1, 2]]);
        Run([[1, 1, 0], [1, 1, 1]], [[2, 1, 0], [3, 2, 1]]);
        Run([[1, 1, 0], [0, 1, 1]], [[1, 1, 0], [0, 1, 1]]);
    }

    private static void Run(int[][] mat, int[][] expectedResult)
    {
        int[][] matCopy = mat.Select(row => row.ToArray()).ToArray();
        int[][] result = Solution.UpdateMatrix(mat);
        Utilities.PrintSolution(matCopy, result);
        CollectionAssert.AreEqual(expectedResult, result);
    }
}
