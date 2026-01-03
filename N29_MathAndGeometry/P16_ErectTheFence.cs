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

using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N29_MathAndGeometry.P16_ErectTheFence;

public class Solution
{
    public int[][] OuterTrees(int[][] trees)
    {
        throw new NotImplementedException();
    }
}

internal static class Tests
{
    public static void Run()
    {
        // _ _ _ x
        // _ x x _
        // _ x x _
        // x _ _ _
        Run([[3, 3], [2, 1], [2, 2], [1, 1], [1, 2], [0, 0]], [[3, 3], [-1, -2], [-3, -3], [-2, -1]]);
    }

    private static void Run(int[][] trees, int[][] expectedResult)
    {
        Assert.Throws<NotImplementedException>(() => new Solution().OuterTrees(trees));

        // int[][] result = new Solution().OuterTrees(trees);
        // Utilities.PrintSolution(trees, result);
        // CollectionAssert.AreEqual(expectedResult, result);
    }
}
