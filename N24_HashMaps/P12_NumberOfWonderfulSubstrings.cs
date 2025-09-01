// Number of Wonderful Substrings
// ==============================
//
// A wonderful string is defined as a string in which at most one letter occurs an odd number of times.
//
// For example:
//
// - The string "aabbc" is wonderful because only the letter `'c'` appears an odd number of times.
// - The string "pqpq" is wonderful because all letters appear an even number of times.
// - The string "mn" is not wonderful because both `'m'` and `'n'` appear an odd number of times.
//
// You are given a string `word` that consists of lowercase English letters from `'a'` to `'j'`. Your task is to return
// the total number of wonderful non-empty substrings in `word`.
//
// > Note: If a substring appears multiple times, each occurrence should be counted separately.
//
// Constraints:
//
// - 1 ≤ `word.length` ≤ 10^3
// - `word` consists of lowercase English letters from `'a'` to `'j'`.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N24_HashMaps.P12_NumberOfWonderfulSubstrings;

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
