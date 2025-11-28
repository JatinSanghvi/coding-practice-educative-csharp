// Pacific Atlantic Water Flow
// ===========================
//
// Imagine an island with a rectangular shape that touches both the Pacific and Atlantic oceans. The northern and
// western sides meet the Pacific, while the southern and eastern sides touch the Atlantic. This island is divided into
// square cells.
//
// To depict the height above sea level of each cell, we use an integer matrix, `heights`, of size (m×n). Here,
// `heights[r][c]` represents the elevation of the cell at coordinate (r,c).
//
// When heavy rain pours down on the island every few months, water flows from the island to both the Pacific and
// Atlantic oceans. The path of flow depends on the heights of the cells.
//
// Consider a cell with a height of 9 that's higher than or equal to its neighboring cells to the north, east, west, and
// south. This indicates that water can flow from this cell to adjacent ones. Similarly, this process is repeated until
// the flow of water either reaches the Pacific or Atlantic border or a cell that can not flow water to any of its
// neighbors. If the flow of water starting from a cell can direct water to both the Pacific and Atlantic Ocean borders,
// we include it in the output.
//
// > Note: Any cell adjacent to an ocean can channel water into the ocean.
//
// With this information, your task is to return a 2D array of coordinates. Each entry (r_i,c_i) in this array indicates
// that rainwater can flow from the cell at coordinate (r_i,c_i) to both the Pacific and Atlantic oceans.
//
// Constraints:
//
// - m == `heights.length`
// - n == `heights[r].length`, where 0 ≤ r ≤ m
// - 1 ≤ m, n ≤ 200
// - 0 ≤ `heights[r][c]` ≤ 10^5

using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N30_ChallengeYourself.P04_PacificAtlanticWaterFlow;

public class Solution
{
    public static int[][] EstimateWaterFlow(int[][] heights)
    {
        int rows = heights.Length;
        int cols = heights[0].Length;

        var pacific = new bool[rows, cols];
        var atlantic = new bool[rows, cols];

        for (int row = 0; row != rows; row++)
        {
            Visit(row, 0, pacific);
            Visit(row, cols - 1, atlantic);
        }

        for (int col = 0; col != cols; col++)
        {
            Visit(0, col, pacific);
            Visit(rows - 1, col, atlantic);
        }

        var result = new List<int[]>();

        for (int row = 0; row != rows; row++)
        {
            for (int col = 0; col != cols; col++)
            {
                if (pacific[row, col] && atlantic[row, col])
                {
                    result.Add(new int[] { row, col });
                }
            }
        }

        return result.ToArray();

        void Visit(int row, int col, bool[,] ocean)
        {
            if (ocean[row, col]) { return; }
            ocean[row, col] = true;

            int height = heights[row][col];
            if (row != 0 && heights[row - 1][col] >= height) { Visit(row - 1, col, ocean); }
            if (row != rows - 1 && heights[row + 1][col] >= height) { Visit(row + 1, col, ocean); }
            if (col != 0 && heights[row][col - 1] >= height) { Visit(row, col - 1, ocean); }
            if (col != cols - 1 && heights[row][col + 1] >= height) { Visit(row, col + 1, ocean); }
        }
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([[1, 2, 3], [2, 0, 2], [3, 2, 1]], [[0, 2], [2, 0]]);
        Run([[2, 1, 2], [1, 2, 1], [2, 1, 2]], [[0, 1], [1, 1], [2, 0]]);
    }

    private static void Run(int[][] heights, int[][] expectedResult)
    {
        int[][] result = Solution.EstimateWaterFlow(heights);
        Utilities.PrintSolution(heights, result);
        CollectionAssert.AreEqual(expectedResult, result);
    }
}
