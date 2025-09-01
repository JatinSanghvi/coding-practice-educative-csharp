// Find the Town Judge
// ===================
//
// There are `n` people numbered from 1 to `n` in a town. There's a rumor that one of these people is secretly the town
// judge. A town judge must meet the following conditions:
//
// 1. The judge doesn't trust anyone.
// 2. Everyone else in the town (except the town judge) trusts the judge.
// 3. There is exactly one person who fulfills both the above conditions.
//
// You are given an integer `n` and a two-dimensional array, `trust`, where each entry `trust[i] = [a_i, b_i]` indicates
// that the person labeled `a_i` trusts the person labeled `b_i`. If a trust relationship is not specified in the
// `trust` array, it does not exist. Your task is to determine the label of the town judge, if one can be identified. If
// no such person exists, return -1.
//
// Constraints:
//
// - 1 ≤ `n` ≤ 1000
// - 0 ≤ `trust.length` ≤ 10^4
// - `trust[i].length` == 2
// - `a_i` ≠ `b_i`
// - 1 ≤ `a_i`, `b_i` ≤ `n`
// - All the pairs in `trust` are unique.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N20_Graphs.P07_FindTheTownJudge;

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
