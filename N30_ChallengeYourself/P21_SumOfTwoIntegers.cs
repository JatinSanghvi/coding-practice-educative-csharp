// Sum of Two Integers
// ===================
//
// Given two integers, `a` and `b`, return their sum without using the addition or subtraction operators.
//
// Constraints
//
// - -1000 ≤ `a`, `b` ≤ 1000

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N30_ChallengeYourself.P21_SumOfTwoIntegers;

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
