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
