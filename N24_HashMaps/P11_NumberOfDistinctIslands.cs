// Number of Distinct Islands
// ==========================
//
// Given an `m x n` binary matrix where 1 represents land and 0 represents water. An island is a group of connected 1s
// that are adjacent horizontally or vertically. Two islands are considered the same if one matches the other without
// rotating or flipping. The task is to return the number of distinct islands.
//
// Constraints:
//
// - `m` == `grid.length`
// - `n` == `grid[i].length`
// - 1 ≤ `m`, `n` ≤ 100
// - `grid[i][j]` is either 0 or 1.

using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N24_HashMaps.P11_NumberOfDistinctIslands;

public class Solution
{
    // Time complexity: O(m*n), Space complexity: O(m*n).
    public static int NumDistinctIslands(int[][] grid)
    {
        var shapes = new HashSet<string>();

        int rows = grid.Length;
        int cols = grid[0].Length;

        for (int r = 0; r != rows; r++)
        {
            for (int c = 0; c != cols; c++)
            {
                if (grid[r][c] == 1)
                {
                    var shape = new StringBuilder();
                    Walk(r, c);
                    shapes.Add(shape.ToString());

                    void Walk(int r2, int c2)
                    {
                        if (r2 != -1 && r2 != rows && c2 != -1 && c2 != cols && grid[r2][c2] == 1)
                        {
                            grid[r2][c2] = 0;
                            shape.Append($"({r2 - r}, {c2 - c}) ");

                            Walk(r2 - 1, c2);
                            Walk(r2 + 1, c2);
                            Walk(r2, c2 - 1);
                            Walk(r2, c2 + 1);
                        }
                    }
                }
            }
        }

        return shapes.Count;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run(
            [
                [1, 1, 0, 1],
                [1, 0, 1, 1],
                [0, 1, 0, 0],
                [1, 1, 0, 1],
            ],
            3);

        Run(
            [
                [1, 1, 1, 1],
                [0, 0, 0, 0],
                [1, 1, 1, 1],
                [0, 0, 0, 0],
            ],
            1);
    }

    private static void Run(int[][] grid, int expectedResult)
    {
        int[][] gridCopy = grid.Select(row => row.ToArray()).ToArray();
        int result = Solution.NumDistinctIslands(grid);
        Utilities.PrintSolution(gridCopy, result);
        Assert.AreEqual(expectedResult, result);
    }
}
