// Maximum Area Rectangle With Point Constraints I
// ===============================================
//
// You are given an array of `points`, where `points[i]` have two values: [x_i, y_i], representing its position on a
// flat plane.
//
// Your goal is to find the largest rectangle (having maximum area) that can be formed using any four points as the
// corners. The rectangle should meet the following conditions:
//
// - It has its borders parallel to the axes.
// - It should not contain any other points inside or along its border.
//
// Return the area of the largest rectangle you can create. If no such rectangle can be formed, return -1.
//
// Constraints:
//
// - 1 ≤ `points.length` ≤ 10
// - `points[i].length` = 2
// - 0 ≤ x_i, y_i ≤ 100
// - All the given points are unique.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N29_MathAndGeometry.P09_MaximumAreaRectangleWithPointConstraintsI;

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
