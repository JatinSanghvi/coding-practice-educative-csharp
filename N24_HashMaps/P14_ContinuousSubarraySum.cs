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
// > - An integer `x` is a multiple of `k` if there exists an integer `n` such that `x = n * k`. Note that `0` is always
// >   considered a multiple of `k`.
//
// Constraints:
//
// - 1 ≤ `nums.length` ≤ 10^4
// - 0 ≤ `nums[i]` ≤ 10^5
// - 0 ≤ `sum(nums[i])` ≤ 2^31 - 1
// - 1 ≤ `k` ≤ 2^31 - 1

using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N24_HashMaps.P14_ContinuousSubarraySum;

public class Solution
{
    // Time complexity: O(n), Space complexity: O(min(n, k)).
    public bool checkSubarraySum(List<int> nums, int k)
    {
        var remainders = new HashSet<int>();
        int currRem = 0;

        foreach (int num in nums)
        {
            int prevRem;
            (prevRem, currRem) = (currRem, (currRem + num) % k);
            if (remainders.Contains(currRem))
            {
                return true;
            }

            remainders.Add(prevRem);
        }

        return false;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([5, 1, 2, 3], 5, true); // 2 + 3
        Run([5, 1, 2, 4], 5, false);
        Run([5, 1, 2, 5], 5, false);
        Run([5, 1, 2, 7], 5, true); // 1 + 2 + 7
        Run([5, 1, 5, 5], 5, true); // 5 + 5
    }

    private static void Run(int[] nums, int k, bool expectedResult)
    {
        bool result = new Solution().checkSubarraySum(nums.ToList(), k);
        Utilities.PrintSolution((nums, k), result);
        Assert.AreEqual(expectedResult, result);
    }
}
