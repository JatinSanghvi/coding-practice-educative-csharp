// Rectangle Overlap
// =================
//
// An axis-aligned rectangle is represented by a list [x1​,y1​,x2​,y2​], where:
//
// - (x1​,y1​) denotes the coordinates of the bottom-left corner.
// - (x2​,y2​) denotes the coordinates of the top-right corner.
//
// The rectangle's sides are aligned with the axes:
//
// - The top and bottom edges are parallel to the X-axis.
// - The left and right edges are parallel to the Y-axis.
//
// > Note: Two rectangles are considered to overlap if their intersection forms a region with a positive area.
// > Rectangles that touch only at the edges or corners are not considered to overlap.
//
// Determine if the two axis-aligned rectangles, `rec1` and `rec2`, overlap. Return TRUE if they overlap; otherwise,
// return FALSE.
//
// Constraints:
//
// - `rec1.length` == 4
// - `rec2.length` == 4
// - -10^4 ≤ `rec1[i]`, `rec2[i]` ≤ 10^4
// - `rec1` and `rec2` represent a valid rectangle with a non-zero area.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N29_MathAndGeometry.P03_RectangleOverlap;

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
