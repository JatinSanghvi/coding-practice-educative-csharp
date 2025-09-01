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

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N29_MathAndGeometry.P06_ValidSquare;

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
