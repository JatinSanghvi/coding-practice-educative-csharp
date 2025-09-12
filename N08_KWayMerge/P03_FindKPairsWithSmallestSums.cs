// Find K Pairs with Smallest Sums
// ===============================
//
// You are given two integer arrays, `list1` and `list2`, sorted in non-decreasing order, and an integer, `k`.
//
// A pair (u, v) is defined as one element u chosen from `list1` and one element v chosen from `list2`.
//
// Your task is to return the `k` pairs (u1, v1), (u2, v2), ..., (uk, vk) whose sums u1 + v1, u2 + v2, ..., uk + vk are
// the smallest among all possible such pairs.
//
// Constraints:
//
// - 1 ≤ `list1.length`, `list2.length` ≤ 500
// - -10^4 ≤ `list1[i]`, `list2[i]` ≤ 10^4
// - 1 ≤ `k` ≤ 10^3
// - Input lists should be sorted in ascending order.
// - If the value of `k` exceeds the total number of valid pairs that may be formed, return all the pairs.

using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N08_KWayMerge.P03_FindKPairsWithSmallestSums;

public class Solution
{
    // Time complexity: O(n*logn) where n=min(target,possible-pairs), Space complexity: O(n).
    public static IList<IList<int>> KSmallestPairs(int[] list1, int[] list2, int target)
    {
        var pairs = new HashSet<(int, int)>();
        var queue = new PriorityQueue<(int, int), (int, int)>();

        if (list1.Length != 0 && list2.Length != 0)
        {
            // If there are two pairs (1, 2) and (2, 1), bring (1, 2) higher in the heap for predictable output.
            queue.Enqueue((0, 0), (list1[0] + list2[0], list1[0]));
        }

        int i = 0;
        while (i < target && queue.Count != 0)
        {
            (int i1, int i2) = queue.Dequeue();

            if (pairs.Contains((i1, i2))) { continue; }

            pairs.Add((i1, i2));

            if (i1 != list1.Length - 1)
            {
                queue.Enqueue((i1 + 1, i2), (list1[i1 + 1] + list2[i2], list1[i1 + 1]));
            }

            if (i2 != list2.Length - 1)
            {
                queue.Enqueue((i1, i2 + 1), (list1[i1] + list2[i2 + 1], list1[i1]));
            }

            i++;
        }

        return pairs
            .Select(pair => new List<int> { list1[pair.Item1], list2[pair.Item2] })
            .Cast<IList<int>>()
            .ToList();
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([1, 1, 2], [1, 2], 7, [[1, 1], [1, 1], [1, 2], [1, 2], [2, 1], [2, 2]]);
    }

    private static void Run(int[] list1, int[] list2, int target, IList<IList<int>> expectedResult)
    {
        IList<IList<int>> result = Solution.KSmallestPairs(list1, list2, target);
        Utilities.PrintSolution((list1, list2, target), result);
        CollectionAssert.AreEqual(expectedResult.ToArray(), result.ToArray());
    }
}
