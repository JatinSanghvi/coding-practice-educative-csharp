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
    // Time complexity: O(1), Space complexity: O(1).
    public bool IsRectangleOverlap(int[] rec1, int[] rec2)
    {
        bool xOverlap = rec1[0] < rec2[2] && rec1[2] > rec2[0];
        bool yOverlap = rec1[1] < rec2[3] && rec1[3] > rec2[1];
        return xOverlap && yOverlap;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([0, 1, 4, 3], [1, 0, 3, 4], true);
        Run([0, 0, 4, 4], [1, 1, 3, 3], true);
        Run([0, 0, 1, 1], [1, 0, 2, 1], false);
    }

    private static void Run(int[] rec1, int[] rec2, bool expectedResult)
    {
        bool result = new Solution().IsRectangleOverlap(rec1, rec2);
        Utilities.PrintSolution((rec1, rec2), result);
        Assert.AreEqual(expectedResult, result);
    }
}
