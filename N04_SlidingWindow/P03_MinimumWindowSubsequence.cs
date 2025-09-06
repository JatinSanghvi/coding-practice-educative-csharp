// Minimum Window Subsequence
// ==========================
//
// Given two strings, `s1` and `s2`, find and return the shortest substring of `s1` in which all the characters of `s2`
// appear in the same order, but not necessarily next to each other (i.e., `s2` should be a subsequence of the
// substring).
//
// If no such substring exists, return an empty string `""`. If there are multiple shortest substrings, return the one
// that appears first in `s1` (i.e., with the left-most starting index).
//
// > Note: A substring is a contiguous sequence of characters within a string. A subsequence is a sequence of characters
// > that can be derived from a string by deleting some characters without changing the order of the remaining
// > characters. For example, "edu" is a substring and "cave" is a subsequence of "educative."
//
// Constraints:
//
// - 1 ≤ `s1.length` ≤ 2×10^3
// - 1 ≤ `s2.length` ≤ 100
// - `s1` and `s2` consist of uppercase and lowercase English letters.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N04_SlidingWindow.P03_MinimumWindowSubsequence;

public class Solution
{
    // Time complexity: O(n*m), Space complexity: O(1).
    public static string MinWindow(string s1, string s2)
    {
        string minWindow = string.Empty;

        int pos1 = 0, pos2 = 0;

        while (pos1 < s1.Length)
        {
            if (s1[pos1] == s2[pos2]) { pos2++; }
            pos1++;

            if (pos2 == s2.Length)
            {
                // Backtrack to minimize the sliding window length.
                int rpos1 = pos1 - 1, rpos2 = pos2 - 1;
                while (rpos2 >= 0)
                {
                    if (s1[rpos1] == s2[rpos2]) { rpos2--; }
                    rpos1--;
                }

                if (string.IsNullOrEmpty(minWindow) || minWindow.Length > (pos1 - rpos1 - 1))
                {
                    minWindow = s1[(rpos1 + 1)..pos1];
                }

                pos1 = rpos1 + 2;
                pos2 = 0;
            }
        }

        return minWindow;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run("a", "a", "a");
        Run("ababacac", "abc", "abac");
    }

    private static void Run(string s1, string s2, string expectedResult)
    {
        string result = Solution.MinWindow(s1, s2);
        Utilities.PrintSolution((s1, s2), result);
        Assert.AreEqual(expectedResult, result);
    }
}
