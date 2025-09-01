// Split Array Largest Sum
// =======================
//
// Given an integer list `nums` and an integer `k`, split `nums` into `k` non-empty subarrays such that the largest sum
// among these subarrays is minimized. The task is to find the minimized largest sum by choosing the split such that the
// largest sum of every split of subarrays is the minimum among the sum of other splits.
//
// Constraints:
//
// - 1 ≤ `nums.length` ≤ 10^3
// - 0 ≤ `nums[i]` ≤ 10^4
// - 1 ≤ `k` ≤ `nums.length`

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N10_ModifiedBinarySearch.P09_SplitArrayLargestSum;

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
