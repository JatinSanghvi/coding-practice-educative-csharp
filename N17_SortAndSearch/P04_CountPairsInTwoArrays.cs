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

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N17_SortAndSearch.P04_CountPairsInTwoArrays;

public class Solution
{
    // Time complexity: O(n*logn), Space complexity: O(n).
    public static int CountPairs(int[] nums1, int[] nums2)
    {
        var diffs = new int[nums1.Length];
        for (int i = 0; i != diffs.Length; i++)
        {
            diffs[i] = nums1[i] - nums2[i];
        }

        Array.Sort(diffs);

        int pairs = 0;
        int low = 0, high = diffs.Length - 1;
        while (low != high)
        {
            if (diffs[low] + diffs[high] > 0)
            {
                pairs += high - low;
                high--;
            }
            else
            {
                low++;
            }
        }

        return pairs;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([1, 2, 3, 4], [4, 3, 2, 1], 2);
    }

    private static void Run(int[] nums1, int[] nums2, int expectedResult)
    {
        int result = Solution.CountPairs(nums1, nums2);
        Utilities.PrintSolution((nums1, nums2), result);
        Assert.AreEqual(expectedResult, result);
    }
}
