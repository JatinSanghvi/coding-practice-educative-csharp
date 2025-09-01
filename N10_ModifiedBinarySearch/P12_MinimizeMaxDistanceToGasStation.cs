// Minimize Max Distance to Gas Station
// ====================================
//
// You are given an integer array, `stations`, representing the positions of existing gas stations along the x-axis. You
// are also given an integer `k`, indicating the number of additional gas stations you must add. These new gas stations
// can be placed at any position along the x-axis, including non-integer locations.
//
// A penalty is the maximum distance between two adjacent gas stations after placing the `k` new stations. Your task is
// to return the smallest possible value of this penalty. An answer is correct if it is within 10^-6 of the actual
// answer.
//
// Constraints:
//
// - 10 ≤ `stations.length` ≤ 2000
// - 0 ≤ `stations[i]` ≤ 10^8
// - The `stations` array is sorted in a strictly increasing order.
// - 1 ≤ `k` ≤ 10^6

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N10_ModifiedBinarySearch.P12_MinimizeMaxDistanceToGasStation;

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
