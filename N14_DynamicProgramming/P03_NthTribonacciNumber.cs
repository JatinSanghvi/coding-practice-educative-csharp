// N-th Tribonacci Number
// ======================
//
// Given a number `n`, calculate the corresponding Tribonacci number. The Tribonacci sequence Tn is defined as:
//
// | T0 = 0, T1 = 1, T2 = 1, and Tn+3 = Tn + Tn+1 + Tn+2, for n >= 0 |
// | --- |
//
// The input number, `n`, is a non-negative integer.
//
// Constraints:
//
// - 0 ≤ `n` ≤ 37
// - The answer is guaranteed to fit within a 32-bit integer, i.e., answer ≤ 2^31 - 1

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N14_DynamicProgramming.P03_NthTribonacciNumber;

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
