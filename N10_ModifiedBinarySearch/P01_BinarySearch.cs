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
