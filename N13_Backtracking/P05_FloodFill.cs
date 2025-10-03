// Flood Fill
// ==========
//
// You are given a 2D `grid` of size `m x n`, where `grid[i][j]` represents the pixel value at position `(i, j)`.
//
// Additionally, you are given three integers:
//
// - `sr`: The row index of the starting pixel
// - `sc`: The column index of the starting pixel
// - `target`: The new color to apply
//
// Your task is to perform a flood fill starting from the pixel at position `(sr, sc)`. Below is the flood fill process:
//
// 1. If the pixel at `(sr, sc)` already has the value `target`, return the original grid without any changes.
// 2. Otherwise, start at the pixel `grid[sr][sc]` and change its color to the given color `target`.
// 3. Perform the same operation for all 4-directionally adjacent pixels (up, down, left, right) with the same original
//    color as the starting pixel.
// 4. Continue this process by examining the neighboring pixels of each updated pixel and changing their color if they
//    match the original color of the starting pixel.
// 5. The process continues until no more adjacent pixels with the original color left to update.
//
// Return the updated `grid` after the flood fill is complete.
//
// Constraints:
//
// - 1 ≤ `grid.length`, `grid[i].length` ≤ 30
// - 0 ≤ `grid[i][j]`, `target` ≤ 2^16
// - 0 ≤ `sr` < `grid.length`
// - 0 ≤ `sc` < `grid[i].length`

using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N13_Backtracking.P05_FloodFill;

public class Solution
{
    // Time complexity: O(m*n), Space complexity: O(m*n).
    public static int[][] FloodFill(int[][] grid, int sr, int sc, int target)
    {
        int rows = grid.Length, cols = grid[0].Length;
        int source = grid[sr][sc];

        if (source != target)
        {
            Fill(sr, sc);
        }

        return grid;

        void Fill(int r, int c)
        {
            if (r == -1 || r == rows || c == -1 || c == cols || grid[r][c] != source)
            {
                return;
            }

            grid[r][c] = target;
            Fill(r - 1, c);
            Fill(r, c - 1);
            Fill(r, c + 1);
            Fill(r + 1, c);
        }
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run(
            [[1, 0, 1, 1], [0, 1, 1, 0], [1, 1, 0, 1]], 1, 2, 2,
            [[1, 0, 2, 2], [0, 2, 2, 0], [2, 2, 0, 1]]);
    }

    private static void Run(int[][] grid, int sr, int sc, int target, int[][] expectedResult)
    {
        int[][] gridCopy = grid.Select(row => row.ToArray()).ToArray();
        int[][] result = Solution.FloodFill(grid, sr, sc, target);
        Utilities.PrintSolution((gridCopy, sr, sc, target), result);
        CollectionAssert.AreEqual(expectedResult, result);
    }
}
