// Binary Search
// =============
//
// We are given an array of integers, `nums`, sorted in ascending order, and an integer value, `target`. If the `target`
// exists in the array, return its index. If the `target` does not exist, return `-1`.
//
// Constraints:
//
// - 1 ≤ `nums.length` ≤ 10^3
// - -10^4 ≤ `nums[i]`, `target` ≤ 10^4
// - All integers in `nums` are unique.
// - `nums` is sorted in ascending order.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N10_ModifiedBinarySearch.P01_BinarySearch;

public class Solution
{
    // Time complexity: O(logn), Space complexity: O(1).
    public static int BinarySearch(int[] nums, int target)
    {
        int low = 0, high = nums.Length;
        while (high - low != 1)
        {
            int mid = (low + high) / 2;

            if (target < nums[mid]) { high = mid; }
            else { low = mid; }
        }

        return target == nums[low] ? low : -1;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([1, 3], 0, -1);
        Run([1, 3], 1, 0);
        Run([1, 3], 2, -1);
    }

    private static void Run(int[] nums, int target, int expectedResult)
    {
        int result = Solution.BinarySearch(nums, target);
        Utilities.PrintSolution((nums, target), result);
        Assert.AreEqual(expectedResult, result);
    }
}
