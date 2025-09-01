// Count Pairs in Two Arrays
// =========================
//
// You are given two positive integer arrays, `nums1` and `nums2`, both of length n. Your task is to count and return
// the number of pairs of indexes (i, j) where:
//
// - i < j, and
// - `nums1[i] + nums1[j] > nums2[i] + nums2[j]`
//
// In simpler terms, the sum of two elements from `nums1` must be greater than that of the corresponding elements from
// `nums2`.
//
// Constraints:
//
// - n == `nums1.length` == `nums2.length`
// - 1 ≤ n ≤ 10^3
// - 1 ≤ `nums1[i]`, `nums2[i]` ≤ 10^4

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N17_SortAndSearch.P04_CountPairsInTwoArrays;

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
