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

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N29_MathAndGeometry.P18_NthMagicalNumber;

public class Solution
{
    // Time complexity: O(log(n * min(a, b))), Space complexity: O(1).
    public int NthMagicalNumber(int n, int a, int b)
    {
        int ab = a * b / GreatestCommonDivisor(a, b);

        long low = 0, high = (long)n * Math.Min(a, b);

        while (high - low > 1)
        {
            long mid = (low + high) / 2;
            long rank = mid / a + mid / b - mid / ab;
            if (rank < n) { low = mid; }
            else { high = mid; }
        }

        return (int)(high % 1_000_000_007);
    }

    private static int GreatestCommonDivisor(int a, int b)
    {
        return b == 0 ? a : GreatestCommonDivisor(b, a % b);
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run(700, 600, 1000, 300_000);
    }

    private static void Run(int n, int a, int b, int expectedResult)
    {
        int result = new Solution().NthMagicalNumber(n, a, b);
        Utilities.PrintSolution((n, a, b), result);
        Assert.AreEqual(expectedResult, result);
    }
}
