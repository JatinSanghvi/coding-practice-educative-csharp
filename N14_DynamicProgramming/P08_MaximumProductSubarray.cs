// Maximum Product Subarray
// ========================
//
// Given an integer array, `nums`, find a subarray that has the largest product, and return the product.
//
// Constraints:
//
// - 1 ≤ `nums.length` ≤ 10^3
// - -10 ≤ `nums[i]` ≤ 10
// - The product of any prefix or suffix of `nums` is guaranteed to fit in a 32-bit integer.

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N14_DynamicProgramming.P08_MaximumProductSubarray;

public class Solution
{
    // Time complexity: O(n), Space complexity: O(1).
    public static int MaxProduct(int[] nums)
    {
        int maxTill = nums[0], minTill = nums[0];
        int maxAll = nums[0];

        for (int i = 1; i != nums.Length; i++)
        {
            int num = nums[i];
            (maxTill, minTill) = (
                Math.Max(num, num * (num < 0 ? minTill : maxTill)),
                Math.Min(num, num * (num < 0 ? maxTill : minTill)));

            maxAll = Math.Max(maxAll, maxTill);
        }

        return maxAll;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([-1, 2, -3, 4, -5, 0], 120);
    }

    private static void Run(int[] nums, int expectedResult)
    {
        int result = Solution.MaxProduct(nums);
        Utilities.PrintSolution(nums, result);
        Assert.AreEqual(expectedResult, result);
    }
}
