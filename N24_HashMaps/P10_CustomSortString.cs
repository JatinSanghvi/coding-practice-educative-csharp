// Custom Sort String
// ==================
//
// Given two strings, `order` and `s`, where all characters in `order` are unique and arranged in a custom order, return
// any permutation of `s` that satisfies the following condition:
//
// The characters in the permuted `s` should appear in the same relative order as they do in `order`. Specifically, if a
// character `x` appears before a character `y` in `order`, then `x` must also appear before `y` in the permuted string.
//
// Constraints:
//
// - 1 ≤ `order.length` ≤ 26
// - 1 ≤ `s.length` ≤ 200
// - `order` and `s` consist of lowercase English letters.
// - All the characters of `order` are *unique*.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N24_HashMaps.P10_CustomSortString;

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
