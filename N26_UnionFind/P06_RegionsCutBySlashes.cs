// Regions Cut by Slashes
// ======================
//
// An n×n grid is composed of n, 1×1 squares, where each 1×1 square consists of a "/", "\", or a blank space. These
// characters divide the square into adjacent regions.
//
// Given the grid represented as a string array, return the number of adjacent regions.
//
// > Note:
//
// > 1. Backslash characters are escaped, so "\" is represented as "\\".
// > 2. A 1×1 square in the grid will be referred to as a box.
//
// Constraints:
//
// - The grid consists of only the "/", "\\", or " " characters.
// - 1 ≤ `grid.length` ≤ 30

using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N26_UnionFind.P06_RegionsCutBySlashes;

public class Solution
{
    // Time complexity: O(n^2), Space complexity: O(n^2).
    public static int RegionsBySlashes(string[] grid)
    {
        // Divide each box into 4 sections by slicing it diagonally both ways. Each section connects with the section
        // from adjacent boxes to form diagonally oriented squares. If we assume the boxes to be of size 2x2, then the 
        // squares for the top left box will have points centered at (0, 1), (1, 0), (1, 2) and (2, 1).
        var parents = new Dictionary<(int, int), (int, int)>();
        var ranks = new Dictionary<(int, int), int>();

        int n = grid.Length;
        int joins = 0;

        for (int row = 0; row != n; row++)
        {
            for (int col = 0; col != n; col++)
            {
                (int, int)[] squares =
                [
                    (2 * row, 2 * col + 1),
                    (2 * row + 1, 2 * col),
                    (2 * row + 1, 2 * col + 2),
                    (2 * row + 2, 2 * col + 1),
                ];

                for (int i = 0; i != 4; i++)
                {
                    parents.TryAdd(squares[i], squares[i]);
                    ranks.TryAdd(squares[i], 1);
                }

                if (grid[row][col] != '\\')
                {
                    Union(squares[0], squares[1]);
                    Union(squares[2], squares[3]);
                }

                if (grid[row][col] != '/')
                {
                    Union(squares[0], squares[2]);
                    Union(squares[1], squares[3]);
                }
            }
        }

        return 2 * n * (n + 1) - joins;

        void Union((int, int) x1, (int, int) x2)
        {
            (int, int) p1 = Find(x1);
            (int, int) p2 = Find(x2);

            if (p1 == p2) { return; }

            if (ranks[p1] == ranks[p2]) { ranks[p1]++; }
            if (ranks[p1] >= ranks[p2]) { parents[p2] = p1; }
            else { parents[p1] = p2; }

            joins++;
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
        Run(["/\\", "\\/"], 5);
        Run(["\\/", "/\\"], 4);
        Run(["\\ ", " \\"], 2);
    }

    private static void Run(string[] grid, int expectedResult)
    {
        int result = Solution.RegionsBySlashes(grid);
        Utilities.PrintSolution(grid, result);
        Assert.AreEqual(expectedResult, result);
    }
}
