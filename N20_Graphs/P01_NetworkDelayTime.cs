// Network Delay Time
// ==================
//
// A network of `n` nodes labeled 1 to n is provided along with a list of travel times for directed edges represented as
// `times[i] = (x_i, y_i, t_i)`, where `x_i` is the source node, `y_i` is the target node, and `t_i` is the delay time
// from the source node to the target node.
//
// Considering we have a starting node, `k`, we have to determine the minimum time required for all the remaining n - 1
// nodes to receive the signal. Return -1 if it's not possible for all n - 1 nodes to receive the signal.
//
// Constraints:
//
// - 1 ≤ `k` ≤ `n` ≤ 100
// - 1 ≤ `times.length` ≤ 6000
// - `times[i].length` == 3
// - 1 ≤ x, y ≤ `n`
// - x != y
// - 0 ≤ t ≤ 100
// - Unique pairs of (x, y), which means that there should be no multiple edges

using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N20_Graphs.P01_NetworkDelayTime;

public class Solution
{
    // Time complexity: O((v+e)*loge), Space complexity: O(v+e).
    public static int NetworkDelayTime(int[][] times, int n, int k)
    {
        var graph = new List<(int to, int delay)>[n + 1];
        for (int i = 1; i != n + 1; i++)
        {
            graph[i] = new List<(int to, int delay)>();
        }

        foreach (int[] time in times)
        {
            (int from, int to, int delay) = (time[0], time[1], time[2]);
            graph[from].Add((to, delay));
        }

        var queue = new PriorityQueue<int, int>();
        queue.Enqueue(k, 0);

        var visited = new bool[n + 1];
        int visitedNodes = 0;
        int maxDelay = 0;

        while (queue.Count != 0)
        {
            queue.TryDequeue(out int node, out int delay);
            if (visited[node]) { continue; }
            visited[node] = true;
            visitedNodes += 1;

            maxDelay = Math.Max(maxDelay, delay);

            foreach ((int node2, int delay2) in graph[node])
            {
                queue.Enqueue(node2, delay + delay2);
            }
        }

        return visitedNodes == n ? maxDelay : -1;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([[1, 2, 10], [2, 3, 10], [1, 3, 15], [3, 4, 10]], 4, 1, 25);
    }

    private static void Run(int[][] times, int n, int k, int expectedResult)
    {
        int result = Solution.NetworkDelayTime(times, n, k);
        Utilities.PrintSolution((times, n, k), result);
        Assert.AreEqual(expectedResult, result);
    }
}
