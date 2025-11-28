// Shortest Bridge
// ===============
//
// We are given an n×n binary matrix grid containing `0`s and `1`s. Each cell in the grid represents either land or
// water. A cell with a value of `1` represents land, while a cell with a value of `0` represents water. A group of
// adjacent cells with a value of `1` constitutes an island. Two cells are considered adjacent if one is above, below,
// to the left, or to the right of the other. Our task is to return the smallest number of `0`s we must flip to connect
// the two islands.
//
// > Note: We may assume all four edges of the grid are surrounded by water.
//
// Constraints:
//
// - 2 ≤ `n` ≤ 20
// - n == `grid.length` == `grid[i].length`.
// - `grid[i][j]` is either `0` or `1`.
// - There are exactly two islands in the `grid`.

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N30_ChallengeYourself.P01_ShortestBridge;

public class Solution
{
    // Time complexity: O(rc), Space complexity: O(1).
    public static int ShortestBridge(int[][] grid)
    {
        int rows = grid.Length, cols = grid[0].Length;

        // Get Island 1's coordinates.
        int row1 = 0, col1 = 0;
        for (row1 = 0; row1 != rows; row1++)
        {
            for (col1 = 0; col1 != cols; col1++)
            {
                if (grid[row1][col1] == 1) { break; }
            }

            if (col1 != cols) { break; }
        }

        // Color Island 1, and store borders.
        var borders = new Queue<(int, int, int)>();

        void Color(int row, int col)
        {
            if (row == -1 || row == rows || col == -1 || col == cols || grid[row][col] == 2)
            {
                return;
            }

            if (grid[row][col] == 0)
            {
                grid[row][col] = 2;
                borders.Enqueue((row, col, 1));
            }
            else
            {
                grid[row][col] = 2;
                Color(row - 1, col);
                Color(row + 1, col);
                Color(row, col - 1);
                Color(row, col + 1);
            }
        }

        Color(row1, col1);

        // Expand Island 1 until Island 2 is reached.
        bool Expand(int row, int col, int distance)
        {
            if (row == -1 || row == rows || col == -1 || col == cols || grid[row][col] == 2)
            {
                return false;
            }

            if (grid[row][col] == 0)
            {
                grid[row][col] = 2;
                borders.Enqueue((row, col, distance));
                return false;
            }
            else
            {
                return true;
            }
        }

        while (borders.Count != 0)
        {
            (int row, int col, int distance) = borders.Dequeue();

            if (
                Expand(row - 1, col, distance + 1) ||
                Expand(row + 1, col, distance + 1) ||
                Expand(row, col - 1, distance + 1) ||
                Expand(row, col + 1, distance + 1))
            {
                return distance;
            }
        }

        throw new InvalidOperationException();
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([[1, 0, 0, 0], [1, 0, 0, 0], [0, 0, 0, 0], [0, 0, 1, 1]], 3);
        Run([[0, 1, 1, 0], [0, 0, 0, 0], [0, 0, 0, 0], [0, 1, 1, 0]], 2);
    }

    private static void Run(int[][] grid, int expectedResult)
    {
        int[][] gridCopy = grid.Select(row => row.ToArray()).ToArray();
        int result = Solution.ShortestBridge(grid);
        Utilities.PrintSolution(gridCopy, result);
        Assert.AreEqual(expectedResult, result);
    }
}
