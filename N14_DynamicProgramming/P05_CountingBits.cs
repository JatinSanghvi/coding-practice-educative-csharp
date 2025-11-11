// Counting Bits
// =============
//
// For a given positive integer, `n`, your task is to return an array of length n+1 such that for each x where 0 ≤ x ≤
// n, `result[x]` is the count of 1s in the binary representation of x.
//
// Constraints:
//
// - 0 ≤ n ≤ 10^4

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N14_DynamicProgramming.P05_CountingBits;

public class Solution
{
    // Time complexity: O(n), Space complexity: O(1).
    public static int[] CountingBits(int n)
    {
        var bitCounts = new int[n + 1];

        int diff = 1;
        for (int i = 1; i < n + 1; i++)
        {
            if (i == 2 * diff) { diff *= 2; }
            bitCounts[i] = bitCounts[i - diff] + 1;
        }

        return bitCounts;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run(7, [0, 1, 1, 2, 1, 2, 2, 3]);
    }

    private static void Run(int n, int[] expectedResult)
    {
        int[] result = Solution.CountingBits(n);
        Utilities.PrintSolution(n, result);
        CollectionAssert.AreEqual(expectedResult, result);
    }
}
