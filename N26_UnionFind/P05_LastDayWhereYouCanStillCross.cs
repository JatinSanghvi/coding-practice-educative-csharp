// Last Day Where You Can Still Cross
// ==================================
//
// You are given two integers, `rows` and `cols`, which represent the number of rows and columns in a 1-based binary
// matrix. In this matrix, each 0 represents land, and each 1 represents water.
//
// Initially, on day 0, the whole matrix will just be all 0s, that is, all land. With each passing day, one of the cells
// of this matrix will get flooded and, therefore, will change to water, that is, from 0 to 1. This continues until the
// entire matrix is flooded. You are given a 1-based array, `waterCells`, that records which cell will be flooded on
// each day. Each element `waterCells[i] = [r_i, c_i]` indicates the cell present at the `r_i`-th row and `c_i`-th
// column of the matrix that will change from land to water on the i-th day.
//
// We can cross any cell of the matrix as long as it's land. Once it changes to water, we can't cross it. To cross any
// cell, we can only move in one of the four cardinal directions. Given the number of rows and columns of a 1-based
// binary matrix and a 1-based array, `waterCells`, you are required to find the last day where you can still cross the
// matrix, from top to bottom, by walking over the land cells only.
//
// > Note: You can start from any cell in the top row, and you need to be able to reach just one cell in the bottom row
// > for it to count as a crossing.
//
// Constraints:
//
// - 2 ≤ `rows`, `cols` ≤ 50
// - 4 ≤ `rows` × `cols` ≤ 2500
// - `waterCells.length` == `rows` × `cols`
// - 1 ≤ r_i ≤ `rows`
// - 1 ≤ c_i ≤ `cols`
// - All values of `waterCells` are unique.

using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N26_UnionFind.P05_LastDayWhereYouCanStillCross;

public class Solution
{
    // Time complexity: O(r*w), Space complexity: O(r*w).
    public static int LastDayToCross(int rows, int cols, int[][] waterCells)
    {
        // If left and right cells are connected by water, there is no path to reach from top to bottom.
        // Conversely, if the cells are not connected, there is always a path to reach from top to bottom.
        (int, int) left = (0, 0), right = (0, cols + 1);

        var parents = new Dictionary<(int, int), (int, int)>(rows * cols + 2) { [left] = left, [right] = right };
        var ranks = new Dictionary<(int, int), int>(rows * cols + 2) { [left] = 1, [right] = 1 };

        for (int r = 1; r != rows + 1; r++)
        {
            for (int c = 1; c != cols + 1; c++)
            {
                parents[(r, c)] = (r, c);
                ranks[(r, c)] = 1;
            }
        }

        (int, int)[] diffs = [(-1, -1), (-1, 0), (-1, 1), (0, -1), (0, 1), (1, -1), (1, 0), (1, 1)];
        var flooded = new HashSet<(int, int)>();

        int days = 0;
        foreach (int[] cell in waterCells)
        {
            int r1 = cell[0], c1 = cell[1];
            flooded.Add((r1, c1));

            foreach ((int dr, int dc) in diffs)
            {
                int r2 = r1 + dr, c2 = c1 + dc;
                if (r2 != 0 && r2 != rows + 1 && c2 != 0 && c2 != cols + 1 && flooded.Contains((r2, c2)))
                {
                    Union((r1, c1), (r2, c2));
                }

                if (c1 == 1) { Union((r1, c1), left); }
                if (c1 == cols) { Union((r1, c1), right); }
            }

            if (Find(left) == Find(right))
            {
                return days;
            }

            days++;
        }

        throw new InvalidOperationException();

        void Union((int, int) x1, (int, int) x2)
        {
            (int, int) p1 = Find(x1);
            (int, int) p2 = Find(x2);

            if (p1 != p2)
            {
                if (ranks[p1] == ranks[p2]) { ranks[p1]++; }
                if (ranks[p1] >= ranks[p2]) { parents[p2] = p1; }
                else { parents[p1] = p2; }
            }
        }

        (int, int) Find((int, int) x)
        {
            if (parents[x] != x) { parents[x] = Find(parents[x]); }
            return parents[x];
        }
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run(2, 2, [[1, 1], [2, 1], [1, 2], [2, 2]], 2);
        Run(2, 2, [[2, 2], [1, 2], [2, 1], [1, 1]], 2);
        Run(2, 2, [[1, 1], [2, 2], [2, 1], [1, 2]], 1);
        Run(2, 2, [[2, 2], [1, 1], [2, 1], [1, 2]], 1);
    }

    private static void Run(int rows, int cols, int[][] waterCells, int expectedResult)
    {
        int result = Solution.LastDayToCross(rows, cols, waterCells);
        Utilities.PrintSolution((rows, cols, waterCells), result);
        Assert.AreEqual(expectedResult, result);
    }
}
