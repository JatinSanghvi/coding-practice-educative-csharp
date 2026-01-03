// Minimum Cuts to Divide a Circle
// ===============================
//
// Given an integer `n`, determine the minimum number of cuts required to divide the circle into n equal slices. A valid
// cut in a circle is defined as one of the following:
//
// 1. A cut is represented by a straight line that passes through the circle's center and touches two points on its
//    edge.
// 2. A cut is represented by a straight line touching one point on the circle's edge and center.
//
// Constraints:
//
// - 1 ≤ `n` ≤ 100

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N29_MathAndGeometry.P02_MinimumCutsToDivideACircle;

public class Solution
{
    // Time complexity: O(1), Space complexity: O(1).
    public static int NumberOfCuts(int n)
    {
        if (n == 1) { return 0; }
        else if (n % 2 == 0) { return n / 2; }
        else { return n; }
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run(1, 0);
        Run(2, 1);
        Run(3, 3);
    }

    private static void Run(int n, int expectedResult)
    {
        int result = Solution.NumberOfCuts(n);
        Utilities.PrintSolution(n, result);
        Assert.AreEqual(expectedResult, result);
    }
}
