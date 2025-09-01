// Valid Parentheses
// =================
//
// Given a string that may consist of opening and closing parentheses, your task is to check whether or not the string
// contains valid parenthesization.
//
// The conditions to validate are as follows:
//
// 1. Every opening parenthesis should be closed by the same kind of parenthesis. Therefore, `{)`and `[(])` strings are
//    invalid.
// 2. Every opening parenthesis must be closed in the correct order. Therefore, `)(` and `()(()` are invalid.
//
// Constraints:
//
// - 1 ≤ `string.length` ≤ 10^3
// - The string will only contain the following characters: `(`, `)`, `[`, `]`, `{` and `}`.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N19_Stacks.P13_ValidParentheses;

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
