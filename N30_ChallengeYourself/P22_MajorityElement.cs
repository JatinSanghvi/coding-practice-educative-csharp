// Majority Element
// ================
//
// Given an array, `nums`, having n integers, return the majority element. An element will be considered a majority
// element if it occurs more than ⌊n/2⌋ times in the array.
//
// > Note: It is safe to assume that the majority element always exists in the array.
//
// Constraints
//
// - n == `nums.length`
// - 1 ≤ n ≤ 5 ∗ 10^4
// - -10^9 ≤ `nums[i]` ≤ 10^9

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N30_ChallengeYourself.P22_MajorityElement;

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
