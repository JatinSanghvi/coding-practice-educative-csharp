// Sliding Window Median
// =====================
//
// Given an integer array, `nums`, and an integer, `k`, there is a sliding window of size `k`, which is moving from the
// very left to the very right of the array. We can only see the `k` numbers in the window. Each time the sliding window
// moves right by one position.
//
// Given this scenario, return the median of each window. Answers within 10^-5 of the actual value will be accepted.
//
// Constraints:
//
// - 1 ≤ `k` ≤ `nums.length` ≤ 10^3
// - -2^31 ≤ `nums[i]` ≤ 2^31 - 1

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N07_Heaps.P03_SlidingWindowMedian;

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
