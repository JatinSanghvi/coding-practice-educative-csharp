// K-th Smallest in Lexicographical Order
// ======================================
//
// Given two integers, `n` and `k`, return the kth smallest number in the range `[1, n]` when the numbers are sorted
// lexicographically.
//
// > Note: Lexicographical sorting means ordering numbers like words in a dictionary (alphabetical order)---digit by
// > digit from left to right. For example, the numerical order of 1, 5, and 10 is [1, 5, 10], but their lexicographical
// > order is [1, 10, 5].
//
// Constraints:
//
// - 1 ≤ `k` ≤ `n` ≤ 10^9

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N23_Trie.P09_KthSmallestInLexicographicalOrder;

public class Solution
{
    // Time complexity: O(10*log_10(n)*log_10(n)), Space complexity: O(1).
    public static int FindKthNumber(int n, int k)
    {
        int prefix = 1;

        while (k != 1)
        {
            int count = CountNumbers(prefix);
            if (k > count) // Next prefix.
            {
                prefix++;
                k -= count;
            }
            else // Same prefix. Go deeper.
            {
                prefix *= 10;
                k -= 1;
            }
        }

        return prefix; // Result is same as prefix after it's entirely decoded.

        int CountNumbers(int prefix)
        {
            int count = 0;
            for (long multiple = 1; prefix * multiple <= n; multiple *= 10)
            {
                count += Math.Min((int)multiple, n + 1 - prefix * (int)multiple);
            }

            return count;
        }
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run(123, 1, 1);
        Run(123, 3, 100);
        Run(123, 28, 123);
        Run(123, 123, 99);

        Run(1_000_000_000, 1_000_000_000, 999_999_999);
    }

    private static void Run(int n, int k, int expectedResult)
    {
        int result = Solution.FindKthNumber(n, k);
        Utilities.PrintSolution((n, k), result);
        Assert.AreEqual(expectedResult, result);
    }
}
