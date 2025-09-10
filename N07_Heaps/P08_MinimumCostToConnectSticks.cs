// Minimum Cost to Connect Sticks
// ==============================
//
// You are given a set of sticks with positive integer lengths represented as an array, `sticks`, where `sticks[i]`
// denotes the length of the i-th stick.
//
// You can connect any two sticks into one stick at a cost equal to the sum of their lengths. Once two sticks are
// combined, they form a new stick whose length is the sum of the two original sticks. This process continues until there
// is only one stick remaining.
//
// Your task is to determine the minimum cost required to connect all the sticks into a single stick.
//
// Constraints:
//
// - 1 ≤ `sticks.length` ≤ 10^3
// - 1 ≤ `sticks[i]` ≤ 10^3

using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N07_Heaps.P08_MinimumCostToConnectSticks;

public class Solution
{
    // Time complexity: O(n*logn), Space complexity: O(n).
    public static int ConnectSticks(int[] sticks)
    {
        var sticksQueue = new PriorityQueue<int, int>(sticks.Select(s => (s, s)));

        int cost = 0;
        while (sticksQueue.Count != 1)
        {
            int len1 = sticksQueue.Dequeue();
            int len2 = sticksQueue.Dequeue();
            int len = len1 + len2;
            cost += len;
            sticksQueue.Enqueue(len, len);
        }

        return cost;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([8, 4, 2, 1, 1], 30);
    }

    private static void Run(int[] sticks, int expectedResult)
    {
        int result = Solution.ConnectSticks(sticks);
        Utilities.PrintSolution(sticks, result);
        Assert.AreEqual(expectedResult, result);
    }
}
