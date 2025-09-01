// Continuous Subarray Sum
// =======================
//
// Given an integer array `nums` and an integer `k`, determine if `nums` contains a good subarray. Return `true` if such
// a subarray exists; otherwise, return `false`.
//
// A subarray of `nums` is considered good if:
//
// - Its length is at least 2.
// - The sum of its elements is a multiple of `k`.
//
// > Notes:
//
// > - A subarray is defined as a contiguous sequence of elements within an array.
//
//
// > - An integer `x` is a multiple of `k` if there exists an integer `n` such that `x = n * k`. Note that `0` is always
// >   considered a multiple of `k`.
//
// Constraints:
//
// - 1 ≤ `nums.length` ≤ 10^4
// - 0 ≤ `nums[i]` ≤ 10^5
// - 0 ≤ `sum(nums[i])` ≤ 2^31 - 1
// - 1 ≤ `k` ≤ 2^31 - 1

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N24_HashMaps.P14_ContinuousSubarraySum;

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
