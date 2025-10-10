// Missing Number
// ==============
//
// Given an array, `nums`, containing n distinct numbers in the range [0, n], return the only number in the range that
// is missing from the array.
//
// Constraints:
//
// - n = `nums.length`
// - 1 ≤ n ≤ 10^3
// - 0 ≤ `nums[i]` ≤ n
// - There are no duplicates in the array.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N15_CyclicSort.P02_MissingNumber;

public class Solution
{
    // Time complexity: O(n), Space complexity: O(1).
    public static int FindMissingNumber(int[] nums)
    {
        int len = nums.Length;
        int result = len;
        for (int i = 0; i != len; i++)
        {
            while (nums[i] != i && nums[i] != len)
            {
                (nums[i], nums[nums[i]]) = (nums[nums[i]], nums[i]);
            }

            if (nums[i] == len) { result = i; }
        }

        return result;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([3, 2, 1], 0);
        Run([2, 1, 0], 3);
    }

    private static void Run(int[] nums, int expectedResult)
    {
        int result = Solution.FindMissingNumber(nums);
        Utilities.PrintSolution(nums, result);
        Assert.AreEqual(expectedResult, result);
    }
}
