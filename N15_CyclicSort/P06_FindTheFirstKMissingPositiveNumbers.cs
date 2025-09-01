// Find the First K Missing Positive Numbers
// =========================================
//
// Given an unsorted integer array, `arr`, of size `n` and an integer `k`, find the first `k` missing positive integers
// from the array, ignoring all negative numbers and zeros.
//
// If the array does not contain enough missing positive numbers, add the next consecutive positive integers, starting
// from the smallest number greater than the largest value in the array, until exactly `k` missing positive numbers have
// been found.
//
// Return the list of the first `k` missing positive integers, sorted in ascending order.
//
// Constraints:
//
// - n = `arr.length`
// - 1 ≤ k ≤ 10^4
// - -10^4 ≤ `arr[i]` ≤ 10^4
// - 0 ≤ n ≤ 10^4

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N15_CyclicSort.P06_FindTheFirstKMissingPositiveNumbers;

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
