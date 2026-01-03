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
    // Time complexity: O(n), Space complexity: O(1).
    public bool CheckStraightLine(int[][] coordinates)
    {
        // Slope = (y1 - y0) / (x1 - x0) => dy1 / dx1
        // Slope1 == Slope2 => dy1 / dx1 == dy2 / dx2 => dy1 * dx2 == dy2 * dx1.

        int x0 = coordinates[0][0], y0 = coordinates[0][1];

        int dy1 = coordinates[1][1] - y0;
        int dx1 = coordinates[1][0] - x0;

        foreach (int[] coordinate in coordinates)
        {
            int dy2 = coordinate[1] - y0;
            int dx2 = coordinate[0] - x0;

            if (dy1 * dx2 != dy2 * dx1)
            {
                return false;
            }
        }

        return true;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([[2, 1], [-2, -1], [0, 0]], true);
        Run([[2, 1], [-2, 1], [0, 1]], true);
        Run([[2, 1], [2, -1], [2, 0]], true);
        Run([[2, 1], [1, 2], [2, 2]], false);
    }

    private static void Run(int[][] coordinates, bool expectedResult)
    {
        bool result = new Solution().CheckStraightLine(coordinates);
        Utilities.PrintSolution(coordinates, result);
        Assert.AreEqual(expectedResult, result);
    }
}
