// Most Stones Removed with Same Row or Column
// ===========================================
//
// Given an array of n stones in a two-dimensional plane, where each stone is represented by a pair of `x` and `y`
// coordinates, find the maximum number of `stones` we can remove with the following condition:
//
// A stone can be removed if it shares either the same row or the same column with another stone that has not been
// removed so far.
//
// Stones are provided as an array, `stones`, of length n, where stones[i]=[x_i, y_i] represents the ith stone. Return
// the maximum possible number of `stones` that can be removed.
//
// Constraints:
//
// - 1 ≤ `stones.length` ≤ 1000
// - 0 ≤ x_i, y_i ≤ 50

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N26_UnionFind.P03_MostStonesRemovedWithSameRowOrColumn;

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
