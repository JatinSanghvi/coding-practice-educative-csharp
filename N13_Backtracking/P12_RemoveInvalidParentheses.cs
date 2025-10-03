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

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N13_Backtracking.P12_RemoveInvalidParentheses;

public class Solution
{
    public static IList<string> RemoveInvalidParentheses(string s)
    {
        {
            throw new NotImplementedException();
        }
    }

    internal static class Tests
    {
        public static void Run()
        {
            Run("(a(b)(()", ["(a(b))", "(ab)()"]);
        }

        private static void Run(string s, string[] expectedResult)
        {
            Assert.Throws<NotImplementedException>(() => Solution.RemoveInvalidParentheses(s));

            // string[] result = Solution.RemoveInvalidParentheses(s).ToArray();
            // Utilities.PrintSolution(s, result);
            // CollectionAssert.AreEqual(expectedResult, result);
        }
    }
}