// Number of 1 Bits
// ================
//
// Write a function that takes a 32-bit binary representation of an unsigned integer n and returns the count of its 1
// bits.
//
// The binary representation of an unsigned integer is a sequence of 0s and 1s that represents the integer's value using
// base-2 notation. An example of the 32-bit binary representation of an unsigned integer 13 is
// 00000000000000000000000000001101.
//
// Constraint:
//
// - The input must be a 32-bit binary representation of an unsigned integer.
//
// > Note: The input is passed to the function as an unsigned integer variable. In this lesson, we have displayed it as
// > a string of binary numbers solely for visualization purposes.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N30_ChallengeYourself.P14_NumberOf1Bits;

public class Solution
{
    // Time complexity: O(1), Space complexity: O(1).
    public static int NumberOf1Bits(int n)
    {
        n = (n & 0x55555555) + ((n >>> 1) & 0x55555555);
        n = (n & 0x33333333) + ((n >>> 2) & 0x33333333);
        n = (n & 0x0F0F0F0F) + ((n >>> 4) & 0x0F0F0F0F);
        n = (n & 0x00FF00FF) + ((n >>> 8) & 0x00FF00FF);
        n = (n & 0x0000FFFF) + ((n >>> 16) & 0x0000FFFF);
        return n;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run(0, 0);
        Run(int.MaxValue, 31);
        Run(int.MinValue, 1);
    }

    private static void Run(int n, int expectedResult)
    {
        int result = Solution.NumberOf1Bits(n);
        Utilities.PrintSolution(n, result);
        Assert.AreEqual(expectedResult, result);
    }
}
