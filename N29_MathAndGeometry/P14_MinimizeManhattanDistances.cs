// Minimize Manhattan Distances
// ============================
//
// You are given an array, `points`, where each element in `points[i]` = [x_j, y_i] represents the integer coordinates
// of a point in a 2D plane. The distance between any two points is defined as the Manhattan distance.
//
// Your task is to determine and return the smallest possible value for the maximum distance between any two points
// after removing exactly one point from the array.
//
// Constraints:
//
// - 3 ≤ `points.length` ≤ 10^3
// - `points[i].length` == 2
// - 1 ≤ `points[i][0]`, `points[i][1]` ≤ 10^3

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N29_MathAndGeometry.P14_MinimizeManhattanDistances;

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
