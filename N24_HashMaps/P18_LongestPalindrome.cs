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

using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N24_HashMaps.P18_LongestPalindrome;

public class Solution
{
    // Time complexity: O(n), Space complexity: O(52).
    public static int LongestPalindrome(string s)
    {
        var counts = new Dictionary<char, int>();

        foreach (char ch in s)
        {
            counts[ch] = counts.GetValueOrDefault(ch) + 1;
        }

        int sum = 0;

        foreach (int count in counts.Values)
        {
            sum += count / 2 * 2; // Add 2 for every letter pair.
            sum |= count % 2; // Add 1 the first time an odd letter count is found.
        }

        return sum;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run("ababa", 5);
        Run("ababab", 5);
        Run("abababa", 7);
        Run("abababab", 8);
    }

    private static void Run(string s, int expectedResult)
    {
        int result = Solution.LongestPalindrome(s);
        Utilities.PrintSolution(s, result);
        Assert.AreEqual(expectedResult, result);
    }
}
