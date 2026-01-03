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
    // Time complexity: O(digits), Space complexity: O(1).
    public static int Reverse(int num)
    {
        int reversed = 0;

        int msd = 0;
        while (num != 0)
        {
            reversed = reversed * 10 + (num % 10);
            msd = num;
            num /= 10;
        }

        int lsd = reversed % 10;
        if (msd != lsd) { return 0; }

        return reversed;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run(1, 1);
        Run(-1, -1);
        Run(1_000_000_000, 1);
        Run(1_463_847_412, 2_147_483_641);
        Run(-2_147_483_641, -1_463_847_412);
        Run(1_000_000_003, 0);
    }

    private static void Run(int num, int expectedResult)
    {
        int result = Solution.Reverse(num);
        Utilities.PrintSolution(num, result);
        Assert.AreEqual(expectedResult, result);
    }
}
