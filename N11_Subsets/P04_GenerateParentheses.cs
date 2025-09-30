// Generate Parentheses
// ====================
//
// For a given number, `n`, generate all combinations of balanced parentheses.
//
// Constraints:
//
// - 1 ≤ `n` ≤ 10

using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N11_Subsets.P04_GenerateParentheses;

public class Solution
{
    // Time complexity: O(n*2^2n), Space complexity: O(n).
    public static IList<string> GenerateCombinations(int n)
    {
        var parentheses = new char[2 * n];
        var combinations = new List<string>();
        Solve(0, n, 0);
        return combinations;

        // 'left' and 'right' are counts of allowed parentheses.
        void Solve(int index, int left, int right)
        {
            if (index == 2 * n)
            {
                combinations.Add(new string(parentheses));
                return;
            }

            if (left != 0)
            {
                parentheses[index] = '(';
                Solve(index + 1, left - 1, right + 1);
            }

            if (right != 0)
            {
                parentheses[index] = ')';
                Solve(index + 1, left, right - 1);
            }
        }
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run(3, ["((()))", "(()())", "(())()", "()(())", "()()()"]);
    }

    private static void Run(int n, string[] expectedResult)
    {
        string[] result = Solution.GenerateCombinations(n).ToArray();
        Utilities.PrintSolution(n, result);
        CollectionAssert.AreEqual(expectedResult, result);
    }
}
