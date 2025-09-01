// Loud and Rich
// =============
//
// You're given a group of individuals where everyone has a specific amount of money and a different level of quietness.
// Additionally, you're given an array `richer` = [x_i,y_i], so that x_i has more money than y_i. The quietness level of
// each individual is represented using an array named `quiet`.
//
// Return an integer array `res`, where `res[i]` = `y`. If `y` has the lowest value in `quiet[y]` among all individuals,
// who have equal or more money than the individual `i`.
//
// Constraints:
//
// - n = `quiet.length`
// - 1 ≤ n ≤ 500
// - 0 ≤ `quiet[i]` < n
// - All the values of `quiet` are unique.
// - 0 ≤ `richer.length` ≤ n ∗ (n - 1) / 2
// - 0 ≤ `x[i]`, `y[i]` < `n`
// - x_i ≠ y_i
// - All the pairs of `richer` are unique.
// - The observations in `richer` are all logically consistent.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N30_ChallengeYourself.P18_LoudAndRich;

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
