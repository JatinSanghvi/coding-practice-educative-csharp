// Number of Islands
// =================
//
// Let's consider a scenario with an (m×n) 2D grid containing binary numbers, where `'0'` represents water and `'1'`
// represents land. If any `'1'` cells are connected to each other horizontally or vertically (not diagonally), they
// form an island. Your task is to return the total number of islands in the grid.
//
// Constraints:
//
// - 1 ≤ `grid.length` ≤ 50
// - 1 ≤ `grid[i].length` ≤ 50
// - `grid[i][j]` is either `'0'` or `'1'`.

using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N26_UnionFind.P02_NumberOfIslands;

public class Solution
{
    // Time complexity: O(m*n), Space complexity: O(m*n).
    public static int NumIslands(char[][] grid)
    {
        int rows = grid.Length;
        int cols = grid[0].Length;

        var parents = new Dictionary<(int, int), (int, int)>();
        var ranks = new Dictionary<(int, int), int>();
        int islands = 0;

        for (int row = 0; row != rows; row++)
        {
            for (int col = 0; col != cols; col++)
            {
                if (grid[row][col] == '1')
                {
                    parents[(row, col)] = (row, col);
                    ranks[(row, col)] = 1;
                    islands++;
                }
            }
        }

        for (int row = 0; row != rows; row++)
        {
            for (int col = 0; col != cols; col++)
            {
                if (row != rows - 1 && Union((row, col), (row + 1, col))) { islands--; }
                if (col != cols - 1 && Union((row, col), (row, col + 1))) { islands--; }
            }
        }

        return islands;

        bool Union((int, int) x1, (int, int) x2)
        {
            if (!parents.ContainsKey(x1) || !parents.ContainsKey(x2)) { return false; }

            (int, int) p1 = Find(x1);
            (int, int) p2 = Find(x2);

            if (p1 == p2) { return false; }

            if (ranks[p1] >= ranks[p2])
            {
                parents[p2] = p1;
                if (ranks[p1] == ranks[p2]) { ranks[p1]++; }
            }
            else
            {
                parents[p1] = p2;
            }

            return true;
        }

        (int, int) Find((int, int) x)
        {
            if (parents[x] != x)
            {
                parents[x] = Find(parents[x]);
            }

            return parents[x];
        }
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([
            ['1', '1', '0', '1'],
            ['0', '0', '1', '1'],
            ['1', '1', '0', '0'],
            ['1', '0', '1', '1']],
            4);

        Run([
            ['1', '1', '0', '1'],
            ['0', '1', '1', '1'],
            ['1', '1', '1', '0'],
            ['1', '0', '1', '1']],
            1);
    }

    private static void Run(char[][] grid, int expectedResult)
    {
        int result = Solution.NumIslands(grid);
        Utilities.PrintSolution(grid, result);
        Assert.AreEqual(expectedResult, result);
    }
}
