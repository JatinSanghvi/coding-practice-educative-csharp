// The K Weakest Rows in a Matrix
// ==============================
//
// You are given an m × n binary matrix of 1's (representing soldiers) and 0's (representing civilians). The soldiers
// are positioned in front of the civilians, i.e., all the 1's will appear to the left of all the 0's in each row.
//
// A row i is weaker than a row j if any of the following is TRUE:
//
// - The number of soldiers in row i is less than the number of soldiers in row j.
// - Both rows have the same number of soldiers and i < j.
//
// You have to return the indexes of the k weakest rows in the matrix ordered from weakest to strongest.
//
// Constraints:
//
// - m = `matrix.length`
// - n = `matrix[i].length`
// - 2 ≤ n, m ≤ 100
// - 1 ≤ k ≤ m
// - `matrix[i][j]` is either 0 or 1.

using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N10_ModifiedBinarySearch.P08_TheKWeakestRowsInAMatrix;

public class Solution
{
    // Time complexity: O(m*logn + m*logk), Space complexity: O(k).
    public static int[] FindKWeakestRows(int[][] matrix, int k)
    {
        int rows = matrix.Length;
        int cols = matrix[0].Length;

        var weakestRows = new PriorityQueue<int, (int, int)>(rows);

        for (int row = 0; row != rows; row++)
        {
            int low = -1, high = cols;
            while (high - low != 1)
            {
                int mid = (low + high) / 2;
                if (mid == -1 || matrix[row][mid] == 1) { low = mid; }
                else { high = mid; }
            }

            int soldiers = high;
            weakestRows.Enqueue(row, (-soldiers, -row));

            if (weakestRows.Count == k)
            {
                weakestRows.Dequeue();
            }
        }

        var result = new int[k];

        for (int i = k - 1; i != -1; i--)
        {
            result[i] = weakestRows.Dequeue();
            Console.WriteLine(result[i]);
        }

        return result;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([[1, 0, 0], [1, 1, 0], [1, 1, 1], [0, 0, 0], [1, 0, 0]], 4, [3, 0, 4, 1]);
    }

    private static void Run(int[][] matrix, int k, int[] expectedResult)
    {
        int[] result = Solution.FindKWeakestRows(matrix, k);
        Utilities.PrintSolution((matrix, k), result);
        CollectionAssert.AreEqual(expectedResult, result);
    }
}
