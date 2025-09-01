// Check If It Is a Straight Line
// ==============================
//
// You are given an array, `coordinates`, where each element in `coordinates[i]` =[x,y] represents the coordinates of a
// point on a 2D plane. Determine whether all the points in the array lie on a single straight line in the XY plane.
//
// Constraints:
//
// - 2 ≤ `coordinates.length` ≤ 1000
// - `coordinates[i].length` == 2
// - -10^4 ≤ `coordinates[i][0]`, `coordinates[i][1]` ≤ 10^4
// - `coordinates` do not contain any duplicate points.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N29_MathAndGeometry.P01_CheckIfItIsAStraightLine;

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
