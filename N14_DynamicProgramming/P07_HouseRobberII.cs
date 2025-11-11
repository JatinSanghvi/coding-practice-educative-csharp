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

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N14_DynamicProgramming.P07_HouseRobberII;

public class Solution
{
    // Time complexity: O(n), Space complexity: O(1).
    public static int HouseRobber(int[] money)
    {
        // If the circle has a single house, it is not considered adjacent to itself.
        if (money.Length == 1)
        {
            return money[0];
        }

        return Math.Max(Solve(0, money.Length - 1), Solve(1, money.Length));

        int Solve(int start, int end)
        {
            int max = 0;
            int maxWithoutPrev = 0;
            for (int i = start; i != end; i++)
            {
                (max, maxWithoutPrev) = (Math.Max(max, maxWithoutPrev + money[i]), max);
            }

            return max;
        }
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([1, 2, 1, 2, 1], 4);
        Run([1, 2, 3, 1, 2], 5);
    }

    private static void Run(int[] money, int expectedResult)
    {
        int result = Solution.HouseRobber(money);
        Utilities.PrintSolution(money, result);
        Assert.AreEqual(expectedResult, result);
    }
}
