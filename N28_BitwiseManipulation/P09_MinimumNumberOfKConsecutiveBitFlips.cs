// Minimum Number of K Consecutive Bit Flips
// =========================================
//
// We are given a binary array `nums` and an integer `k`. Our task is to find the minimum number of flips needed to make
// all the bits in the array equal to 1. However, we can only flip `k` consecutive bits at a time. So, for a binary
// array [1,1,0,0] and `k` = 2, we can flip the last two bits to get [1,1,1,1]. This means we only need *a single
// `k` flip* to turn the entire array into all 1s.
//
// If `nums` cannot be converted to an array with all 1s with the given `k`, return -1.
//
// Constraints:
//
// - 1 ≤ `nums.length` ≤ 10^3
// - 1 ≤ `k` ≤ `nums.length`

using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N28_BitwiseManipulation.P09_MinimumNumberOfKConsecutiveBitFlips;

public class Solution
{
    // Time complexity: O(n), Space complexity: O(k).
    public static int MinKBitFlips(int[] nums, int k)
    {
        int allFlips = 0;
        int rangeFlips = 0;
        var flipHistory = new Queue<bool>();

        // Flip the next k bits if current position has a 0. Remember if flip was made at every index.
        for (int i = 0; i != nums.Length; i++)
        {
            if (i >= k && flipHistory.Dequeue())
            {
                rangeFlips--;
            }

            bool shouldFlip = (nums[i] ^ (rangeFlips % 2)) == 0;
            if (shouldFlip)
            {
                if (i + k > nums.Length) { return -1; }
                allFlips += 1;
                rangeFlips += 1;
            }

            flipHistory.Enqueue(shouldFlip);
        }

        return allFlips;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([1, 0, 1, 0], 1, 2);
        Run([1, 0, 1, 0], 2, 2);
        Run([1, 0, 1, 0], 3, -1);
    }

    private static void Run(int[] nums, int k, int expectedResult)
    {
        int result = Solution.MinKBitFlips(nums, k);
        Utilities.PrintSolution((nums, k), result);
        Assert.AreEqual(expectedResult, result);
    }
}
