// Find The K-th Lucky Number
// ==========================
//
// A number is called lucky if it comprises only the digits 4 and 7. Your task is to return the k-th lucky number as a
// string for a given integer `k`.
//
// Constraints:
//
// - 1 <= `k` <= 10^9

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N28_BitwiseManipulation.P08_FindTheKthLuckyNumber;

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
