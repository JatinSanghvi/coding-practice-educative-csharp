// Evaluate Reverse Polish Notation
// ================================
//
// Given an arithmetic expression in a Reverse Polish Notation (RPN) as an array of strings, `tokens`, your task is to
// evaluate and return the value of the given expression.
//
// Points to consider:
//
// - Valid operators are `+`, `-`, `*`, and `/`.
// - Each operand can be an integer or another expression.
// - The division between two integers should truncate toward zero.
//
// The given Reverse Polish Notation expression is guaranteed to be valid. This ensures that the expression always
// evaluates to a result and that there are no division-by-zero operations.
//
// Constraints:
//
// - 1 ≤ `tokens.length` ≤ 10^3
// - `tokens[i]` is either an operator (`+`, `-`, `*`, or `/`) or an integer in the range [-200,200].

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N30_ChallengeYourself.P16_EvaluateReversePolishNotation;

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
