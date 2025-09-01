// Largest Rectangle in Histogram
// ==============================
//
// Given an array of integers, `heights`, that represents the heights of bars in a histogram, find the area of the
// largest rectangle in the histogram, where the rectangle has a constant width of 1 unit for each bar.
//
// Constraints
//
// - 1 ≤ `heights.length` ≤ 10^5
// - 0 ≤ `heights[i]` ≤ 10^4

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N30_ChallengeYourself.P11_LargestRectangleInHistogram;

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
