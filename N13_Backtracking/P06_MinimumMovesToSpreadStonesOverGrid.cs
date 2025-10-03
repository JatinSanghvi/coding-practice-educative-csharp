// Minimum Moves to Spread Stones Over Grid
// ========================================
//
// Given a 2D grid of integers of size (3 × 3), where each value represents the number of stones in the given cell,
// return the minimum number of moves required to place exactly one stone in each grid cell.
//
// Constraints:
//
// - Only one stone can be moved in one move.
// - Stone from a cell can only be moved to another cell if they are adjacent (share a side).
// - The sum of all stones in the grid must be equal to 9.
// - `grid.length`, `grid[i].length` == 3
// - 0 ≤ `grid[i][j]` ≤ 9


using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N13_Backtracking.P06_MinimumMovesToSpreadStonesOverGrid;

public class Solution
{
    // Time complexity: O((9/2)!), Space complexity: O(9).
    public static int MinimumMoves(int[][] grid)
    {
        var zeros = new List<int>();
        var extras = new Dictionary<int, int>();

        for (int tr = 0; tr < 3; tr++)
        {
            for (int tc = 0; tc < 3; tc++)
            {
                if (grid[tr][tc] == 0) { zeros.Add(3 * tr + tc); }
                if (grid[tr][tc] > 1) { extras[3 * tr + tc] = grid[tr][tc] - 1; }
            }
        }

        int minMoves = int.MaxValue;
        Solve(0, 0);
        return minMoves;

        void Solve(int i, int moves)
        {
            if (i == zeros.Count)
            {
                minMoves = Math.Min(minMoves, moves);
            }

            foreach (int j in extras.Keys)
            {
                if (extras[j] != 0)
                {
                    int distance = Math.Abs(zeros[i] / 3 - j / 3) + Math.Abs(zeros[i] % 3 - j % 3);
                    extras[j]--;
                    Solve(i + 1, moves + distance);
                    extras[j]++;
                }
            }
        }
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([[3, 0, 0], [0, 3, 0], [0, 0, 3]], 8);
    }

    private static void Run(int[][] grid, int expectedResult)
    {
        int result = Solution.MinimumMoves(grid);
        Utilities.PrintSolution(grid, result);
        Assert.AreEqual(expectedResult, result);
    }
}
