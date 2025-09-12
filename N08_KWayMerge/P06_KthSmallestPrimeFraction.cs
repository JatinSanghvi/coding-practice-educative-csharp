// Kth Smallest Prime Fraction
// ===========================
//
// You are given a sorted array of unique integers, `arr`, which includes the number 1 and other prime numbers. You are
// also given an integer `k`.
//
// For every index i and j where 0 ≤ i < j < `arr.length`, you can form a fraction by taking the number at index i as
// the numerator and the number at index j as the denominator, resulting in the fraction `arr[i] / arr[j]`.
//
// Your task is to return the kth smallest fraction among these fractions. The answer should be returned as an array of
// two integers, where the first element, `answer[0]`, is the numerator (`arr[i]`), and the second element, `answer[1]`,
// is the denominator (`arr[j]`) corresponding to the kth smallest fraction.
//
// Constraints:
//
// - 2 ≤ `arr.length` ≤ 10^3
// - 1 ≤ `arr[i]` ≤ 3 × 10^4
// - `arr[0]` = 1
// - `arr[i]` is a prime number for i > 0.
// - All the numbers of `arr` are unique and sorted in strictly increasing order.
// - 1 ≤ `k` ≤ `arr.length` × (`arr.length` - 1)

using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N08_KWayMerge.P06_KthSmallestPrimeFraction;

public class Solution
{
    // Time complexity: O(n^2*logn), Space complexity: O(n).
    public static int[] KthSmallestPrimeFraction(int[] arr, int k)
    {
        var queue = new PriorityQueue<(int, int), double>();

        for (int den = 1; den < arr.Length; den++)
        {
            queue.Enqueue((0, den), (double)arr[0] / arr[den]);
        }

        for (int i = 1; i < k; i++)
        {
            (int num, int den) = queue.Dequeue();
            if (num != arr.Length - 1)
            {
                queue.Enqueue((num + 1, den), (double)arr[num + 1] / arr[den]);
            }
        }

        (int ansNum, int ansDen) = queue.Peek();
        return new int[] { arr[ansNum], arr[ansDen] };
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([1, 3, 11, 13, 31], 1, [1, 31]);
        Run([1, 3, 11, 13, 31], 10, [11, 13]);
    }

    private static void Run(int[] arr, int k, int[] expectedResult)
    {
        int[] result = Solution.KthSmallestPrimeFraction(arr, k);
        Utilities.PrintSolution((arr, k), result);
        CollectionAssert.AreEqual(expectedResult, result);
    }
}
