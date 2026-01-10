// Count Triplets That Can Form Two Arrays of Equal XOR
// ====================================================
//
// Given an array of integers, `arr`, we need to find three indices, `i`, `j`, and `k`, such that 0 ≤ `i` < `j` ≤ `k` <
// `arr.length`.
//
// We define two values, `a` and `b`, as follows:
// - `a = arr[i] ^ arr[i + 1] ^ ... ^ arr[j - 1]`
// - `b = arr[j] ^ arr[j + 1] ^ ... ^ arr[k]`
//
// > Note: ^ denotes the bitwise-xor operation.
//
// Return the count of triplets (`i`, `j`, `k`) for which `a` is equal to `b`.
//
// Constraints:
//
// - 1 ≤ `arr.length` ≤ 300
// - 1 ≤ `arr[i]` ≤ 1000

using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N28_BitwiseManipulation.P11_CountTripletsThatCanFormTwoArraysOfEqualXOR;

public class Solution
{
    // Time complexity: O(n), Space complexity: O(n).
    public static int CountTriplets(int[] arr)
    {
        var indexCounts = new Dictionary<int, int> { [0] = 1 };
        var indexSums = new Dictionary<int, int> { [0] = -1 };

        int xor = 0;
        int triplets = 0;

        for (int index = 0; index != arr.Length; index++)
        {
            xor ^= arr[index];

            // It is not required to ignore the (i - 1)th element. We will never have the same XOR result for successive
            // indexes, since arr[i] cannot be 0.
            if (indexCounts.ContainsKey(xor))
            {
                triplets += (index - 1) * indexCounts[xor] - indexSums[xor];
            }

            indexCounts.TryAdd(xor, 0);
            indexSums.TryAdd(xor, 0);

            indexCounts[xor] += 1;
            indexSums[xor] += index;

            Console.WriteLine($"xor: {xor:x}, triplets: {triplets}, index: {index}, indexCount: {indexCounts[xor]}, indexSum: {indexSums[xor]}");
        }

        return triplets;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([1], 0);
        Run([1, 2, 1, 2, 1], 6);
    }

    private static void Run(int[] arr, int expectedResult)
    {
        int result = Solution.CountTriplets(arr);
        Utilities.PrintSolution(arr, result);
        Assert.AreEqual(expectedResult, result);
    }
}
