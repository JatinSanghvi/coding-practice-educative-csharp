// Erect the Fence
// ===============
//
// You are given an array of points, `trees`, where `trees[i] = [x_i, y_i]` represents the location of a tree on a 2D
// plane. Your goal is to enclose all the trees using the shortest possible length of rope, forming a fence around the
// garden. A garden is considered well-fenced if every tree lies inside or on the boundary of the fence (i.e., the fence
// forms the convex hull of all the points).
//
// Return the coordinates of the trees that lie exactly on the fence perimeter. You can return the answer in any order.
//
// Constraints:
//
// - 1 ≤ `trees.length` ≤ 300
// - `trees[i].length` == 2
// - 0 ≤ x_i, y_i ≤ 100
// - All the given positions are unique.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N29_MathAndGeometry.P16_ErectTheFence;

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
