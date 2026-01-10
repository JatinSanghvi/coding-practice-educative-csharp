// Single Number
// =============
//
// Given an array of integers, where every element appears twice except for one, find the element that occurs only once.
//
// > Note: The solution must have linear runtime and constant space complexity.
//
// Constraints:
//
// - 1 ≤ `nums.length` ≤ 10^3
// - -3 × 10^3 ≤ `nums[i]` ≤ 3 × 10^3

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N28_BitwiseManipulation.P04_SingleNumber;

public class Solution
{
    // Time complexity: O(n), Space complexity: O(1).
    public static int SingleNumber(int[] nums)
    {
        int result = 0;

        foreach (int num in nums)
        {
            result ^= num;
        }

        return result;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([1], 1);
        Run([1, 2, 1], 2);
    }

    private static void Run(int[] nums, int expectedResult)
    {
        int result = Solution.SingleNumber(nums);
        Utilities.PrintSolution(nums, result);
        Assert.AreEqual(expectedResult, result);
    }
}
