// Kth Smallest Number in Multiplication Table
// ===========================================
//
// You are given a multiplication table of size `m` × `n`, where each element at position `mat[i][j]` is calculated as i
// × j (with 1-based indexing).
//
// Your task is to find the k-th smallest element in this table, given the `m`, `n`, and `k` values.
//
// Constraints:
//
// - 1 ≤ `m`, `n` ≤ 3 × 10^4
// - 1 ≤ `k` ≤ `m` × `n`

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N18_Matrices.P15_KthSmallestNumberInMultiplicationTable;

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
