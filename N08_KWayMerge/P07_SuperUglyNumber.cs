// Super Ugly Number
// =================
//
// Given an integer `n` and an array of distinct prime numbers `primes`, return the n-th super ugly number. A super ugly
// number is a positive integer whose only prime factors are from a given array `primes`.
//
// The n-th super ugly number is guaranteed to fit within a 32-bit signed integer.
//
// Constraints:
//
// - 1 ≤ `n` ≤ 10^5
// - 1 ≤ `primes.length` ≤ 100
// - 2 ≤ `primes[i]` ≤ 1000
// - `primes[i]` is guaranteed to be a prime number.
// - All the values of `primes` are unique and sorted in an ascending order.

using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N08_KWayMerge.P07_SuperUglyNumber;

public class Solution
{
    // Time complexity: O(n*logp), Space complexity: O(n+p).
    public static int NthSuperUglyNumber(int n, int[] primes)
    {
        var uglyNumbers = new List<int> { 1 };

        // Multiple is actually the number at uglyNumbers[multiple];
        var queue = new PriorityQueue<(int prime, int multiple), int>();

        foreach (int prime in primes)
        {
            queue.Enqueue((prime, 0), prime * uglyNumbers[0]);
        }

        while (uglyNumbers.Count < n)
        {
            (int prime, int multiple) = queue.Dequeue();

            // There can be multiple ways a number can be reached e.g. 6*5 and 10*3. Skip duplicates.
            int number = prime * uglyNumbers[multiple];
            if (uglyNumbers[^1] != number)
            {
                uglyNumbers.Add(number);
            }

            queue.Enqueue((prime, multiple + 1), prime * uglyNumbers[multiple + 1]);
        }

        return uglyNumbers[^1];
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run(1, [2, 3, 5, 7, 11], 1);
        Run(13, [2, 3, 5, 7, 11], 14);
        Run(22, [2, 3, 5, 7, 11], 27);
    }

    private static void Run(int n, int[] primes, int expectedResult)
    {
        int result = Solution.NthSuperUglyNumber(n, primes);
        Utilities.PrintSolution((n, primes), result);
        Assert.AreEqual(expectedResult, result);
    }
}
