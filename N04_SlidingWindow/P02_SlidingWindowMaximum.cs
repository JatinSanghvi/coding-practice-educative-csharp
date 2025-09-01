// Sliding Window Maximum
// ======================
//
// You are given an array of integers `nums` and a sliding window of size `w` that moves from left to right
// across the array, shifting one position at a time.
//
// Your task is to find the maximum value within the current window at each step and return it.
//
// Constraints:
//
// - 1 ≤ `nums.length` ≤ 10^3
// - -10^4 ≤ `nums[i]` ≤ 10^4
// - 1 ≤ `w` ≤ `nums.length`

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N04_SlidingWindow.P02_SlidingWindowMaximum;

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
