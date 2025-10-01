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

using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N12_GreedyTechniques.P07_AssignCookies;

public class Solution
{
    // Time complexity: O(g*logg + c*logc), Space complexity: O(1).
    public static int FindContentChildren(int[] greedFactors, int[] cookieSizes)
    {
        Array.Sort(greedFactors);
        Array.Sort(cookieSizes);

        int g = 0, c = 0;
        while (g != greedFactors.Length && c != cookieSizes.Length)
        {
            if (cookieSizes[c] >= greedFactors[g])
            {
                g++;
            }

            c++;
        }

        return g;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([2, 3, 4], [3, 2, 1], 2);
        Run([2, 3, 4], [4, 3, 2, 1], 3);
    }

    private static void Run(int[] greedFactors, int[] cookieSizes, int expectedResult)
    {
        int[] greedFactorsCopy = greedFactors.ToArray();
        int[] cookieSizesCopy = cookieSizes.ToArray();

        int result = Solution.FindContentChildren(greedFactors, cookieSizes);
        Utilities.PrintSolution((greedFactorsCopy, cookieSizesCopy), result);
        Assert.AreEqual(expectedResult, result);
    }
}
