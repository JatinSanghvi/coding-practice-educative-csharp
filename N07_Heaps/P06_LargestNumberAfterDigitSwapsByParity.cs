// Largest Number After Digit Swaps by Parity
// ==========================================
//
// You are given a positive integer `num`. You can swap any two digits of `num` as long as they share the same parity
// (both are odd or both are even).
//
// Your task is to return the largest possible value of `num` after performing any number of such swaps.
//
// Constraints:
//
// - 1 ≤ `num` ≤ 10^9

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N07_Heaps.P06_LargestNumberAfterDigitSwapsByParity;

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
