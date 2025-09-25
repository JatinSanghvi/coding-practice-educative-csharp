// Search in Rotated Sorted Array
// ==============================
//
// You are given a sorted integer array, `nums`, and an integer, `target`. The array may have been rotated by an
// arbitrary number. Your task is to find and return the index of `target` in this array. If `target` does not exist,
// return -1.
//
// Constraints:
//
// - All values in `nums` are unique.
// - The values in `nums` are sorted in ascending order.
// - The array may have been rotated by some arbitrary number.
// - 1 ≤ `nums.length` ≤ 1000
// - -10^4 ≤ `nums[i]` ≤ 10^4
// - -10^4 ≤ `target` ≤ 10^4

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N10_ModifiedBinarySearch.P02_SearchInRotatedSortedArray;

public class Solution
{
    // Time complexity: O(logn), Space complexity: O(1).
    public static int BinarySearchRotated(int[] nums, int target)
    {
        int low = 0, high = nums.Length;
        while (high - low != 1)
        {
            int mid = (low + high) / 2;

            // At least one of the two halves is unrotated. Check for the presence of target in the unrotated half to
            // choose between the two halves.
            if (nums[low] <= nums[mid - 1])
            {
                if (nums[low] <= target && target <= nums[mid - 1]) { high = mid; }
                else { low = mid; }
            }
            else
            {
                if (nums[mid] <= target && target <= nums[high - 1]) { low = mid; }
                else { high = mid; }
            }
        }

        return nums[low] == target ? low : -1;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([1, 3, 5], 1, 0);
        Run([5, 1, 3], 3, 2);
        Run([3, 5, 1], 5, 1);
        Run([1, 3, 5], 0, -1);
        Run([5, 1, 3], 2, -1);
        Run([3, 5, 1], 4, -1);
    }

    private static void Run(int[] nums, int target, int expectedResult)
    {
        int result = Solution.BinarySearchRotated(nums, target);
        Utilities.PrintSolution((nums, target), result);
        Assert.AreEqual(expectedResult, result);
    }
}
