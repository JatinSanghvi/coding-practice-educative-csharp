// Kth Smallest Element in a Sorted Matrix
// =======================================
//
// Find the kth smallest element in an (n × n) matrix, where each row and column of the matrix is sorted in ascending
// order.
//
// Although there can be repeating values in the matrix, each element is considered unique and, therefore, contributes
// to calculating the kth smallest element.
//
// Constraints:
//
// - `n` == `matrix.length`
// - `n` == `matrix[i].length`
// - 1 ≤ `n` ≤ 100
// - -10^3 ≤ `matrix[i][j]` ≤ 10^3
// - 1 ≤ `k` ≤ n^2

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N08_KWayMerge.P05_KthSmallestElementInASortedMatrix;

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
