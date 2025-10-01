// Minimum Replacements to Sort the Array
// ======================================
//
// You are given a 0-indexed integer array `nums`. You are allowed to perform the following operation any number of
// times:
//
// - Select any element in the array and replace it with two positive integers whose sum is equal to the selected
//   element.
//
// For example, if the array is `nums = [5, 6, 7]`, you can choose the element `6` and replace it with `2` and `4`,
// resulting in a new array `[5, 2, 4, 7]`.
//
// Your goal is to make the array sorted in non-decreasing order using the minimum number of operations.
//
// Return the minimum number of operations required to achieve this.
//
// Constraints:
//
// - 1 ≤ `nums.length` ≤ 10^3
// - 1 ≤ `nums[i]` ≤ 10^5

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N12_GreedyTechniques.P14_MinimumReplacementsToSortTheArray;

public class Solution
{
    // Time complexity: O(n), Space complexity: O(1).
    public static long MinimumReplacement(int[] nums)
    {
        int maxAllowed = nums[^1];
        int operations = 0;
        for (int i = nums.Length - 2; i != -1; i--)
        {
            int splits = (nums[i] - 1) / maxAllowed;
            maxAllowed = nums[i] / (splits + 1);
            operations += splits;
        }

        return operations;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([10, 20, 30], 0);
        Run([30, 20, 10], 3);
        Run([30, 21, 10], 6);
    }

    private static void Run(int[] nums, long expectedResult)
    {
        long result = Solution.MinimumReplacement(nums);
        Utilities.PrintSolution(nums, result);
        Assert.AreEqual(expectedResult, result);
    }
}
