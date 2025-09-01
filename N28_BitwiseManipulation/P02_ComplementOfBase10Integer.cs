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
