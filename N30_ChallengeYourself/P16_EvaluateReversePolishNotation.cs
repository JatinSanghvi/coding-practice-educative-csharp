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

using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N30_ChallengeYourself.P16_EvaluateReversePolishNotation;

public class Solution
{
    // Time complexity: O(n), Space complexity: O(n).
    public static int EvaluateReversePolishNotation(string[] tokens)
    {
        var stack = new Stack<int>();

        foreach (string token in tokens)
        {
            if (!int.TryParse(token, out int result))
            {
                int operand2 = stack.Pop();
                int operand1 = stack.Pop();

                result = token switch
                {
                    "+" => operand1 + operand2,
                    "-" => operand1 - operand2,
                    "*" => operand1 * operand2,
                    "/" => operand1 / operand2,
                    _ => throw new InvalidOperationException(),
                };
            }

            stack.Push(result);
        }

        return stack.Peek();
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run(["1", "2", "-", "1", "2", "+", "*", "2", "/"], -1); // (1 - 2) * (1 + 2) / 2
    }

    private static void Run(string[] tokens, int expectedResult)
    {
        int result = Solution.EvaluateReversePolishNotation(tokens);
        Utilities.PrintSolution(tokens, result);
        Assert.AreEqual(expectedResult, result);
    }
}
