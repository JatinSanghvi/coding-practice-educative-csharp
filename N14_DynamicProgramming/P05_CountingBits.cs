// Counting Bits
// =============
//
// For a given positive integer, `n`, your task is to return an array of length n+1 such that for each x where 0 ≤ x ≤
// n, `result[x]` is the count of 1s in the binary representation of x.
//
// Constraints:
//
// - 0 ≤ n ≤ 10^4

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N14_DynamicProgramming.P05_CountingBits;

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
