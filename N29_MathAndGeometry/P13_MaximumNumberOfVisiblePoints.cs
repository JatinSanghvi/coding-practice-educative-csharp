// Maximum Number of Visible Points
// ================================
//
// You are provided with an array, `points`, an integer `angle`, and your `location`, where `points[i] = [x_i, y_i]` and
// `location = [pos_x, pos_y]`, both representing integer coordinates on the X-Y plane.
//
// You initially face directly east from your fixed location and *cannot move*. In other words, `pos_x` and `pos_y`
// cannot be changed. However, you can rotate to adjust your viewing direction. Your field of view, measured in
// *degrees*, is specified by the angle, representing the width of visibility. If you rotate counterclockwise by an
// angle d, your visible field spans the inclusive range of angles [d - 2angle, d + 2angle].
//
// A set of points is visible to you if, for each point, the angle formed by the point, your position, and the immediate
// east direction from your position falls within your field of view.
//
// There can be multiple points at one coordinate. There may be points at your location, and you can always see these
// points regardless of your rotation. Points do not obstruct your vision to other points.
//
// Return the maximum number of points you can see.
//
// Constraints:
//
// - 1 ≤ `points.length` ≤ 1000
// - `points[i].length` == 2
// - `location.length` == 2
// - 0 ≤ `angle` < 360
// - 0 ≤ `pos_x`, `pos_y`, `x_i`, `y_i` ≤ 100

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N29_MathAndGeometry.P13_MaximumNumberOfVisiblePoints;

public class Solution
{
    // Time complexity: O(n*logn), Space complexity: O(n).
    public int VisiblePoints(IList<IList<int>> points, int angle, IList<int> location)
    {
        int sourcePoints = 0;
        int x = location[0], y = location[1];
        var angles = new List<double>();

        foreach (IList<int> point in points)
        {
            int px = point[0], py = point[1];

            if (px == x && py == y)
            {
                sourcePoints += 1;
            }
            else
            {
                angles.Add(Math.Atan2(py - y, px - x) / Math.PI * 180);
            }
        }

        angles.Sort();

        int len = angles.Count;
        for (int i = 0; i != len; i++)
        {
            angles.Add(angles[i] + 360);
        }

        int maxVisiblePoints = 0;
        int high = 0;
        for (int low = 0; low != len; low++)
        {
            while (high != 2 * len && angles[high] - angles[low] <= angle)
            {
                high++;
            }

            maxVisiblePoints = Math.Max(maxVisiblePoints, high - low);
        }

        return maxVisiblePoints + sourcePoints;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([[6, 1], [7, 1], [6, 2], [5, 2], [5, 1], [6, 0]], 0, [6, 1], 2);
        Run([[6, 1], [7, 1], [6, 2], [5, 2], [5, 1], [6, 0]], 90, [6, 1], 4);
        Run([[6, 1], [7, 1], [6, 2], [5, 2], [5, 1], [6, 0]], 359, [6, 1], 6);
    }

    private static void Run(int[][] points, int angle, int[] location, int expectedResult)
    {
        int result = new Solution().VisiblePoints(
            points.Select(point => (IList<int>)point.ToList()).ToList(),
            angle,
            location.ToList()
        );

        Utilities.PrintSolution((points, angle, location), result);
        Assert.AreEqual(expectedResult, result);
    }
}
