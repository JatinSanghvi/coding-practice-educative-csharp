// Climbing Stairs
// ===============
//
// You are climbing a staircase. It takes `n` steps to reach the top. Each time, you can either climb 1 or 2 steps. In
// how many distinct ways can you climb to the top?
//
// Constraints:
//
// - 1 ≤ `n` ≤ 45

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N14_DynamicProgramming.P18_ClimbingStairs;

public class Solution
{
    // Time complexity: O(n), Space complexity: O(1).
    public static int ClimbStairs(int n)
    {
        int prevWays = 1;
        int ways = 1;

        for (int i = 2; i != n + 1; i++)
        {
            (ways, prevWays) = (ways + prevWays, ways);
        }

        return ways;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run(1, 1);
        Run(5, 8);
    }

    private static void Run(int n, int expectedResult)
    {
        int result = Solution.ClimbStairs(n);
        Utilities.PrintSolution(n, result);
        Assert.AreEqual(expectedResult, result);
    }
}
