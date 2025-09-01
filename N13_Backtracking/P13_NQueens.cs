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

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N13_Backtracking.P13_NQueens;

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
