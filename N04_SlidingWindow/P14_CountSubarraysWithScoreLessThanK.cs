// Count Subarrays With Score Less Than K
// ======================================
//
// An array score is defined as the sum of the array elements multiplied by its length. For example, if the array is
// [2,1,5], then its score is (2+1+5)×3 = 24.
//
// Given an array of positive integers, `nums`, and a positive integer `k`, count and return the number of non-empty
// subarrays of `nums` whose score is strictly less than `k`.
//
// > Note: A subarray is a contiguous sequence of elements within an array.
//
// Constraints:
//
// - 1 ≤ `nums.length` ≤ 10^3
// - 1 ≤ `nums[i]` ≤ 10^3
// - 1 ≤ `k` ≤ 10^5

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N04_SlidingWindow.P14_CountSubarraysWithScoreLessThanK;

public class Solution
{
    // Time complexity: O(n), Space complexity: O(1).
    public long CountSubarrays(int[] nums, long k)
    {
        int subarrays = 0;
        int sum = 0;

        int start = 0;
        for (int end = 0; end < nums.Length; end++)
        {
            sum += nums[end];

            // Since all numbers are positive, adding a new one will always increase the score, and deleting will
            // decrease the score. 
            while (sum * ((end + 1) - start) >= k)
            {
                sum -= nums[start];
                start++;
            }

            subarrays += (end + 1) - start;
        }

        return subarrays;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run(new int[] { 1, 2, 3, 2, 1 }, 1, 0);
        Run(new int[] { 1, 2, 3, 2, 1 }, 2, 2);
        Run(new int[] { 1, 2, 3, 2, 1 }, 4, 5);
        Run(new int[] { 1, 2, 3, 2, 1 }, 18, 9);
        Run(new int[] { 1, 2, 3, 2, 1 }, 19, 11);
    }

    private static void Run(int[] nums, int k, long expectedResult)
    {
        long result = new Solution().CountSubarrays(nums, k);
        Utilities.PrintSolution((nums, k), result);
        Assert.AreEqual(expectedResult, result);
    }
}
