// Maximum Average Subarray I
// ==========================
//
// Given an array of integers `nums`, and an integer `k`, return the maximum average of a contiguous subarray of
// length `k`.
//
// Constraints:
//
// - 1 ≤ `k` ≤ `nums.length` ≤ 10^5
// - -10^4 ≤ `nums[i]` ≤ 10^4

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N04_SlidingWindow.P08_MaximumAverageSubarrayI;

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
