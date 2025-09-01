// Last Day Where You Can Still Cross
// ==================================
//
// You are given two integers, `rows` and `cols`, which represent the number of rows and columns in a 1-based binary
// matrix. In this matrix, each 0 represents land, and each 1 represents water.
//
// Initially, on day 0, the whole matrix will just be all 0s, that is, all land. With each passing day, one of the cells
// of this matrix will get flooded and, therefore, will change to water, that is, from 0 to 1. This continues until the
// entire matrix is flooded. You are given a 1-based array, `waterCells`, that records which cell will be flooded on
// each day. Each element `waterCells[i] = [r_i, c_i]` indicates the cell present at the `r_i`-th row and `c_i`-th
// column of the matrix that will change from land to water on the i-th day.
//
// We can cross any cell of the matrix as long as it's land. Once it changes to water, we can't cross it. To cross any
// cell, we can only move in one of the four cardinal directions. Given the number of rows and columns of a 1-based
// binary matrix and a 1-based array, `waterCells`, you are required to find the last day where you can still cross the
// matrix, from top to bottom, by walking over the land cells only.
//
// > Note: You can start from any cell in the top row, and you need to be able to reach just one cell in the bottom row
// > for it to count as a crossing.
//
// Constraints:
//
// - 2 ≤ `rows`, `cols` ≤ 50
// - 4 ≤ `rows` × `cols` ≤ 2500
// - `waterCells.length` == `rows` × `cols`
// - 1 ≤ r_i ≤ `rows`
// - 1 ≤ c_i ≤ `cols`
// - All values of `waterCells` are unique.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N26_UnionFind.P05_LastDayWhereYouCanStillCross;

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
