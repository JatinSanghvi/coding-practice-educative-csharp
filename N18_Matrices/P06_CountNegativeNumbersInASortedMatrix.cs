// Count Negative Numbers in a Sorted Matrix
// =========================================
//
// Given a matrix `grid` of size m × n, where each row and column is sorted in non-increasing order, find and return the
// total count of negative numbers in the matrix.
//
// Constraints:
//
// - m == `grid.length`
// - n == `grid[i].length`
// - 1 ≤ m, n ≤ 1000
// - -100 ≤ `grid[i][j]` ≤ 100

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N18_Matrices.P06_CountNegativeNumbersInASortedMatrix;

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
