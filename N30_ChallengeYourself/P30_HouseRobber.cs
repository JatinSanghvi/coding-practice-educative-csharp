// House Robber
// ============
//
// As a skilled thief, you are planning to rob multiple houses on a street, each of which contains a substantial amount
// of money. However, you cannot rob the adjacent houses due to the connected security systems. Otherwise, the police
// will be contacted automatically.
//
// Given an array of integers, `nums`, representing the amount of money present in each house, return the maximum amount
// of money that you can successfully steal without notifying the police.
//
// Constraints
//
// - 1≤ `nums.length` ≤103
// - 0≤ `nums[i]` ≤1000

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N30_ChallengeYourself.P30_HouseRobber;

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
