// Range Sum of Sorted Subarray Sums
// =================================
//
// You are given an integer array `nums` containing n positive integers along with `left` and `right`. Calculate the sum
// of its elements for every non-empty continuous subarray of `nums`. Collect these sums into a new array and sort it in
// nondecreasing order. This will result in a new array of size n × (n + 1) / 2.
//
// Your task is to return the sum of the elements in this sorted array from the index `left` to `right` (inclusive with
// 1-based indexing).
//
// > Note: As the result can be large, return the sum modulo 10^9 + 7.
//
// Constraints:
//
// - n == `nums.length`
// - 1 ≤ `nums.length` ≤ 1000
// - 1 ≤ `nums[i]` ≤ 100
// - 1 ≤ `left` ≤ `right` ≤ n × (n + 1) / 2

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N17_SortAndSearch.P08_RangeSumOfSortedSubarraySums;

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
