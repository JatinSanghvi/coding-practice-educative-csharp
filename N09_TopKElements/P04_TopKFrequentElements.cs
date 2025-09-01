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

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N09_TopKElements.P04_TopKFrequentElements;

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
