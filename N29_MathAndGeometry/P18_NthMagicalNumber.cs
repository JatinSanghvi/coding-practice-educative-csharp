// Nth Magical Number
// ==================
//
// Given three integers `n`, `a`, and `b`, return the n_th magical number.
//
// A magical number is defined as a positive integer that is divisible by either `a` or `b`.
//
// As the result may be very large, return it modulo 10^9 + 7.
//
// Constraints:
//
// - 1 ≤ `n` ≤ 10^9
// - 2 ≤ `a`, `b` ≤ 4 × 10^4

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N29_MathAndGeometry.P18_NthMagicalNumber;

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
