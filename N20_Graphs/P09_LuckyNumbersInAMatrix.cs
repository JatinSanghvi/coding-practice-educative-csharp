// Lucky Numbers in a Matrix
// =========================
//
// Given an m × n matrix of distinct numbers, return the lucky number in the matrix.
//
// > A lucky number is an element of the matrix such that it is the smallest element in its row and largest in its
// > column.
//
// Constraints:
//
// - m = `matrix.length`
// - n = `matrix[i].length`
// - 1 ≤ n, m ≤ 50
// - 1 ≤ `matrix[i][j]` ≤ 10^5
// - All elements in the `matrix` are distinct.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N20_Graphs.P09_LuckyNumbersInAMatrix;

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
