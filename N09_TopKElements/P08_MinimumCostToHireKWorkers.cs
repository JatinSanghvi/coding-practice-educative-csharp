// Minimum Cost to Hire K Workers
// ==============================
//
// You are given n workers, each characterized by two attributes:
//
// - `quality[i]`: Represents the work quality of the i-th worker.
// - `wage[i]`: Represents the minimum wage expectation of the i-th worker.
//
// You want to hire exactly `k` workers to form a paid group, and you must follow these payment rules:
//
// 1. Wage expectation: Every worker in the group must be paid at least their minimum wage expectation.
// 2. Proportional pay: The pay for each worker must be directly proportional to their quality. For example, if one
//    worker's quality is twice that of another, they must be paid twice as much.
//
// Your goal is to determine the least amount of money required to hire exactly `k` workers while satisfying the above
// conditions.
//
// Constraints
//
// - `n` == `quality.length` == `wage.length`
// - 1 ≤ k ≤ n ≤ 10^3
// - 1 ≤ `quality[i]`, `wage[i]` ≤ 10^3

using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N09_TopKElements.P08_MinimumCostToHireKWorkers;

public class Solution
{
    // Time complexity: O(n*logn), Space complexity: O(n).
    public static double MinCostToHireWorkers(int[] quality, int[] wage, int k)
    {
        // Worker with maximum wage-to-quality ratio in a group will determine the pay for rest of the group.
        // Our group should have one worker with minimum ratio and other workers with minimum quality.
        var wageToQualities = new (double, int)[quality.Length];

        for (int i = 0; i < quality.Length; i++)
        {
            wageToQualities[i] = ((double)wage[i] / quality[i], quality[i]);
        }

        Array.Sort(wageToQualities);

        var qualities = new PriorityQueue<int, int>(k + 1);
        int totalQuality = 0;
        double minCost = double.MaxValue;

        foreach ((double wageToQuality, int currQuality) in wageToQualities)
        {
            qualities.Enqueue(currQuality, -currQuality);
            totalQuality += currQuality;

            if (qualities.Count > k)
            {
                int oldQuality = qualities.Dequeue();
                totalQuality -= oldQuality;
            }

            if (qualities.Count == k)
            {
                minCost = Math.Min(minCost, wageToQuality * totalQuality);
            }
        }

        return minCost;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([1, 2, 3], [1, 2, 3], 2, 5.0);
        Run([1, 2, 3], [3, 2, 1], 2, 5.0);
    }

    private static void Run(int[] quality, int[] wage, int k, double expectedResult)
    {
        double result = Solution.MinCostToHireWorkers(quality, wage, k);
        Utilities.PrintSolution((quality, wage, k), result);
        Assert.AreEqual(expectedResult, result, 1e-5);
    }
}
