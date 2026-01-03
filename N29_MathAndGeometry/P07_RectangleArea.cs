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

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N29_MathAndGeometry.P07_RectangleArea;

public class Solution
{
    // Time complexity: O(1), Space complexity: O(1).
    public static int ComputeArea(int ax1, int ay1, int ax2, int ay2, int bx1, int by1, int bx2, int by2)
    {
        return
            (ax2 - ax1) * (ay2 - ay1) + (bx2 - bx1) * (by2 - by1) -
            Math.Max(0, Math.Min(ax2, bx2) - Math.Max(ax1, bx1)) *
            Math.Max(0, Math.Min(ay2, by2) - Math.Max(ay1, by1));
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run(0, 1, 4, 3, 1, 0, 3, 4, 12);
        Run(0, 0, 4, 4, 2, 2, 6, 6, 28);
    }

    private static void Run(int ax1, int ay1, int ax2, int ay2, int bx1, int by1, int bx2, int by2, int expectedResult)
    {
        int result = Solution.ComputeArea(ax1, ay1, ax2, ay2, bx1, by1, bx2, by2);
        Utilities.PrintSolution((ax1, ay1, ax2, ay2, bx1, by1, bx2, by2), result);
        Assert.AreEqual(expectedResult, result);
    }
}
