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
    public static int IntegerAddition(int a, int b)
    {
        int result = 0;
        int cBit = 0;

        for (int pos = 0; pos != 32; pos++)
        {
            int aBit = (a & (1 << pos)) >>> pos;
            int bBit = (b & (1 << pos)) >>> pos;
            result |= (aBit ^ bBit ^ cBit) << pos;
            cBit = (aBit + bBit + cBit) >= 2 ? 1 : 0;
        }

        return result;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run(1, 1, 2);
        Run(-1, 1, 0);
        Run(-1, -1, -2);
    }

    private static void Run(int a, int b, int expectedResult)
    {
        int result = Solution.IntegerAddition(a, b);
        Utilities.PrintSolution((a, b), result);
        Assert.AreEqual(expectedResult, result);
    }
}
