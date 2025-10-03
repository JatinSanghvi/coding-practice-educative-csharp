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

using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N13_Backtracking.P15_SudokuSolver;

public class Solution
{
    // Time complexity: O(9!) for first row and it gets smaller with each row, Space complexity: O(1).
    public static char[][] SolveSudoku(char[][] board)
    {
        var rowContains = new bool[9, 10];
        var colContains = new bool[9, 10];
        var boxContains = new bool[9, 10];

        for (int row = 0; row < 9; row++)
        {
            for (int col = 0; col < 9; col++)
            {
                if (board[row][col] != '.')
                {
                    int val = board[row][col] - '0';
                    int box = 3 * (row / 3) + col / 3;
                    (rowContains[row, val], colContains[col, val], boxContains[box, val]) = (true, true, true);
                }
            }
        }

        Solve(0, 0);
        return board;

        bool Solve(int row, int col)
        {
            if (row == 9) { return true; }

            if (board[row][col] != '.')
            {
                return Solve(row + (col + 1) / 9, (col + 1) % 9);
            }

            int box = 3 * (row / 3) + col / 3;
            for (int val = 1; val != 10; val++)
            {
                if (!(rowContains[row, val] || colContains[col, val] || boxContains[box, val]))
                {
                    board[row][col] = (char)('0' + val);
                    (rowContains[row, val], colContains[col, val], boxContains[box, val]) = (true, true, true);

                    bool solved = Solve(row + (col + 1) / 9, (col + 1) % 9);
                    if (solved) { return true; }

                    board[row][col] = '.';
                    (rowContains[row, val], colContains[col, val], boxContains[box, val]) = (false, false, false);
                }
            }

            return false;
        }
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run(
            [
                ['.', '.', '.', '.', '.', '.', '.', '7', '.'],
                ['2', '7', '5', '.', '.', '.', '3', '1', '4'],
                ['.', '.', '.', '.', '2', '7', '.', '5', '.'],
                ['9', '8', '.', '.', '.', '.', '.', '3', '1'],
                ['.', '3', '1', '8', '.', '4', '.', '.', '.'],
                ['.', '.', '.', '1', '.', '.', '8', '.', '5'],
                ['7', '.', '6', '2', '.', '.', '1', '8', '.'],
                ['.', '9', '.', '7', '.', '.', '.', '.', '.'],
                ['4', '1', '.', '.', '.', '5', '.', '.', '7']
            ],
            [
                ['8', '6', '3', '4', '5', '1', '2', '7', '9'],
                ['2', '7', '5', '9', '8', '6', '3', '1', '4'],
                ['1', '4', '9', '3', '2', '7', '6', '5', '8'],
                ['9', '8', '7', '5', '6', '2', '4', '3', '1'],
                ['5', '3', '1', '8', '9', '4', '7', '6', '2'],
                ['6', '2', '4', '1', '7', '3', '8', '9', '5'],
                ['7', '5', '6', '2', '4', '9', '1', '8', '3'],
                ['3', '9', '2', '7', '1', '8', '5', '4', '6'],
                ['4', '1', '8', '6', '3', '5', '9', '2', '7']
            ]);
    }

    private static void Run(char[][] board, char[][] expectedResult)
    {
        char[][] boardCopy = board.Select(row => row.ToArray()).ToArray();
        char[][] result = Solution.SolveSudoku(board);
        Utilities.PrintSolution(boardCopy, result);
        CollectionAssert.AreEqual(expectedResult, result);
    }
}
