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

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N10_ModifiedBinarySearch.P05_FindKClosestElements;

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
