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
    // Time complexity: O(1), Space complexity: O(1).
    public static uint ReverseBits(uint n)
    {
        uint result = 0;
        for (int pos = 0; pos != 32; pos++)
        {
            if ((n & (1 << pos)) != 0)
            {
                result |= 1U << (31 - pos);
            }
        }

        return result;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run(0, 0);
        Run(0x55555555, 0xAAAAAAAA);
        Run(0xFFFF0000, 0x0000FFFF);
    }

    private static void Run(uint n, uint expectedResult)
    {
        uint result = Solution.ReverseBits(n);
        Utilities.PrintSolution(n, result);
        Assert.AreEqual(expectedResult, result);
    }
}
