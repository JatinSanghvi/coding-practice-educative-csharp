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

using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N10_ModifiedBinarySearch.P12_MinimizeMaxDistanceToGasStation;

public class Solution
{
    // Time complexity: O(n*log(maxGap/1e-7)), Space complexity: O(n).
    public double MinimizeGasDistance(int[] stations, int k)
    {
        var gaps = new double[stations.Length - 1];
        for (int i = 0; i != stations.Length - 1; i++)
        {
            gaps[i] = stations[i + 1] - stations[i];
        }

        double maxImpossibleDistance = 0.0, minPossibleDistance = gaps.Max();

        while (minPossibleDistance - maxImpossibleDistance >= 1e-7)
        {
            double distance = (maxImpossibleDistance + minPossibleDistance) / 2;

            if (IsPossible(distance)) { minPossibleDistance = distance; }
            else { maxImpossibleDistance = distance; }
        }

        return minPossibleDistance;

        bool IsPossible(double distance)
        {
            int newStations = 0;
            foreach (double gap in gaps)
            {
                newStations += (int)Math.Floor(gap / distance);
                if (newStations > k) { return false; }
            }

            return true;
        }
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([-2, -1, 7, 9, 13], 1, 4.0);
        Run([-2, -1, 7, 9, 13], 11, 1.0);
    }

    private static void Run(int[] stations, int k, double expectedResult)
    {
        double result = new Solution().MinimizeGasDistance(stations, k);
        Utilities.PrintSolution((stations, k), result);
        Assert.AreEqual(expectedResult, result, 1e-6);
    }
}
