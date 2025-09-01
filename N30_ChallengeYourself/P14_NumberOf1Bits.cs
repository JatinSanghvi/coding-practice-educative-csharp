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
