// The Skyline Problem
// ===================
//
// Imagine standing at a distance, viewing the skyline of a city. The skyline is the shape formed by all the buildings
// in the city when viewed together. Your task is to determine the shape of this skyline, given all the buildings'
// position and height. Each building is represented by three values in the array `buildings`, where buildings[i] =
// [left_i, right_i, height_i]:
//
// 1. `left_i` is the x-coordinate where the i-th building starts.
// 2. `right_i` is the x-coordinate where the i-th building ends.
// 3. `height_i` is the height of the i-th building.
//
// All buildings are rectangles that sit on flat ground (height 0). The skyline should be a list of points that define
// its outline, with each point showing where the height changes as you move from left to right. The final point should
// have a height of 0, marking where the last building ends.
//
// > Note: The output skyline should not have multiple horizontal lines at the same height in a row. For example, an
// > output like [...,[1,4],[3,6],[5,6],[7,6],[8,3],...] is incorrect. The three lines with height 6 should be combined
// > into one, so the correct version would be [...,[1,4],[3,6],[8,3],...].
//
// Constraints:
//
// - 1 ≤ `buildings.length` ≤ 10^3
// - 0 ≤ `left_i` < `right_i` ≤ 10^4
// - 0 ≤ `height_i` ≤ 10^4
// - `buildings` is sorted by `left_i` in ascending order.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N26_UnionFind.P10_TheSkylineProblem;

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
