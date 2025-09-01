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

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N19_Stacks.P01_BasicCalculator;

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
