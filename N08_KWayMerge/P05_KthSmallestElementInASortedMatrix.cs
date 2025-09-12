// Kth Smallest Element in a Sorted Matrix
// =======================================
//
// Find the kth smallest element in an (n × n) matrix, where each row and column of the matrix is sorted in ascending
// order.
//
// Although there can be repeating values in the matrix, each element is considered unique and, therefore, contributes
// to calculating the kth smallest element.
//
// Constraints:
//
// - `n` == `matrix.length`
// - `n` == `matrix[i].length`
// - 1 ≤ `n` ≤ 100
// - -10^3 ≤ `matrix[i][j]` ≤ 10^3
// - 1 ≤ `k` ≤ n^2

using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N08_KWayMerge.P05_KthSmallestElementInASortedMatrix;

public class Solution
{
    // Time complexity: O(k*logn), Space complexity: O(n);
    public static int KthSmallestElement(int[][] matrix, int k)
    {
        var queue = new PriorityQueue<(int, int), int>();

        for (int row = 0; row < matrix.Length; row++)
        {
            queue.Enqueue((row, 0), matrix[row][0]);
        }

        int columns = matrix[0].Length;
        for (int i = 1; i < k; i++)
        {
            (int row, int col) = queue.Dequeue();
            if (col != columns - 1)
            {
                queue.Enqueue((row, col + 1), matrix[row][col + 1]);
            }
        }

        (int ansRow, int ansCol) = queue.Peek();
        return matrix[ansRow][ansCol];
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([[1, 3, 6], [2, 5, 8], [3, 7, 11]], 5, 5);
    }

    private static void Run(int[][] matrix, int k, int expectedResult)
    {
        int result = Solution.KthSmallestElement(matrix, k);
        Utilities.PrintSolution((matrix, k), result);
        Assert.AreEqual(expectedResult, result);
    }
}
