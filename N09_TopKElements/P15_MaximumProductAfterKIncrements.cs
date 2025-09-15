// Maximum Product After K Increments
// ==================================
//
// You are given an array, `nums`, consisting of non-negative integers, and an integer `k` representing the maximum
// number of allowed operations.
//
// In each operation, you may select any element in `nums` and increment it by 1. You can perform, at most, `k` such
// operations.
//
// Your task is to maximize the product of all elements in the array after performing up to `k` operations. As the
// resulting product can be very large, return the product modulo 10^9 + 7.
//
// > Note: Ensure that the product is maximized before applying the modulo operation.
//
// Constraints:
//
// - 1 ≤ `nums.length`, k ≤ 10^3
// - 0 ≤ `nums[i]` ≤ 10^3

using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N09_TopKElements.P15_MaximumProductAfterKIncrements;

public class Solution
{
    // Time complexity: O((n+k)*logn), Space complexity: O(n).
    public int MaximumProduct(int[] nums, int k)
    {
        var numHeap = new PriorityQueue<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            numHeap.Enqueue(i, nums[i]);
        }

        for (int j = 0; j < k; j++)
        {
            int i = numHeap.Dequeue();
            nums[i]++;
            numHeap.Enqueue(i, nums[i]);
        }

        long product = 1;
        for (int i = 0; i < nums.Length; i++)
        {
            product = (product * nums[i]) % 1_000_000_007;
        }

        return (int)product;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([1, 2, 3], 3, 27);
    }

    private static void Run(int[] nums, int k, int expectedResult)
    {
        int[] numsCopy = nums.ToArray();
        int result = new Solution().MaximumProduct(nums, k);
        Utilities.PrintSolution((numsCopy, k), result);
        Assert.AreEqual(expectedResult, result);
    }
}
