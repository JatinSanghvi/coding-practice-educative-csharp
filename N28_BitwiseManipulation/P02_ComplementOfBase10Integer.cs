// Complement of Base 10 Integer
// =============================
//
// For any n positive number in base 10, return the complement of its binary representation as an integer in base 10.
//
// Constraints:
//
// - 0 ≤ n ≤ 10^9

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N28_BitwiseManipulation.P02_ComplementOfBase10Integer;

public class Solution
{
    // Time complexity: O(1), Space complexity: O(1).
    public static int FindBitwiseComplement(int num)
    {
        uint result = ~(uint)num; // 1's complement.

        // Flip all 1s to 0s in the most significant bit positions until a 0 is hit.
        for (int i = 31; i != 0 && (result & (1 << i)) != 0; i--)
        {
            result &= (uint)~(1 << i);
        }

        return (int)result;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run(0, 1);
        Run(1, 0);
        Run(42, 21);
    }

    private static void Run(int num, int expectedResult)
    {
        int result = Solution.FindBitwiseComplement(num);
        Utilities.PrintSolution(num, result);
        Assert.AreEqual(expectedResult, result);
    }
}
