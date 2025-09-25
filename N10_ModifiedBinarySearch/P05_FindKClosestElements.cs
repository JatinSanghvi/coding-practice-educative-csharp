// Find K Closest Elements
// =======================
//
// You are given a sorted array of integers, `nums`, and two integers, `target` and `k`. Your task is to return `k`
// number of integers that are close to the target value, `target`. The integers in the output array should be in a
// sorted order.
//
// An integer, `nums[i]`, is considered to be closer to `target`, as compared to `nums[j]` when |`nums[i]` - `target`| <
// |`nums[j]` - `target`|. However, when |`nums[i]` - `target`| == |`nums[j]` - `target`|, the smaller of the two values
// is selected.
//
// Constraints:
//
// - 1 ≤ `k` ≤ `nums.length`
// - 1 ≤ `nums.length` ≤ 10^3
// - `nums` is sorted in ascending order.
// - -10^4 ≤ `nums[i]`, `target` ≤ 10^4

using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N10_ModifiedBinarySearch.P05_FindKClosestElements;

public class Solution
{
    // Time complexity: O(logn+k), Space complexity: O(1).
    public static IList<int> FindClosestElements(int[] nums, int k, int target)
    {
        int low = 0, high = nums.Length;
        while (high - low != 1)
        {
            int mid = (low + high) / 2;

            if (target < nums[mid]) { high = mid; }
            else { low = mid; }
        }

        while (high - (low + 1) != k)
        {
            if (high == nums.Length || (low != -1 && target - nums[low] <= nums[high] - target)) { low--; }
            else { high++; }
        }

        return new List<int>(nums[(low + 1)..high]);
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([1, 2, 3, 4, 5], 3, 0, [1, 2, 3]);
        Run([1, 2, 3, 4, 5], 3, 3, [2, 3, 4]);
        Run([1, 2, 3, 4, 5], 3, 6, [3, 4, 5]);
    }

    private static void Run(int[] nums, int k, int target, int[] expectedResult)
    {
        IList<int> result = Solution.FindClosestElements(nums, k, target);
        Utilities.PrintSolution((nums, k, target), result);
        CollectionAssert.AreEqual(expectedResult, result.ToArray());
    }
}
