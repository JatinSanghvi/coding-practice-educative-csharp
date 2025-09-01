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
