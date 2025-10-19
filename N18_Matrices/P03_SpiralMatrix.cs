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

using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N18_Matrices.P03_SpiralMatrix;

public class Solution
{
    // Time complexity: O(r*c), Space complexity: O(1).
    public static List<int> SpiralOrderTraversal(int[][] matrix)
    {
        int r = 0, c = -1;
        int rows = matrix.Length, cols = matrix[0].Length;
        int increment = 1;
        var values = new List<int>();

        while (rows != 0 && cols != 0)
        {
            for (int i = 0; i != cols; i++)
            {
                c += increment;
                values.Add(matrix[r][c]);
            }
            rows--;

            for (int i = 0; i != rows; i++)
            {
                r += increment;
                values.Add(matrix[r][c]);
            }
            cols--;

            increment = -increment;
        }

        return values;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([[1, 2, 3, 4, 5], [6, 7, 8, 9, 10], [11, 12, 13, 14, 15]], [1, 2, 3, 4, 5, 10, 15, 14, 13, 12, 11, 6, 7, 8, 9]);
    }

    private static void Run(int[][] matrix, int[] expectedResult)
    {
        int[] result = Solution.SpiralOrderTraversal(matrix).ToArray();
        Utilities.PrintSolution(matrix, result);
        CollectionAssert.AreEqual(expectedResult, result);
    }
}
