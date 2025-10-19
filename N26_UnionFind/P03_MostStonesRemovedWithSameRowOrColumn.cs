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

using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N26_UnionFind.P03_MostStonesRemovedWithSameRowOrColumn;

public class Solution
{
    // Time complexity: O(n), Space complexity: O(n).
    public static int RemoveStones(int[][] stones)
    {
        var parents = new Dictionary<(bool isRow, int num), (bool, int)>();
        var ranks = new Dictionary<(bool isRow, int num), int>();
        int groups = 0;

        foreach (int[] stone in stones)
        {
            int row = stone[0], col = stone[1];

            if (!parents.ContainsKey((true, row)))
            {
                parents[(true, row)] = (true, row);
                ranks[(true, row)] = 1;
                groups++;
            }

            if (!parents.ContainsKey((false, col)))
            {
                parents[(false, col)] = (false, col);
                ranks[(false, col)] = 1;
                groups++;
            }

            if (Union((true, row), (false, col)))
            {
                groups--;
            }
        }

        return stones.Length - groups;

        bool Union((bool, int) x1, (bool, int) x2)
        {
            (bool, int) p1 = Find(x1);
            (bool, int) p2 = Find(x2);

            if (p1 == p2) { return false; }
            if (ranks[p1] == ranks[p2]) { ranks[p1]++; }

            if (ranks[p1] > ranks[p2]) { parents[p2] = p1; }
            else { parents[p1] = p2; }

            return true;
        }

        (bool, int) Find((bool, int) x)
        {
            if (parents[x] != x) { parents[x] = Find(parents[x]); }
            return parents[x];
        }
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([[0, 0], [1, 1], [2, 2]], 0);
        Run([[0, 0], [1, 1], [2, 2], [0, 2]], 2);
        Run([[0, 0], [1, 1], [2, 2], [0, 2], [2, 0]], 3);
    }

    private static void Run(int[][] stones, int expectedResult)
    {
        int result = Solution.RemoveStones(stones);
        Utilities.PrintSolution(stones, result);
        Assert.AreEqual(expectedResult, result);
    }
}
