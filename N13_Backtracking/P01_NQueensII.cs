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
