// Reverse Integer
// ===============
//
// Given a 32-bit signed integer `num`, reverse its digits and return the result. If the reversed number exceeds the
// 32-bit signed integer range `[-2^31, 2^31 - 1]`, return 0.
//
// Assume the environment *does not* support storing 64-bit integers (signed or unsigned).
//
// Constraints:
//
// - -2^31 ≤ `num` ≤ 2^31 - 1

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N29_MathAndGeometry.P05_ReverseInteger;

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
