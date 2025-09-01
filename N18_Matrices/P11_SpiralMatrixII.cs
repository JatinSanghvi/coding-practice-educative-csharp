// Spiral Matrix II
// ================
//
// Given a positive integer `n`, create an n × n matrix where the elements are sequential integers from 1 to n^2,
// arranged in a spiral pattern.
//
// Constraints:
//
// - 1 ≤ `n` ≤ 20

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N18_Matrices.P11_SpiralMatrixII;

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
