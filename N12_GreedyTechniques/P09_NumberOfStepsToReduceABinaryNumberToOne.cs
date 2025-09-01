// Number of Steps to Reduce a Binary Number to One
// ================================================
//
// You are given a string, `str`, as a binary representation of an integer. Your task is to return the number of steps
// needed to reduce it to 1 by following these rules:
//
// - If the number is even, divide it by 2.
// - If the number is odd, add 1 to it.
//
// You can always reach 1 for all provided test cases.
//
// Constraints:
//
// - 1 <= `str.length` <= 500
// - `str` consists of characters '0' or '1'.
// - `str[0]` == '1'

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N12_GreedyTechniques.P09_NumberOfStepsToReduceABinaryNumberToOne;

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
