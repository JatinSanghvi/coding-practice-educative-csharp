// Parsing a Boolean Expression
// ============================
//
// You are given a string, `expression`, that represents a boolean expression. The expression can take one of the
// following forms:
//
// - `'t'`: Represents the boolean value TRUE.
// - `'f'`: Represents the boolean value FALSE.
// - `'!(expr)'`: Represents a NOT operation applied to a subexpression `expr`. It returns the logical negation of
//   `expr`.
// - `'&(expr1, expr2, ..., exprN)'`: Represents an AND operation over one or more subexpressions. It returns TRUE only
//   if all subexpressions evaluate to TRUE.
// - `'|(expr1, expr2, ..., exprN)'`: Represents an OR operation over one or more subexpressions. It returns TRUE if at
//   least one of the subexpressions evaluates to TRUE.
//
// Your task is to parse this expression and return its boolean evaluation result.
//
// > Note: The input expression is guaranteed to always be valid and strictly adhere to the specified format and rules.
//
// Constraints:
//
// - 1 ≤ `expression.length` ≤ 20000
// - `expression[i]` is one of the following characters: `'('`, `')'`, `'&'`, `'|'`, `'!'`, `'t'`, `'f'`, and `','`.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N19_Stacks.P12_ParsingABooleanExpression;

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
