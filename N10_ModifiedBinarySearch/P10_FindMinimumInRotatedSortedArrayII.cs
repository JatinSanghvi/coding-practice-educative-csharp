// Find Minimum in Rotated Sorted Array II
// =======================================
//
// Imagine you have an array, `nums`, of length n that was originally sorted in non-decreasing (ascending) order. This
// array has been rotated between 1 and n times. For example, the sorted array [0, 2, 3, 3, 5, 7, 11] can become:
//
// - [5, 7, 11, 0, 2, 3, 3], if rotated 3 times
// - [0, 2, 3, 3, 5, 7, 11], if rotated 7 times
//
// A single rotation moves the last element to the front. So, if the original array is [a[0], a[1], ..., a[n-1]],
// rotating it once produces [a[n-1], a[0], a[1], ..., a[n-2]].
//
// You are given a sorted, rotated array, `nums`, that may include duplicate elements. Your job is to return the minimum
// element in the array.
//
// Try to solve this problem with the fewest possible operations.
//
// Constraints:
//
// - n == `nums.length`
// - 1 ≤ n ≤ 1000
// - -1000 ≤ `nums[i]` ≤ 1000
// - `nums` is sorted and rotated between 1 and n times.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N10_ModifiedBinarySearch.P10_FindMinimumInRotatedSortedArrayII;

public class Solution
{
    public static bool Function()
    {
        return true;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run(true);
    }

    private static void Run(bool expectedResult)
    {
        bool result = Solution.Function();
        Utilities.PrintSolution(true, result);
        Assert.AreEqual(expectedResult, result);
    }
}
