// Evaluate Division
// =================
//
// We are given three arrays:
//
// 1. `equations`: Here, each `equations[i]` represents a pair of variables `[a[i], b[i]]`, where each `a[i]` or `b[i]`
//    is a string that represents a single variable.
//
// 2. `values`: This array contains real numbers that are the result values when the first variable in `equations[i]` is
//    divided by the second. For example, if `equations[i] = ["m", "n"]` and `values[i] = 2.0`, it means that `m / n =
//    2.0`.
//
// 3. `queries`: Here, each `queries[i]` represents a pair of variables `[c[i], d[i]]`, where each `c[i]` or `d[i]` is a
//    string that represents a single variable. The answer to each query must be calculated as `c[i] / d[i]`.
//
// Given these arrays, find the result of each `queries[i]` by dividing the first variable with the second. To answer
// all the queries correctly, use the given `equations` and `values`. If it's impossible to determine the answer to any
// query based on the given equations and values, return -1.0.
//
// > Note: The input is always valid. You may assume that evaluating the queries will not result in division by zero and
// > that there is no contradiction.
//
// Constraints:
//
// - 1 ≤ `equations.length` ≤ 20
// - `equations[i].length` == 2
// - 1 ≤ `a[i].length`, `b[i].length` ≤ 5
// - `values.length` == `equations.length`
// - 0.0 < `values[i]` ≤ 20.0
// - 1 ≤ `queries.length` ≤ 20
// - `queries[i].length` == 2
// - 1 ≤ `c[j].length`, `d[j].length` ≤ 5
// - `a[i], b[i], c[j], d[j]` consist of lower case English letters and digits.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N26_UnionFind.P13_EvaluateDivision;

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
