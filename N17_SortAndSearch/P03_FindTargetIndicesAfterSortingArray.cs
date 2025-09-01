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

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N17_SortAndSearch.P03_FindTargetIndicesAfterSortingArray;

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
