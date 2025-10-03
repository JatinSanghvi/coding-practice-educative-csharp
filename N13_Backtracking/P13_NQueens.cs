// N-Queens
// ========
//
// The N-Queens puzzle is a classic problem in which the goal is to place `n` queens on an `n` × `n` chessboard so that
// no two queens can attack each other.
//
// In chess, a queen can move any number of squares *horizontally*, *vertically*, or *diagonally*. Therefore, no two
// queens can be placed in the same row, column, or diagonal.
//
// Given an integer `n`, return all distinct valid arrangements of `n` queens on the board. Each arrangement should be
// represented as a list of strings, where each string corresponds to a row of the board. Within each string, `'Q'`
// denotes a queen and `'.'` denotes an empty square.
//
// > Note: You can return the solutions in any order.
//
// Constraints:
//
// - 1 ≤ `n` ≤ 9

using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N13_Backtracking.P13_NQueens;

public class Solution
{
    // Time complexity: O(n!), Space complexity: O(n^2).
    public IList<IList<string>> SolveNQueens(int n)
    {
        var colFilled = new bool[n];
        var diag1Filled = new bool[2 * n - 1];
        var diag2Filled = new bool[2 * n - 1];

        var board = new char[n][];
        for (int row = 0; row < n; row++)
        {
            board[row] = new char[n];
            for (int col = 0; col < n; col++)
            {
                board[row][col] = '.';
            }
        }

        var arrangements = new List<IList<string>>();
        Solve(0);
        return arrangements;

        void Solve(int row)
        {
            if (row == n)
            {
                arrangements.Add(board.Select(rank => new string(rank)).ToList());
                return;
            }

            for (int col = 0; col < n; col++)
            {
                if (!(colFilled[col] || diag1Filled[row + col] || diag2Filled[row + (n - 1 - col)]))
                {
                    (colFilled[col], diag1Filled[row + col], diag2Filled[row + (n - 1 - col)]) = (true, true, true);
                    board[row][col] = 'Q';

                    Solve(row + 1);

                    (colFilled[col], diag1Filled[row + col], diag2Filled[row + (n - 1 - col)]) = (false, false, false);
                    board[row][col] = '.';
                }
            }
        }
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run(1, [["Q"]]);
        Run(2, []);
        Run(4, [[".Q..", "...Q", "Q...", "..Q."], ["..Q.", "Q...", "...Q", ".Q.."]]);
    }

    private static void Run(int n, string[][] expectedResult)
    {
        string[][] result = new Solution().SolveNQueens(n).Select(board => board.ToArray()).ToArray();
        Utilities.PrintSolution(n, result);
        CollectionAssert.AreEqual(expectedResult, result);
    }
}
