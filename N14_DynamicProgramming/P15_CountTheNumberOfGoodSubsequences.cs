// Count the Number of Good Subsequences
// =====================================
//
// Count and return the number of good subsequences in the given string `s`. You may return the modulo 10^9 + 7 of the
// count.
//
// - A subsequence is a sequence formed from another sequence by deleting some or no elements while keeping the order of
//   the remaining elements unchanged.
// - A good subsequence is a subsequence of a string if it is not empty and the frequency of each character is the same.
//
// Constraints:
//
// - 1 ≤ `s.length` ≤ 10^4
// - `s` will only contain lowercase English characters.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N14_DynamicProgramming.P15_CountTheNumberOfGoodSubsequences;

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
