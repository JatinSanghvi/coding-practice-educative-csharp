// Basic Calculator
// ================
//
// Given a string containing an arithmetic expression, implement a basic calculator that evaluates the expression
// string. The expression string can contain integer numeric values and should be able to handle the "+" and "-"
// operators, as well as "()" parentheses.
//
// Constraints:
//
// - 1 ≤ `s.length` ≤ 3×10^4
// - `s` consists of digits, "+", "-", "(", and ")".
// - `s` represents a valid expression.
// - "+" is not used as a unary operation (+1 and +(2+3) are invalid).
// - "-" could be used as a unary operation (-1 and -(2+3) are valid).
// - There will be no two consecutive operators in the input.
// - Every number and running calculation will fit in a signed 32-bit integer.

using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N19_Stacks.P01_BasicCalculator;

public class Solution
{
    // Time complexity: O(n), Space complexity: O(n).
    public static int Calculator(string expression)
    {
        int sum = 0, num = 0, sign = 1;
        var stack = new Stack<int>();

        foreach (char ch in expression)
        {
            if (ch >= '0' && ch <= '9')
            {
                num = num * 10 + (ch - '0');
            }
            else if (ch == '+' || ch == '-')
            {
                sum += sign * num;
                num = 0;
                sign = ch == '+' ? 1 : -1;
            }
            else if (ch == '(')
            {
                stack.Push(sum);
                sum = 0;
                stack.Push(sign);
                sign = 1;
            }
            else if (ch == ')')
            {
                sum += sign * num;
                num = 0;

                int prevSign = stack.Pop();
                int prevSum = stack.Pop();

                sum = prevSum + prevSign * sum;
            }
        }

        sum += sign * num;
        return sum;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run("-(1+2)-(3-(4-5))", -7);
    }

    private static void Run(string expression, int expectedResult)
    {
        int result = Solution.Calculator(expression);
        Utilities.PrintSolution(expression, result);
        Assert.AreEqual(expectedResult, result);
    }
}
