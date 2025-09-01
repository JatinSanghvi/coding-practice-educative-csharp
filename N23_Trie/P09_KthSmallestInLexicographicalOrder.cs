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

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N23_Trie.P09_KthSmallestInLexicographicalOrder;

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
