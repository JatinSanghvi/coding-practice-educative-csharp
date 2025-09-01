// House Robber II
// ===============
//
// A professional robber plans to rob some houses along a street. These houses are arranged in a circle, which means
// that the first and the last house are neighbors. The robber cannot rob adjacent houses because they have security
// alarms installed.
//
// Following the constraints mentioned above and given an integer array `money` representing the amount of money in each
// house, return the maximum amount the robber can steal without alerting the police.
//
// Constraints:
//
// - 1 ≤ `money.length` ≤ 10^3
// - 0 ≤ `money[i]` ≤ 10^3

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N14_DynamicProgramming.P07_HouseRobberII;

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
