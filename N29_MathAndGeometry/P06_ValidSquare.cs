// Valid Square
// ============
//
// Given the coordinates of four points P1​, P2​, P3​, and P4​ in 2D space, determine if these points form a square.
//
// Each point P_i is represented as [x_i, y_i], and the points may be provided in any order.
//
// A square is defined as having:
//
// - Four sides of equal positive length
// - Four right angles (90 degrees)
//
// Constraints:
//
// - `p_1.length` == `p_2.length` == `p_3.length` == `p_4.length` == 2
// - -10^4 ≤ x_i, y_i ≤ 10^4

using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N29_MathAndGeometry.P06_ValidSquare;

public class Solution
{
    // Time complexity: O(1), Space complexity: O(1).
    public static bool ValidSquare(int[] p1, int[] p2, int[] p3, int[] p4)
    {
        // Coinciding points do not form square.
        if (p1[0] == p2[0] && p1[1] == p2[1]) { return false; }

        // Sort points by position.
        var sides = new int[][] { p1, p2, p3, p4 };
        sides = sides.OrderBy(p => p[0]).ThenBy(p => p[1]).ToArray();
        (p1, p2, p3, p4) = (sides[0], sides[1], sides[2], sides[3]);

        // Check formula for points arranged in clockwise or anti clockwise directions.
        return IsSquare(p1, p2, p3, p4) || IsSquare(p1, p3, p2, p4);

        bool IsSquare(int[] p1, int[] p2, int[] p3, int[] p4)
        {
            return
                p2[0] - p1[0] == p3[1] - p1[1] &&
                p1[1] - p2[1] == p3[0] - p1[0] &&
                p4[0] - p2[0] == p3[1] - p4[1] &&
                p4[1] - p2[1] == p4[0] - p3[0];
        }
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([0, 0], [0, 1], [1, 0], [1, 1], true);
        Run([0, 1], [1, 0], [1, 2], [2, 1], true);
    }

    private static void Run(int[] p1, int[] p2, int[] p3, int[] p4, bool expectedResult)
    {
        bool result = Solution.ValidSquare(p1, p2, p3, p4);
        Utilities.PrintSolution((p1, p2, p3, p4), result);
        Assert.AreEqual(expectedResult, result);
    }
}
