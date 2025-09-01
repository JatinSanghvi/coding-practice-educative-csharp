// Two Sum Less Than K
// ===================
//
// Given an array of integers, `nums`, and an integer `k`, find the maximum sum of two elements in `nums` less than `k`.
// Otherwise, return -1 if no such pair exists.
//
// Constraints:
//
// - 1 ≤ `nums.length` ≤ 100
// - 1 ≤ `nums[i]` ≤ 10^3
// - 1 ≤ `k` ≤ 10^3

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N17_SortAndSearch.P15_TwoSumLessThanK;

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
