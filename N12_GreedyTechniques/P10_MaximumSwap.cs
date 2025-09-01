// Maximum Swap
// ============
//
// Given an integer `num`, return the maximum number that can be formed by swapping at least two digits once.
//
// Constraints:
//
// - 0 ≤ `num` ≤ 10^5

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N12_GreedyTechniques.P10_MaximumSwap;

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
