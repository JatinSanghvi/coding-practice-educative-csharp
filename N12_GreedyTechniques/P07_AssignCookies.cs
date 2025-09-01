// Assign Cookies
// ==============
//
// You are given two integer arrays:
//
// 1. `greedFactors`: This array represents the minimum cookie size required for each child to be content. Specifically,
//    `greedFactors[i]` denotes the minimum cookie size that child `i` will accept to be satisfied.
// 2. `cookieSizes`: This array represents the sizes of the available cookies. For example, `cookieSizes[j]` denotes the
//    size of cookie `j`.
//
// Your objective is to distribute the cookies in a way that maximizes the number of content children. A child `i` is
// content if they receive a cookie that is at least as large as their greed factor, i.e., `cookieSizes[j] >=
// greedFactors[i]`. Each child can be assigned at most one cookie, which can only be given to one child.
//
// Write an algorithm to maximize the number of children who can be content by assigning available cookies
// appropriately.
//
// Constraints:
//
// - 1 ≤ `greedFactors.length` ≤ 1000
// - 0 ≤ `cookieSizes.length` ≤ 1000
// - 1 ≤ `greedFactors[i]`, `cookieSizes[j]` ≤ 10^5

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N12_GreedyTechniques.P07_AssignCookies;

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
