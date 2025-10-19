// Find Target Indices After Sorting Array
// =======================================
//
// You are given a 0-indexed array of positive integers, `nums`, and a value, `target`. The `target` represents an index
// i in the array such that `nums[i] == target`.
//
// Your task is to return a list of indexes of `nums` where the value equals `target` after sorting the array in
// nondecreasing order. If no such indexes exist, return an empty list. Ensure the returned list is sorted in increasing
// order.
//
// Constraints:
//
// - 1 ≤ `nums.length` ≤ 100
// - 1 ≤ `nums[i]`, `target` ≤ 100

using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N17_SortAndSearch.P03_FindTargetIndicesAfterSortingArray;

public class Solution
{
    // Time complexity: O(n), Space complexity: O(1).
    public static List<int> TargetIndices(int[] nums, int target)
    {
        int lessers = 0;
        int equals = 0;
        foreach (int num in nums)
        {
            if (num < target) { lessers++; }
            else if (num == target) { equals++; }
        }

        return Enumerable.Range(lessers, equals).ToList();
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([3, 3, 2, 2, 1, 1], 0, []);
        Run([3, 3, 2, 2, 1, 1], 1, [0, 1]);
    }

    private static void Run(int[] nums, int target, int[] expectedResult)
    {
        int[] result = Solution.TargetIndices(nums, target).ToArray();
        Utilities.PrintSolution((nums, target), result);
        CollectionAssert.AreEqual(expectedResult, result);
    }
}
