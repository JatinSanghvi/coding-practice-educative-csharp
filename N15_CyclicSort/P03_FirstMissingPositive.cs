// First Missing Positive
// ======================
//
// Given an unsorted integer array, `nums`, return the smallest missing positive integer. Create an algorithm that runs
// with an O(n) time complexity and utilizes a constant amount of space.
//
// > Note: The smallest missing positive isn't the first positive number that's missing in the range of elements in the
// > input, but the first positive number that's missing if we start from 1.
//
// Constraints:
//
// - 1 ≤ `nums.length` ≤ 10^5
// - -2^31 ≤ `nums[i]` ≤ 2^31 - 1

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N15_CyclicSort.P03_FirstMissingPositive;

public class Solution
{
    // Time complexity: O(n), Space complexity: O(1).
    public static int FirstMissingPositiveInteger(int[] nums)
    {
        int i = 0;
        while (i != nums.Length)
        {
            int j = nums[i] - 1; // Target index.
            if (j >= 0 && j < nums.Length && nums[i] != nums[j])
            {
                (nums[i], nums[j]) = (nums[j], nums[i]);
            }
            else
            {
                i++;
            }
        }

        for (i = 0; i != nums.Length; i++)
        {
            if (nums[i] != i + 1)
            {
                return i + 1;
            }
        }

        return nums.Length + 1;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([4, 3, 2, 1], 5);
        Run([-4, -3, -2, -1], 1);
        Run([-4, -3, 2, 1, 0], 3);
    }

    private static void Run(int[] nums, int expectedResult)
    {
        int result = Solution.FirstMissingPositiveInteger(nums);
        Utilities.PrintSolution(nums, result);
        Assert.AreEqual(expectedResult, result);
    }
}
