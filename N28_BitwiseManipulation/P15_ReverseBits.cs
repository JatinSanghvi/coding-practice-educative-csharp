// Reverse Bits
// ============
//
// Given an unsigned 32-bit integer `n`, we need to calculate a 32-bit unsigned integer with reversed bits. When we say
// "reverse" we don't mean flipping the 0s to 1s and vice versa, but simply reversing the order in which they appear,
// i.e., from left-to-right to right-to-left.
//
// Constraints:
//
// - The input must be a binary string of length 32

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N28_BitwiseManipulation.P15_ReverseBits;

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
