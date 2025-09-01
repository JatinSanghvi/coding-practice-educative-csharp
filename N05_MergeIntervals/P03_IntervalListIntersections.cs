// Interval List Intersections
// ===========================
//
// Given two lists of closed intervals, `intervalLista` and `intervalListb`, return the intersection of the two
// interval lists.
//
// Each interval in the lists has its own start and end time and is represented as `[start, end]`. Specifically:
//
// - intervalLista[i] = [start_i, end_i]
// - intervalListb[j] = [start_j, end_j]
//
// The intersection of two closed intervals `i` and `j` is either:
//
// - An empty set, if they do not overlap, or
// - A closed interval `[max(start_i, start_j), min(end_i, end_j)]` if they do overlap.
//
// Also, each list of intervals is pairwise disjoint and in sorted order.
//
// Constraints:
//
// - 0 ≤ intervalLista.length, intervalListb.length ≤ 1000
// - intervalLista.length + intervalListb.length >= 1
// - 0 ≤ start_i < end_i ≤ 10^9
// - end_i < start_i + 1
// - 0 ≤ start_j < end_j ≤ 10^9
// - end_j < start[j + 1]

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N05_MergeIntervals.P03_IntervalListIntersections;

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
