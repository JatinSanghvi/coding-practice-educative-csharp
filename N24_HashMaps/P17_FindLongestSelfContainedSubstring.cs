// Find Longest Self-Contained Substring
// =====================================
//
// You are given a string, `s`, consisting of lowercase English letters. Your task is to find the length of the longest
// self-contained substring of `s`.
//
// A substring `t` of `s` is called self-contained if:
//
// - `t` is not equal to the entire string `s`.
// - Every character in `t` does not appear anywhere else in `s` (outside of `t`).
//
// In other words, all characters in `t` are completely unique to that substring within the string `s`.
//
// Return the length of the longest self-contained substring. If no such substring exists, return -1.
//
// Constraints:
//
// - 2 ≤ `s.length` ≤ 1000
// - `s` consists only of lowercase English letters.

using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N24_HashMaps.P17_FindLongestSelfContainedSubstring;

public class Solution
{
    // Time complexity: O(26n), Space complexity: O(26).
    public static int MaxSubstringLength(string s)
    {
        int len = s.Length;

        // Note indexes of first and last occurrence of each letter.
        var first = Enumerable.Repeat(-1, 26).ToArray();
        var last = Enumerable.Repeat(-1, 26).ToArray();

        for (int i = 0; i != len; i++)
        {
            int ch = s[i] - 'a';
            if (first[ch] == -1) { first[ch] = i; }
            last[ch] = i;
        }

        int maxLen = -1;

        // The start index and end index of the substring will be respectively the index of first occurrence of some
        // letter, L1 and last occurence of some letter, L2. L1 and L2 can be same or different. The first and last
        // occurrences of every letter should either be fully inside substring or fully outside.
        for (int ch1 = 0; ch1 != 26; ch1++)
        {
            int start = first[ch1];
            if (start == -1) { continue; }

            int minEnd = last[ch1]; // Minimum possible 'end' index for given 'start' index.
            for (int end = start; end != len; end++)
            {
                int ch2 = s[end] - 'a';
                if (first[ch2] < start) { break; } // Substring cannot start at index 'start'.

                minEnd = Math.Max(minEnd, last[ch2]);
                if (end == minEnd && (start != 0 || end != len - 1))
                {
                    maxLen = Math.Max(maxLen, end - start + 1);
                }
            }
        }

        return maxLen;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run("aaaa", -1);
        Run("abab", -1);
        Run("abba", 2);
        Run("abac", 3);
        Run("abcb", 3);
    }

    private static void Run(string s, int expectedResult)
    {
        int result = Solution.MaxSubstringLength(s);
        Utilities.PrintSolution(s, result);
        Assert.AreEqual(expectedResult, result);
    }
}
