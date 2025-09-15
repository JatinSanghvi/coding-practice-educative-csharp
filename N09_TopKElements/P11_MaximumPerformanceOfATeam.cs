// Maximum Performance of a Team
// =============================
//
// You are given two integers, `n` and `k`, and two integer arrays, `speed` and `efficiency`, both of length `n`. There
// are `n` engineers numbered from `1` to `n`. The value `speed[i]` represents the speed of the i-th engineer, and
// `efficiency[i]` represents their efficiency.
//
// To form a team with the maximum performance, you need to select at most `k` different engineers from the `n`
// engineers.
//
// The performance of a team is calculated as follows:
//
// The sum of the selected engineers' speeds × the minimum efficiency among the selected engineers
//
// Return the maximum performance of the team. As the result can be a very large number, return it modulo (10^9 + 7).
//
// Constraints:
//
// - 1 ≤ k ≤ n ≤ 10^3
// - `speed.length` == `n`
// - `efficiency.length` == `n`
// - 1 ≤ `speed[i]` ≤ 10^3
// - 1 ≤ `efficiency[i]` ≤ 10^4

using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N09_TopKElements.P11_MaximumPerformanceOfATeam;

public class Solution
{
    // Time complexity: O(n*logn), Space complexity: O(n).
    public static int MaxPerformance(int n, int[] speed, int[] efficiency, int k)
    {
        // Use greedy algorithm: Take k workers with highest efficiency. Pick a lower efficiency engineer, one at a time
        // while retaining the top k engineers with highest speeds found so far.
        var engineers = new (int efficiency, int speed)[n];
        for (int i = 0; i < n; i++)
        {
            engineers[i] = (efficiency[i], speed[i]);
        }

        Array.Sort(engineers);

        var speedQueue = new PriorityQueue<int, int>();
        long maxPerformance = 0;
        long sumSpeed = 0;

        for (int i = n - 1; i >= 0; i--)
        {
            (int engEfficiency, int engSpeed) = engineers[i];

            if (speedQueue.Count == k)
            {
                long performance = (sumSpeed + engSpeed - speedQueue.Peek()) * engEfficiency;
                maxPerformance = Math.Max(maxPerformance, performance);
                int dequeuedSpeed = speedQueue.EnqueueDequeue(engSpeed, engSpeed);
                sumSpeed += engSpeed - dequeuedSpeed;
            }
            else
            {
                long performance = (sumSpeed + engSpeed) * engEfficiency;
                maxPerformance = Math.Max(maxPerformance, performance);
                speedQueue.Enqueue(engSpeed, engSpeed);
                sumSpeed += engSpeed;
            }
        }

        return (int)(maxPerformance % 1_000_000_007);
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run(5, [5, 1, 3, 6, 2], [4, 3, 9, 7, 2], 3, 63);
        Run(4, [1, 2, 3, 4], [4, 3, 2, 1], 2, 10);
    }

    private static void Run(int n, int[] speed, int[] efficiency, int k, int expectedResult)
    {
        int result = Solution.MaxPerformance(n, speed, efficiency, k);
        Utilities.PrintSolution((n, speed, efficiency, k), result);
        Assert.AreEqual(expectedResult, result);
    }
}
