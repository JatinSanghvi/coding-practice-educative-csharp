// Minimum Number of K Consecutive Bit Flips
// =========================================
//
// We are given a binary array `nums` and an integer `k`. Our task is to find the minimum number of flips needed to make
// all the bits in the array equal to 1. However, we can only flip `k` consecutive bits at a time. So, for a binary
// array [1,1,0,0] and `k` = 2, we can flip the last two bits to get [1,1,1,1]. This means we only need *a single
// **`k`** flip* to turn the entire array into all 1s.
//
// If `nums` cannot be converted to an array with all 1s with the given `k`, return -1.
//
// Constraints:
//
// - 1 ≤ `nums.length` ≤ 10^3
// - 1 ≤ `k` ≤ `nums.length`

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N28_BitwiseManipulation.P09_MinimumNumberOfKConsecutiveBitFlips;

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
