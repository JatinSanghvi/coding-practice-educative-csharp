// Total Appeal of a String
// ========================
//
// Given a string `s`, return its total appeal, which is calculated by summing the appeals of all its substrings.
//
// > The appeal of a string is defined as the count of unique characters present in that string.
//
// For instance, the appeal of "xyzxz" is 3, as it contains three distinct characters: 'x', 'y', and 'z'.
//
// Constraints:
//
// - 1 ≤ `s.length` ≤ 10^3
// - `s` consists of only lowercase English letters.

using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N24_HashMaps.P13_TotalAppealOfAString;

public class Solution
{
    // Time complexity: O(n), Space complexity: O(26).
    public static int AppealSum(string s)
    {
        // We calculate the appeals added by every character one at a time across all substrings it is part of. A
        // character at position i is part of every substring that starts at index 0..i and end at i..(n - 1) inclusive
        // which sums up to (i + 1) * (n - i) substrings. However, we only need to consider the substrings where the
        // character is the first one of its kind to be able to contribute to the appeals, which will be
        // (i - j) * (n - 1) where j is the previous position of the same character.
        int len = s.Length;
        var positions = Enumerable.Repeat(-1, 26).ToArray();
        int appeals = 0;

        for (int i = 0; i != len; i++)
        {
            int ch = s[i] - 'a';
            appeals += (i - positions[ch]) * (len - i);
            positions[ch] = i;
        }

        return appeals;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run("aabb", 14);
        Run("abab", 16);
    }

    private static void Run(string s, int expectedResult)
    {
        int result = Solution.AppealSum(s);
        Utilities.PrintSolution(s, result);
        Assert.AreEqual(expectedResult, result);
    }
}
