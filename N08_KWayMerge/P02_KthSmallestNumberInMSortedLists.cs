// Kth Smallest Number in M Sorted Lists
// =====================================
//
// Given a list, `lists`, containing m sorted lists of integers in ascending order, and an integer `k`, find the kth
// smallest element among all the lists.
//
// Even if some values appear multiple times across the lists, each occurrence is treated as a unique element when
// determining the k-th smallest number.
//
// If `k` exceeds the total number of elements across all lists, return the largest element among them. If the lists are
// empty, return `0`.
//
// Constraints:
//
// - 1 ≤ m ≤ 50
// - 0 ≤ `lists[i].length` ≤ 50
// - -10^9 ≤ `lists[i][j]` ≤ 10^9
// - 1 ≤ `k` ≤ 10^9

using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N08_KWayMerge.P02_KthSmallestNumberInMSortedLists;

public class Solution
{
    // Time complexity: O((k+m)*logm) where m = list-count, Space complexity: O(m).
    public static int KSmallestNumber(List<List<int>> lists, int k)
    {
        var queue = new PriorityQueue<(int, int), int>();

        for (int li = 0; li < lists.Count; li++)
        {
            if (lists[li].Count != 0)
            {
                queue.Enqueue((li, 0), lists[li][0]);
            }
        }

        if (queue.Count == 0) { return 0; }

        for (int rank = 1; ; rank++)
        {
            (int li, int i) = queue.Dequeue();

            if (i < lists[li].Count - 1)
            {
                queue.Enqueue((li, i + 1), lists[li][i + 1]);
            }

            if (queue.Count == 0 || rank == k)
            {
                return lists[li][i];
            }
        }
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([[1, 2, 4], [], [3, 5]], 1, 1);
        Run([[4, 6], [2, 3], [8, 9]], 10, 9);
    }

    private static void Run(int[][] listArrays, int k, int expectedResult)
    {
        List<List<int>> lists = listArrays.Select(list => list.ToList()).ToList();
        int result = Solution.KSmallestNumber(lists, k);
        Utilities.PrintSolution((lists, k), result);
        Assert.AreEqual(expectedResult, result);
    }
}
