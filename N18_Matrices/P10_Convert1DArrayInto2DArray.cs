// Convert 1D Array Into 2D Array
// ==============================
//
// Given a 0-indexed 1-dimensional (1D) integer array `original` and two integers, `m` and `n`, your task is to reshape
// the array into a 2-dimensional (2D) array with `m` rows and `n` columns while preserving the order of elements in
// `original`.
//
// To construct the 2D array, the first `n` elements in the `original` should populate the first row. The next `n`
// elements should populate the second row, and so on, until all rows are filled. Your goal is to return the resulting
// `m x n` 2D array.
//
// > Note: If it is impossible to create an `m x n` array (e.g., if the total number of elements in the `original` is
// > not equal to `m * n`), return an empty 2D array.
//
// Constraints:
//
// - 1 ≤ `original.length` ≤ 10^3
// - 1 ≤ `original[i]` ≤ 10^3
// - 1 ≤ `m`, `n` ≤ 3

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N18_Matrices.P10_Convert1DArrayInto2DArray;

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
