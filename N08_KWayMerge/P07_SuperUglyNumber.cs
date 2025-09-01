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

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N08_KWayMerge.P07_SuperUglyNumber;

public class Solution
{
    public static bool Function()
    {
        return true;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run(true);
    }

    private static void Run(bool expectedResult)
    {
        bool result = Solution.Function();
        Utilities.PrintSolution(true, result);
        Assert.AreEqual(expectedResult, result);
    }
}
