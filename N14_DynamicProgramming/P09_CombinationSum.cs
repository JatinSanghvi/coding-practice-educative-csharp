// Combination Sum
// ===============
//
// Given an array of distinct integers, `nums`, and an integer, `target`, return a list of all unique combinations of
// `nums` where the chosen numbers sum up to the `target`. The combinations may be returned in any order.
//
// An integer from `nums` may be chosen an unlimited number of times. Two combinations are unique if the frequency of at
// least one of the chosen integers is different.
//
// Constraints:
//
// - 1 ≤ `nums.length` ≤ 30
// - 2 ≤ `nums[i]` ≤ 40
// - 1 ≤ `target` ≤ 40
// - All integers of `nums` are unique.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N14_DynamicProgramming.P09_CombinationSum;

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
