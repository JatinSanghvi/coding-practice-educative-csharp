// Find K-th Smallest Pair Distance
// ================================
//
// Given an array of integers `nums` and an integer `k`, return the k-th smallest distance between any pair of integers
// (`nums[i]`, `nums[j]`), where 0 ≤ i < j < `nums.length`.
//
// > The distance between a pair of integers, a and b, is defined as the absolute difference between them.
//
// Constraints:
//
// - n == `nums.length`
// - 2 ≤ n ≤ 10^3
// - 0 ≤ `nums[i]` ≤ 10^3
// - 1 ≤ `k` ≤ n × (n - 1) / 2
//
// > Note: Given an array of size n, the total number of possible pairs is given by nC_2. As nC_2 evaluates to n × (n -
// > 1) / 2, there are exactly this many possible k-distances.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N17_SortAndSearch.P10_FindKthSmallestPairDistance;

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
