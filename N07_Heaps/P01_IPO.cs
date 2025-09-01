// IPO
// ===
//
// An investor is looking to maximize their capital by undertaking a set of profitable projects. Due to limited time and
// resources, they can complete at most `k` distinct projects.
//
// There are n available projects. Each project `i` has:
//
// - A profit of `profits[i]` earned upon completion.
// - A minimum capital requirement of `capital[i]` needed to start the project.
//
// The investor starts with an initial capital of `c`. After completing a project, its profit is immediately added to the
// investor's current capital.
//
// The goal is to choose up to `k` different projects in a way that maximizes the investor's final capital. Return the
// maximum capital achievable after completing these projects.
//
// It is guaranteed that the answer fits within a 32-bit signed integer.
//
// Constraints:
//
// - 1 ≤ `k` ≤ 10^3
// - 0 ≤ `c` ≤ 10^9
// - n == `profits.length`
// - n == `capitals.length`
// - 1 ≤ n ≤ 10^3
// - 0 ≤ `profits[i]` ≤ 10^4
// - 0 ≤ `capitals[i]` ≤ 10^9

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N07_Heaps.P01_IPO;

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
