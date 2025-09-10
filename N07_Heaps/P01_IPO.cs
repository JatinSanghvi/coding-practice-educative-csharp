// IPO
// ===
//
// An investor is looking to maximize their capital by undertaking a set of profitable projects. Due to limited time and
// resources, they can complete at most `k` distinct projects.
//
// There are n available projects. Each project `i` has:
//
// - A profit of `profits[i]` earned upon completion.
// - A minimum capital requirement of `capital[i]` needed to start the project.
//
// The investor starts with an initial capital of `c`. After completing a project, its profit is immediately added to
// the investor's current capital.
//
// The goal is to choose up to `k` different projects in a way that maximizes the investor's final capital. Return the
// maximum capital achievable after completing these projects.
//
// It is guaranteed that the answer fits within a 32-bit signed integer.
//
// Constraints:
//
// - 1 ≤ `k` ≤ 10^3
// - 0 ≤ `c` ≤ 10^9
// - n == `profits.length`
// - n == `capitals.length`
// - 1 ≤ n ≤ 10^3
// - 0 ≤ `profits[i]` ≤ 10^4
// - 0 ≤ `capitals[i]` ≤ 10^9

using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N07_Heaps.P01_IPO;

public class Solution
{
    // Time complexity: O((n+k)*logn), Space complexity: O(n).
    public static int MaximumCapital(int c, int k, int[] capitals, int[] profits)
    {
        var capitalsHeap = new PriorityQueue<(int value, int index), int>();
        for (int i = 0; i < capitals.Length; i++)
        {
            capitalsHeap.Enqueue((capitals[i], i), capitals[i]);
        }

        var profitsHeap = new PriorityQueue<int, int>();
        while (k > 0)
        {
            while (capitalsHeap.Count != 0 && capitalsHeap.Peek().value <= c)
            {
                int index = capitalsHeap.Dequeue().index;
                profitsHeap.Enqueue(profits[index], -profits[index]);
            }

            if (profitsHeap.Count == 0) { break; }
            c += profitsHeap.Dequeue();
            k--;
        }

        return c;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run(1, 2, [1, 2, 4], [1, 2, 4], 4);
        Run(1, 3, [1, 2, 5], [1, 2, 5], 4);
        Run(1, 2, [1, 1, 1], [3, 2, 1], 6);
    }

    private static void Run(int c, int k, int[] capitals, int[] profits, int expectedResult)
    {
        int result = Solution.MaximumCapital(c, k, capitals, profits);
        Utilities.PrintSolution((c, k, capitals, profits), result);
        Assert.AreEqual(expectedResult, result);
    }
}
