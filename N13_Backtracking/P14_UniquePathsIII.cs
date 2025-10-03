// Unique Paths III
// ================
//
// You are given a  m × n  integer array, `grid`, where each cell, `grid[i][j]`, can have one of the following values:
//
// - `1` indicates the starting point. There is exactly one such square.
// - `2` marks the ending point. There is exactly one such square.
// - `0` represents empty squares that can be walked over.
// - `-1` represents obstacles that cannot be crossed.
//
// Your task is to return the total number of unique four-directional paths from the starting square (`1`) to the ending
// square (`2`), such that every empty square is visited exactly once during the walk.
//
// Constraints:
//
// - m == `grid.length`
// - n == `grid[i].length`
// - 1 ≤ m, n ≤ 20
// - 1 ≤ m × n ≤ 20
// - -1 ≤ `grid[i][j]` ≤ 2
// - There is exactly one starting cell and one ending cell.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N13_Backtracking.P14_UniquePathsIII;

public class Solution
{
    // Time complexity: O(4^mn), Space complexity: O(mn).
    public static int UniquePathsIII(int[][] grid)
    {
        int rows = grid.Length, cols = grid[0].Length;

        int startRow = 0, startCol = 0;
        int emptyCount = 0;
        for (int row = 0; row != rows; row++)
        {
            for (int col = 0; col != cols; col++)
            {
                if (grid[row][col] == 1)
                {
                    startRow = row;
                    startCol = col;
                    emptyCount++;
                }

                if (grid[row][col] == 0)
                {
                    emptyCount++;
                }
            }
        }

        var visited = new bool[rows, cols];
        return Solve(startRow, startCol, 0);

        int Solve(int row, int col, int visitCount)
        {
            if (row == -1 || row == rows || col == -1 || col == cols || grid[row][col] == -1 || visited[row, col])
            {
                return 0;
            }

            if (grid[row][col] == 2)
            {
                return visitCount == emptyCount ? 1 : 0;
            }

            visited[row, col] = true;

            int paths =
                Solve(row - 1, col, visitCount + 1) +
                Solve(row, col - 1, visitCount + 1) +
                Solve(row, col + 1, visitCount + 1) +
                Solve(row + 1, col, visitCount + 1);

            visited[row, col] = false;
            return paths;
        }
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([[1, 0, 0, 0], [0, 0, 0, 0], [2, 0, 0, -1]], 2);
    }

    private static void Run(int[][] grid, int expectedResult)
    {
        int result = Solution.UniquePathsIII(grid);
        Utilities.PrintSolution(grid, result);
        Assert.AreEqual(expectedResult, result);
    }
}
