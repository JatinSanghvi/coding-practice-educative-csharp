// Minimum One Bit Operations to Make Integers Zero
// ================================================
//
// You are given an integer `n`. Your goal is to reduce it to 0 by repeatedly performing either of the following bit
// operations:
//
// - Flip the rightmost bit (bit at position 0) of `n`.
// - Flip the bit at position i (for i > 0) only if the bit at position i - 1 is 1 and all bits from position i - 2 down
//   to 0 are set to 0.
//
// Determine and return the minimum number of these operations required to reduce `n` to 0.
//
// Constraints:
//
// - 0 ≤ `n` ≤ 10^9

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N28_BitwiseManipulation.P13_MinimumOneBitOperationsToMakeIntegersZero;

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
