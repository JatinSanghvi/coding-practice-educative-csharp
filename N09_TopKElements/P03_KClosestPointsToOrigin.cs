// K Closest Points to Origin
// ==========================
//
// You are given an array of points where each element `points[i]` = [x_i, y_i] represents a point on the X-Y plane,
// along with an integer `k`. Your task is to find and return the `k` points that are closest to the origin [0, 0].
//
// The distance between two points on the X-Y plane is measured using Euclidean distance, which is calculated as:
//
// (x_2 - x_1)^2 + (y_2 - y_1)^2
//
// > Note: You can return the result in any order. The answer is guaranteed to be unique, except for the order in which
// > points appear.
//
// Constraints:
//
// - 1 ≤ k ≤ `points.length` ≤ 10^3
// - -10^4 ≤ x_i, y_i ≤ 10^4

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N09_TopKElements.P03_KClosestPointsToOrigin;

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
