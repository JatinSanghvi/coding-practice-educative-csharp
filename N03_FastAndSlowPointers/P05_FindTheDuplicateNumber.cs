// Find the Duplicate Number
// =========================
//
// Given an array of positive numbers, `nums`, such that the values lie in the range [1,n], inclusive, and that there
// are n+1 numbers in the array, find and return the duplicate number present in `nums`. There is only one repeated
// number in `nums`, but it may appear more than once in the array.
//
// > Note: You cannot modify the given array `nums`. You have to solve the problem using only constant extra space.
//
// Constraints:
//
// - 1 ≤ n ≤ 10^3
// - `nums.length` = n+1
// - 1 ≤ `nums[i]` ≤ n
// - All the integers in `nums` are unique, except for one integer that will appear more than once.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N03_FastAndSlowPointers.P05_FindTheDuplicateNumber;

public class Solution
{
    // Time complexity: O(n), Space complexity: O(1).
    public static int FindDuplicate(int[] nums)
    {
        // Traversing the array based on element values will:
        // - Never end, as all values are valid indexes.
        // - Never circles back to the start point, as none of the values are zero.
        // Hence, this approach is guaranteed to loop and reach the duplicate number.

        int slow = 0, fast = 0;

        do
        {
            slow = nums[slow];
            fast = nums[nums[fast]];
        }
        while (slow != fast);

        slow = 0;
        while (slow != fast)
        {
            slow = nums[slow];
            fast = nums[fast];
        }

        return slow;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run(new[] { 1, 2, 3, 1 }, 1);
        Run(new[] { 1, 2, 3, 3 }, 3);
        Run(new[] { 1, 2, 1, 3 }, 1);
        Run(new[] { 3, 2, 3, 1 }, 3);
    }

    private static void Run(int[] nums, int expectedResult)
    {
        int result = Solution.FindDuplicate(nums);
        Utilities.PrintSolution(nums, result);
        Assert.AreEqual(expectedResult, result);
    }
}