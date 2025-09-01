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

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N13_Backtracking.P05_FloodFill;

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
