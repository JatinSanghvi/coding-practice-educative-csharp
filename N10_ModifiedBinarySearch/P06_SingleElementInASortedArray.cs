// Single Element in a Sorted Array
// ================================
//
// You are given a sorted array of integers, `nums`, where all integers appear twice except for one. Your task is to
// find and return the single integer that appears only once.
//
// The solution should have a time complexity of O(log n) or better and a space complexity of O(1).
//
// Constraints:
//
// - 1 ≤ `nums.length` ≤ 10^3
// - 0 ≤ `nums[i]` ≤ 10^3

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N10_ModifiedBinarySearch.P06_SingleElementInASortedArray;

public class Solution
{
    public static int SingleNonDuplicate(int[] nums)
    {
        int low = 0, high = nums.Length;

        while (high - low != 1)
        {
            // low should always be even, high should always be odd. Make mid even to simplify the logic.
            int mid = (low + high) / 4 * 2;

            if (nums[mid] == nums[mid + 1]) { low = mid + 2; }
            else { high = mid + 1; }
        }

        return nums[low];
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([1, 2, 2, 3, 3, 4, 4], 1);
        Run([1, 1, 2, 3, 3, 4, 4], 2);
        Run([1, 1, 2, 2, 3, 4, 4], 3);
        Run([1, 1, 2, 2, 3, 3, 4], 4);
    }

    private static void Run(int[] nums, int expectedResult)
    {
        int result = Solution.SingleNonDuplicate(nums);
        Utilities.PrintSolution(nums, result);
        Assert.AreEqual(expectedResult, result);
    }
}
