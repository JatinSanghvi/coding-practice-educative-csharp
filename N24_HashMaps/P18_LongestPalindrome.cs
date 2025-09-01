// Longest Palindrome
// ==================
//
// Given a string `s` that only contains alphabets, return the length of the longest palindrome that may be composed
// using those letters.
//
// > Note: Letters are case-sensitive. Hence, combinations such as "`Aa`" are not considered palindromes.
//
// Constraints:
//
// - 1 ≤ `s.length` ≤ 10^3
// - `s` consists of lowercase and/or uppercase English letters only.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N24_HashMaps.P18_LongestPalindrome;

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
