// Remove Covered Intervals
// ========================
//
// Given an array of `intervals`, where each interval is represented as `intervals[i] = [l_i, r_i)` (indicating the
// range from `l_i` to `r_i`, inclusive of `l_i` and exclusive of `r_i`), remove all intervals that are completely
// covered by another interval in the list. Return the count of intervals that remain after removing the covered ones.
//
// > Note: An interval [a, b) is considered covered by another interval [c, d) if and only if c <= a and b <= d.
//
// Constraints:
//
// - 1 ≤ intervals.length ≤ 1000
// - intervals[i].length == 2
// - 0 ≤ l_i < r_i ≤ 10^5
// - All the given intervals are unique.

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N05_MergeIntervals.P06_RemoveCoveredIntervals;

public class Solution
{
    // Time complexity: O(n*logn), Space complexity: O(1).
    public int RemoveCoveredIntervals(int[][] intervals)
    {
        // Sort in ascending order by start position, and then in descending order by end position.
        Array.Sort(intervals, (i1, i2) => i1[0] == i2[0] ? i2[1] - i1[1] : i1[0] - i2[0]);

        int uncoveredCount = 0;
        int end = -1;

        foreach (int[] interval in intervals)
        {
            if (interval[1] > end)
            {
                uncoveredCount++;
                end = interval[1];
            }
        }

        return uncoveredCount;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([[1, 9], [2, 8], [3, 7], [4, 6]], 1);
        Run([[1, 6], [2, 7], [3, 8], [4, 9]], 4);
    }

    private static void Run(int[][] intervals, int expectedResult)
    {
        int result = new Solution().RemoveCoveredIntervals(intervals);
        Utilities.PrintSolution(intervals, result);
        Assert.AreEqual(expectedResult, result);
    }
}
