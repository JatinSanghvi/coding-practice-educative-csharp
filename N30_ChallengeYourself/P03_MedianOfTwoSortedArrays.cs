// Median of Two Sorted Arrays
// ===========================
//
// You're given two sorted integer arrays, `nums1` and `nums2`, of size m and n, respectively. Your task is to return
// the median of the two sorted arrays.
//
// The overall run time complexity should be O(log(m,n)).
//
// Constraints:
//
// - `nums1.length` == m
// - `nums2.length` == n
// - 0 ≤ m ≤ 1000
// - 0 ≤ n ≤ 1000
// - 1 ≤ m + n ≤ 2000
// - -10^5 ≤ `nums1[i]`, `nums2[i]` ≤ 10^5

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N30_ChallengeYourself.P03_MedianOfTwoSortedArrays;

public class Solution
{
    // Time complexity: O(log(m+n)), Space complexity: O(1).
    public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        int len = nums1.Length + nums2.Length;

        return len % 2 != 0 ? KthLowest(len / 2) : (KthLowest(len / 2 - 1) + KthLowest(len / 2)) / 2.0;

        int KthLowest(int k)
        {
            return KthLowest2(k, 0, nums1.Length, 0, nums2.Length);
        }

        int KthLowest2(int k, int low1, int high1, int low2, int high2)
        {
            int len1 = high1 - low1;
            int len2 = high2 - low2;

            if (len1 == 0) { return nums2[low2 + k]; }
            if (len2 == 0) { return nums1[low1 + k]; }
            if (k == 0) { return Math.Min(nums1[low1], nums2[low2]); }

            int k1 = k * len1 / (len1 + len2);
            int k2 = k - k1 - 1;

            if (nums1[low1 + k1] <= nums2[low2 + k2])
            {
                return KthLowest2(k2, low1 + k1 + 1, high1, low2, low2 + k2 + 1);
            }
            else
            {
                return KthLowest2(k1, low1, low1 + k1 + 1, low2 + k2 + 1, high2);
            }
        }
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([1, 3, 5], [2, 4], 3.0);
        Run([1, 2, 3], [4, 5], 3.0);
        Run([3, 4, 5], [1, 2], 3.0);

        Run([1, 3], [2, 4], 2.5);
        Run([1, 2], [3, 4], 2.5);
    }

    private static void Run(int[] nums1, int[] nums2, double expectedResult)
    {
        double result = Solution.FindMedianSortedArrays(nums1, nums2);
        Utilities.PrintSolution((nums1, nums2), result);
        Assert.AreEqual(expectedResult, result);
    }
}
