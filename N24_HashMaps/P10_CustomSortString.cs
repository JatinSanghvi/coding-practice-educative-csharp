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
    // Time complexity: O(s), Space complexity: O(1).
    public static string CustomSortString(string order, string s)
    {
        var counts = new int[26];
        foreach (char ch in s)
        {
            counts[ch - 'a']++;
        }

        var sorted = new char[s.Length];
        int pos = 0;

        foreach (char ch in order)
        {
            while (counts[ch - 'a'] != 0)
            {
                sorted[pos++] = ch;
                counts[ch - 'a']--;
            }
        }

        for (int i = 0; i != 26; i++)
        {
            while (counts[i] != 0)
            {
                sorted[pos++] = (char)('a' + i);
                counts[i]--;
            }
        }

        return new string(sorted);
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run("dc", "abcdabcd", "ddccaabb");
    }

    private static void Run(string order, string s, string expectedResult)
    {
        string result = Solution.CustomSortString(order, s);
        Utilities.PrintSolution((order, s), result);
        Assert.AreEqual(expectedResult, result);
    }
}
