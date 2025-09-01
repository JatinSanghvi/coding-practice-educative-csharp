// Transpose Matrix
// ================
//
// Given a matrix represented as a 2D integer list, return its transpose. The transpose of a matrix is obtained by
// swapping its rows with its columns or vice versa.
//
// Constraints:
//
// - 1 ≤ `m`, `n` ≤ 100
// - -10^4 ≤ `matrix[i][j]` ≤ 10^4

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N18_Matrices.P05_TransposeMatrix;

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
