// Random Pick with Weight
// =======================
//
// You're given an array of positive integers, `weights`, where `weights[i]` is the weight of the i-th index.
//
// Write a function, Pick Index(), which performs weighted random selection to return an index from the `weights` array.
// The larger the value of `weights[i]`, the heavier the weight is, and the higher the chances of its index being
// picked.
//
// Suppose that the array consists of the weights [12, 84, 35]. In this case, the probabilities of picking the indexes
// will be as follows:
//
// - Index 0: 12 / (12 + 84 + 35) = 9.2%
// - Index 1: 84 / (12 + 84 + 35) = 64.1%
// - Index 2: 35 / (12 + 84 + 35) = 26.7%
//
// Constraints:
//
// - 1 ≤ `weights.length` ≤ 10^4
// - 1 ≤ `weights[i]` ≤ 10^5
// - Pick Index() will be called at most 10^4 times.
//
// > Note: Since we're randomly choosing from the options, there is no guarantee that in any specific run of the
// > program, any of the elements will be selected with the exact expected frequency.

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N10_ModifiedBinarySearch.P04_RandomPickWithWeight;

public class Solution
{
    private readonly int[] _ranges;
    private readonly int _len;
    private readonly int _sum;
    private readonly Random _random = new Random();

    // Time complexity: O(n), Space complexity: O(n).
    public Solution(int[] weights)
    {
        _ranges = new int[weights.Length];

        for (int i = 1; i < weights.Length; i++)
        {
            _ranges[i] = _ranges[i - 1] + weights[i - 1];
        }

        _len = _ranges.Length;
        _sum = _ranges[^1] + weights[^1];
    }

    // Time complexity: O(logn), Space complexity: O(1).
    public int PickIndex()
    {
        int num = _random.Next(_sum);

        int low = 0, high = _len;
        while (high - low != 1)
        {
            int mid = (low + high) / 2;

            if (num < _ranges[mid]) { high = mid; }
            else { low = mid; }
        }

        return low;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([1, 2, 3]);
    }

    private static void Run(int[] weights)
    {
        int calls = weights.Sum() * 1000;
        var solution = new Solution(weights);

        var counts = new Dictionary<int, int>();
        for (int i = 0; i < calls; i++)
        {
            int index = solution.PickIndex();
            counts.TryAdd(index, 0);
            counts[index]++;
        }

        var actualWeights = new int[weights.Length];
        for (int i = 0; i < weights.Length; i++)
        {
            actualWeights[i] = (counts[i] + 500) / 1000;
        }

        Utilities.PrintSolution(weights, actualWeights);
        CollectionAssert.AreEqual(weights, actualWeights);
    }
}
