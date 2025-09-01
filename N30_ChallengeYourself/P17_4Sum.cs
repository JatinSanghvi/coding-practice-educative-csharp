// 4Sum
// ====
//
// Given an array `nums` of n integers, return an array of all the unique quadruplets, [`nums[a]`, `nums[b]`, `nums[c]`,
// `nums[d]`] such that:
//
// - 0 ≤ `a`, `b`, `c`, `d` < n
// - `a`, `b`, `c`, and `d` are distinct.
// - `nums[a]` + `nums[b]` + `nums[c]` + `nums[d]` = `target`
//
// You may return the answer in any order.
//
// Constraints:
//
// - 1 ≤ `nums.length` ≤ 200
// - -10^9 ≤ `nums[i]` ≤ 10^9
// - -10^9 ≤ `target` ≤ 10^9

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N30_ChallengeYourself.P17_4Sum;

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
