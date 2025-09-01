// Longest Subsequence With Limited Sum
// ====================================
//
// You are given an integer array, `nums`, of length `n`, and an integer array, `queries`, of length `m`.
//
// For each element in `queries`, determine the maximum number of elements that can be selected from `nums` to form a
// subsequence such that the sum of the selected elements is less than or equal to the query value.
//
// Return an array `answer` of length `m`, where `answer[i]` represents the size of the largest subsequence of `nums`
// whose sum is less than or equal to `queries[i]`.
//
// Constraints
//
// - n == `nums.length`
// - m == `queries.length`
// - 1 ≤ `n`, `m` ≤ 10^3
// - 1 ≤ `nums[i]`, `queries[i]` ≤ 10^5

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N17_SortAndSearch.P02_LongestSubsequenceWithLimitedSum;

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
