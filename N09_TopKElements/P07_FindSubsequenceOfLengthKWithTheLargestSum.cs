// Find Subsequence of Length K with the Largest Sum
// =================================================
//
// You are given an integer array `nums` and an integer `k`. Your task is to find a subsequence of `nums` of length `k`
// that has the largest possible sum.
//
// Constraints:
//
// - 1 ≤ `nums.length` ≤ 1000
// - -10^5 ≤ `nums[i]` ≤ 10^5
// - 1 ≤ k ≤ `nums.length`

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N09_TopKElements.P07_FindSubsequenceOfLengthKWithTheLargestSum;

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
