// Get the Maximum Score
// =====================
//
// You are given two sorted arrays of distinct integers, `nums1` and `nums2`.
//
// A *valid path* is constructed according to the following rules:
//
// - You start at the index 0 of either `nums1` or `nums2`.
// - From there, you must traverse the chosen array from left to right.
// - Suppose you encounter a number in both arrays (a common element, not necessarily at the same index). In that case,
//   you may choose to switch to the other array at that element and continue the traversal from that point forward.
// - A common element can only be counted once in the total path score, regardless of the array it appears.
//
// The score of a path is defined as the sum of all unique elements visited during traversal. Your task is to return the
// maximum possible score achievable by any valid path. As the answer may be too large, return the maximum score modulo
// 10^9 + 7.
//
// Constraints:
//
// - 1 ≤ `nums1.length`, `nums2.length` ≤ 10^5
// - 1 ≤ `nums1[i]`, `nums2[i]` ≤ 10^7
// - All elements in `nums1` and `nums2` are strictly increasing.

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N02_TwoPointers.P13_GetTheMaximumScore;

public class Solution
{
    public int MaxSum(int[] nums1, int[] nums2)
    {
        long maxSum = 0;
        long sum1 = 0, sum2 = 0;

        for (int index1 = 0, index2 = 0; index1 != nums1.Length || index2 != nums2.Length;)
        {
            int num1 = index1 < nums1.Length ? nums1[index1] : int.MaxValue;
            int num2 = index2 < nums2.Length ? nums2[index2] : int.MaxValue;

            if (num1 < num2)
            {
                sum1 += num1;
                index1++;
            }
            else if (num2 < num1)
            {
                sum2 += num2;
                index2++;
            }
            else
            {
                maxSum += Math.Max(sum1, sum2) + num1;
                sum1 = 0;
                sum2 = 0;
                index1++;
                index2++;
            }
        }

        maxSum += Math.Max(sum1, sum2);
        return (int)(maxSum % 1_000_000_007);
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run(new[] { 1 }, new[] { 2, 3 }, 5);
        Run(new[] { 1, 3, 4, 5, 6, 8 }, new[] { 1, 2, 4, 5, 7, 8 }, 28);
    }

    private static void Run(int[] nums1, int[] nums2, int expectedResult)
    {
        int result = new Solution().MaxSum(nums1, nums2);
        Utilities.PrintSolution((nums1, nums2), result);
        Assert.AreEqual(expectedResult, result);
    }
}
