// Container with Most Water
// =========================
//
// You're given an integer array `height` of length n, and there are n vertical lines drawn such that the two endpoints
// of the ith line are (i,0) and (i, `height[i]`).
//
// Find two lines from the input array that, together with the x-axis, form a container that holds as much water as
// possible. Return the maximum amount of water a container can store.
//
// > Note: You may not slant the container.
//
// Constraints:
//
// - n = `height.length`
// - 2 ≤ n ≤ 10^3
// - 0 ≤ `height[i]` ≤ 10^3

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N30_ChallengeYourself.P15_ContainerWithMostWater;

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
