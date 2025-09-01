// Minimum Remove to Make Valid Parentheses
// ========================================
//
// Given a string, `s`, that may have matched and unmatched parentheses, remove the minimum number of parentheses so
// that the resulting string represents a valid parenthesization. For example, the string "a(b)" represents a valid
// parenthesization while the string "a(b" doesn't, since the opening parenthesis doesn't have any corresponding closing
// parenthesis.
//
// Constraints:
//
// - 1 ≤ `s.length` ≤ 10^3
// - `s[i]` is either an opening parenthesis '(', a closing parenthesis ')', or a lowercase English letter.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N19_Stacks.P03_MinimumRemoveToMakeValidParentheses;

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
