// Rotting Oranges
// ===============
//
// Consider an m×n grid containing cells with three potential values:
//
// - 0,which indicates an unoccupied cell.
// - 1,representing a freshly picked orange.
// - 2, indicating a rotten orange.
//
// Any fresh orange that is 4--directionally adjacent to a rotten orange will also turn rotten with each passing minute.
//
// Your task is to determine the minimum time required for all cells to have rotten oranges. In case, this objective
// cannot be achieved, return -1.
//
// Constraints:
//
// - `m` = `grid.length`
// - `n` = `grid[i].length`
// - 1 ≤ `m`, `n` ≤ 10
// - `grid[i][j]` is `0`, `1`, or `2`.

using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N30_ChallengeYourself.P37_RottingOranges;

public class Solution
{
    // Time complexity: O(mn), Space complexity: O(mn).
    public static int MinMinutesToRot(int[][] grid)
    {
        int rows = grid.Length, cols = grid[0].Length;

        int fresh = 0;
        var rotten = new List<(int, int)>();

        for (int r = 0; r != rows; r++)
        {
            for (int c = 0; c != cols; c++)
            {
                if (grid[r][c] == 2) { rotten.Add((r, c)); }
                if (grid[r][c] == 1) { fresh++; }
            }
        }

        for (int minutes = 0; ; minutes++)
        {
            if (fresh == 0) { return minutes; }
            if (rotten.Count == 0) { return -1; }

            var newRotten = new List<(int, int)>();
            foreach ((int r, int c) in rotten)
            {
                if (r != 0 && grid[r - 1][c] == 1) { grid[r - 1][c] = 2; fresh--; newRotten.Add((r - 1, c)); }
                if (r != rows - 1 && grid[r + 1][c] == 1) { grid[r + 1][c] = 2; fresh--; newRotten.Add((r + 1, c)); }
                if (c != 0 && grid[r][c - 1] == 1) { grid[r][c - 1] = 2; fresh--; newRotten.Add((r, c - 1)); }
                if (c != cols - 1 && grid[r][c + 1] == 1) { grid[r][c + 1] = 2; fresh--; newRotten.Add((r, c + 1)); }
            }

            rotten = newRotten;
        }
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([[1, 1, 2], [1, 0, 0], [1, 1, 1]], 6);
        Run([[1, 1, 2], [1, 1, 1], [1, 1, 1]], 4);
        Run([[1, 1, 2], [0, 0, 0], [1, 1, 1]], -1);
    }

    private static void Run(int[][] grid, int expectedResult)
    {
        int result = Solution.MinMinutesToRot(grid);
        Utilities.PrintSolution(grid, result);
        Assert.AreEqual(expectedResult, result);
    }
}
