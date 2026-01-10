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
    // Time complexity: O(1), Space complexity: O(1).
    public int MinimumOneBitOperations(int n)
    {
        // The sequence of operations for number 8 will look like:
        // 1000 -> 1001 -> 1011 -> 1010 -> 1110 -> 1111 -> 1101 -> 1100 ->
        // 0100 -> 0101 -> 0111 -> 0110 -> 0010 -> 0011 -> 0001 -> 0000 (total 15 operations).
        // In general, any number like abc10000 needs to be converted to abc11000 in x operations, then to abc01000, and
        // finally to abc00000 in x more operations. Since the operation is recursive, coversion always takes operation
        // equal to 2^(bit position that need to be changed).
        // The number sequence is same as Gray code, when successive numbers only differ by a single bit. We can easily
        // find the rank of a number in Gray code using the following logic.

        int operations = 0;
        int toggle = 0;

        for (int pos = 30; pos != -1; pos--)
        {
            if ((n & (1 << pos)) != 0)
            {
                toggle ^= 1;
            }

            operations += toggle << pos;
        }

        return operations;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run(8, 15);
        Run(12, 8);
    }

    private static void Run(int n, int expectedResult)
    {
        int result = new Solution().MinimumOneBitOperations(n);
        Utilities.PrintSolution(n, result);
        Assert.AreEqual(expectedResult, result);
    }
}
