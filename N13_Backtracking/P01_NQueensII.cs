// N-Queens II
// ===========
//
// Given an integer, `n`, representing the size of an `n x n` chessboard, return the number of distinct ways to place
// `n` queens so that no two queens attack each other. A queen can attack another queen if they are in the same row,
// column, or diagonal.
//
// Constraints:
//
// - 1 ≤ `n` ≤ 9

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N13_Backtracking.P01_NQueensII;

public class Solution
{
    // Time complexity: O(n!), Space complexity: O(n).
    public static int TotalNQueens(int n)
    {
        var colFilled = new bool[n];
        var diagFilled = new bool[2 * n - 1];
        var diag2Filled = new bool[2 * n - 1];

        return Solve(0);

        int Solve(int row)
        {
            if (row == n) { return 1; }

            int positions = 0;
            for (int col = 0; col < n; col++)
            {
                if (!(colFilled[col] || diagFilled[row + col] || diag2Filled[row + (n - 1 - col)]))
                {
                    (colFilled[col], diagFilled[row + col], diag2Filled[row + (n - 1 - col)]) = (true, true, true);
                    positions += Solve(row + 1);
                    (colFilled[col], diagFilled[row + col], diag2Filled[row + (n - 1 - col)]) = (false, false, false);
                }
            }

            return positions;
        }
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run(1, 1);
        Run(8, 92);
    }

    private static void Run(int n, int expectedResult)
    {
        int result = Solution.TotalNQueens(n);
        Utilities.PrintSolution(n, result);
        Assert.AreEqual(expectedResult, result);
    }
}
