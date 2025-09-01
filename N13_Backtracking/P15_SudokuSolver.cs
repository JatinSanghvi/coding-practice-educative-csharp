// Sudoku Solver
// =============
//
// Given a 9 x 9 sudoku board, solve the puzzle by completing the empty cells. The sudoku board is only considered valid
// if the following rules are satisfied:
//
// - Each row must contain digits between 1 and 9, and there should be no repetition of digits within a row.
// - Each column must contain digits between 1 and 9, and there should be no repetition of digits within a column.
// - The board consists of 9 non-overlapping sub-boxes, each containing 3 rows and 3 columns. Each of these 3 x 3
//   sub-boxes must contain digits between 1 and 9, and there should be no repetition of digits within a sub-box.
//
// Constraints:
//
// - `board.length` == 9
// - `board[i].length` == 9
// - `board[i][j]` is a digit or `.`.
// - The input board is guaranteed to have one solution.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N13_Backtracking.P15_SudokuSolver;

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
