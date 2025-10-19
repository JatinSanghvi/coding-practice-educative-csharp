// Where Will the Ball Fall
// ========================
//
// You have n balls and a 2D grid of size m × n representing a box. The box is open on the top and bottom sides. Each
// cell in the box has a diagonal that can redirect a ball to the right or the left. You must drop n balls at each
// column's top. The goal is to determine whether each ball will fall out of the bottom or become stuck in the box. Each
// cell in the grid has a value of 1 or -1.
//
// - 1 represents that the grid will redirect the ball to the right.
// - -1 represents that the grid will redirect the ball to the left.
//
// A ball gets stuck if it hits a V-shaped pattern between two grids or if a grid redirects the ball into either wall of
// the box.
//
// The solution should return an array of size n, with the i-th element indicating the column that the ball falls out
// of, or it becomes -1 if it's stuck. If the ball drops from column x and falls out from column y, then in the result
// array, index x contains value y.
//
// Constraints:
//
// - m == `grid.length`
// - n == `grid[i].length`
// - 1 ≤ m, n ≤ 100
// - `grid[i][j]` is 1 or -1.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N18_Matrices.P04_WhereWillTheBallFall;

public class Solution
{
    // Time complexity: O(r*c), Space complexity: O(1).
    public static int[] FindExitColumn(int[][] grid)
    {
        int rows = grid.Length, cols = grid[0].Length;
        var exitColumns = new int[cols];

        for (int startCol = 0; startCol != cols; startCol++)
        {
            int nextCol = startCol;
            int row;
            for (row = 0; row != rows; row++)
            {
                int col = nextCol;
                nextCol = col + grid[row][col];

                if (nextCol == -1 || nextCol == cols || grid[row][nextCol] != grid[row][col])
                {
                    nextCol = -1;
                    break;
                }
            }

            exitColumns[startCol] = nextCol;
        }

        return exitColumns;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([[1, 1, 1], [-1, -1, -1], [1, 1, 1]], [1, 2, -1]);
        Run([[-1, -1, -1], [1, 1, 1], [-1, -1, -1]], [-1, 0, 1]);
        Run([[1, 1, -1], [1, 1, -1], [1, 1, -1]], [-1, -1, -1]);
    }

    private static void Run(int[][] grid, int[] expectedResult)
    {
        int[] result = Solution.FindExitColumn(grid);
        Utilities.PrintSolution(grid, result);
        CollectionAssert.AreEqual(expectedResult, result);
    }
}
