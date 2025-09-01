// Rectangle Area
// ==============
//
// You are given the coordinates of two axis-aligned rectangles in a 2D plane. Your task is to calculate the total area
// covered by both rectangles.
//
// - The first rectangle is specified by the coordinates of its bottom-left corner (`ax1`, `ay1`) and top-right corner
//   (`ay1`, `ay2`).
// - Similarly, the second rectangle is defined by its bottom-left corner (`bx1`, `by1`) and top-right corner (`bx2`,
//   `by2`).
//
// > Note: The rectangles may overlap.
//
// Constraints:
//
// - -10^4 ≤ `ax1` ≤ `ax2` ≤ 10^4
// - -10^4 ≤ `ay1` ≤ `ay2` ≤ 10^4
// - -10^4 ≤ `bx1` ≤ `bx2` ≤ 10^4
// - -10^4 ≤ `by1` ≤ `by2` ≤ 10^4

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N29_MathAndGeometry.P07_RectangleArea;

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
