// Construct Target Array With Multiple Sums
// ========================================
//
// You are given an array `target` of `n` integers.
//
// Starting from an array `arr` of size `n` where every element is `1`, you may perform the following operation any number
// of times:
//
// - Let `x` be the sum of all current elements in `arr`.
// - Pick an index `i` and set `arr[i] = x`.
//
// Your task is to return True if it's possible to construct `target` from `arr`, otherwise return False.
//
// Constraints:
//
// - n == `target.length`
// - 1 ≤ `n` ≤ 1000
// - 1 ≤ `target[i]` ≤ 10^5

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N07_Heaps.P12_ConstructTargetArrayWithMultipleSums;

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
