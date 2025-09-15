// Top K Frequent Elements
// =======================
//
// Given an array of integers, `arr`, and an integer, `k`, return the k most frequent elements.
//
// > Note: You can return the answer in any order.
//
// Constraints:
//
// - 1 ≤ `arr.length` ≤ 10^3
// - -10^4 ≤ `arr[i]` ≤ 10^4
// - 1 ≤ k ≤ number of unique elements in an array.
// - It is guaranteed that the answer is unique.

using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N09_TopKElements.P04_TopKFrequentElements;

public class Solution
{
    // Time complexity: O(n*logk), Space complexity: O(n+k).
    public static int[] TopKFrequent(int[] arr, int k)
    {
        var counts = new Dictionary<int, int>();
        foreach (int num in arr)
        {
            counts.TryAdd(num, 0);
            counts[num]++;
        }

        var countQueue = new PriorityQueue<int, int>();

        foreach (KeyValuePair<int, int> pair in counts)
        {
            countQueue.Enqueue(pair.Key, pair.Value);
            if (countQueue.Count > k)
            {
                countQueue.Dequeue();
            }
        }

        return countQueue.UnorderedItems.Select(item => item.Element).ToArray();
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([1, 2, 3, 1, 2], 2, [1, 2]);
    }

    private static void Run(int[] arr, int k, int[] expectedResult)
    {
        int[] result = Solution.TopKFrequent(arr, k);
        Utilities.PrintSolution((arr, k), result);
        CollectionAssert.AreEqual(expectedResult, result);
    }
}
