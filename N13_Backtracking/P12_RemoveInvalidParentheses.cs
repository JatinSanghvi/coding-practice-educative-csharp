// Remove Invalid Parentheses
// ==========================
//
// You are given a string, `s`, that contains:
//
// - Lowercase English letters
// - Opening `'('` and closing `')'` parentheses
//
// A string is considered valid if:
//
// 1. All opening parentheses `'('` are closed properly by a matching `')'`.
// 2. The parentheses are in the correct order and nesting.
// 3. Letters can appear anywhere and do not affect validity.
//
// Return all possible valid strings that can be formed by removing the minimum number of invalid parentheses. The
// answer must be a list of unique strings, in any order.
//
// Constraints:
//
// - 1 ≤ `s.length` ≤ 25
// - `s` consists of lowercase English letters and parentheses `'('` and `')'`.
// - There will be at most `20` parentheses in `s`.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N13_Backtracking.P12_RemoveInvalidParentheses;

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
