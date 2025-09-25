// Split Array Into Two Arrays to Minimize Sum Difference
// ======================================================
//
// You are given an integer array, `nums`, consisting of 2 ∗ n elements.
//
// Your task is to divide the array into two subarrays of length n, such that each element in `nums` belongs to exactly
// one of the two subarrays, and the absolute difference between their sum is minimized.
//
// Return the minimum possible absolute difference between the sum of the two subarrays.
//
// Constraints:
//
// - 1 ≤ n ≤ 15
// - `nums.length` == 2 ∗ n
// - -10^7 ≤ `nums[i]` ≤ 10^7

using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N10_ModifiedBinarySearch.P14_SplitArrayIntoTwoArraysToMinimizeSumDifference;

public class Solution
{
    // Time complexity: O(2^2n), Space complexity: O(2n).
    public int MinimumDifference(int[] nums)
    {
        // The most optimal solution is too convoluted, hence taking a simpler approach.
        int halfLength = nums.Length / 2;
        int allSum = nums.Sum();
        int targetSum = allSum / 2;
        int minDifference = int.MaxValue;

        Check(-1, 0, 0);

        return Math.Abs(allSum - 2 * targetSum + 2 * minDifference);

        void Check(int lastIndex, int lastCount, int lastSum)
        {
            if (minDifference == 0) { return; }

            if (lastCount == halfLength)
            {
                if (lastSum <= targetSum)
                {
                    minDifference = Math.Min(minDifference, targetSum - lastSum);
                }
            }

            if (lastIndex != nums.Length - 1)
            {
                if (lastCount != halfLength)
                {
                    Check(lastIndex + 1, lastCount + 1, lastSum + nums[lastIndex + 1]);
                }

                if (lastIndex != -1 && lastCount != halfLength + 1)
                {
                    Check(lastIndex + 1, lastCount, lastSum - nums[lastIndex] + nums[lastIndex + 1]);
                }
            }
        }
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([1, 2, 3, 4], 0);
        Run([1, 2, 3, 6], 2);
        Run([-1, -2, -4, -8], 3);
    }

    private static void Run(int[] nums, int expectedResult)
    {
        int result = new Solution().MinimumDifference(nums);
        Utilities.PrintSolution(nums, result);
        Assert.AreEqual(expectedResult, result);
    }
}
